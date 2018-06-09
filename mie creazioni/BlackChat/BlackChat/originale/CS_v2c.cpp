
// Client/Server v2c
// author: N0R81X
// mail: xibron[at]gmail[dot]com
// msn: bobcat01@hotmail.com

// socket non bloccante
// strumenti -> opzioni compilazione -> linker -> -lwsock32
// digitare link.break per interrompere la connessione

// ok grazie, aggiornato il source ora c'è il chat mode il logger mode e mi manca solo mettere un file
// di configurazione che viene scritto automaticamente dal programma la prima volta che si avvia, su cui
// si può agire per cambiare il nickname salvato, il colore del testo, se abilitare o meno il logger mode
// e se attivare le segnalazioni acustiche quando si connette o arrivano messaggi.....

// bene, ora tutto ciò è stato implementato, questo penso sia il programma più serio e complesso che abbia
// creato fino ad ora, spero non sia giudicato come software-cartaigienica..

// altra cosa, rock 'n' roll!

#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>

long r = 0; // received bytes
long s = 0; // sent bytes    
int i;
char tx[1024], rx[1024]; // buffer trasmissione e ricezione
char temp[1024]; // buffer temporaneo per ricevere il testo da tastiera

// impostazioni lette dal file config.cfg
int timeout; // timeout per le connessioni in millisecondi
bool logger_mode; // abilita la registrazione delle conversazioni/dati su file di testo
bool chat_mode; // abilita il nickname prima di ogni messaggio
char log_file[512]; // nome del file di testo menzionato sopra
int text_color; // colore del testo
char nickname[512]; // nickname per il chat_mode
bool acustic_segnalations; // abilita le segnalazioni acustiche quando c'è una connessione, e quando si ricevono messaggi
int beep_frequency; // frequenza dell'avviso acustico
int beep_time_ms; // durata in millisecondi degli avvisi acustici

void gotoXY(int x, int y);
void color(int color);
void intro(void);
void cfg_reader(void);
void logger(char *text);

void client(void);
void server(void);

void about(void);

int main()
{
     FILE *frw;
     char c, d, e;
     int i, strlen_oldnickname;

     intro();
     cfg_reader();

     restart:
     system("CLS");
     color(text_color);
     printf("\n\n N0R81X Client/Server v2c\n\n\n");
     printf("1 - Client\n");
     printf("2 - Server\n");
     printf("3 - About\n");
     printf("4 - Exit\n\n");

     fflush(stdin);
     c = getch();
     if(c == '3')
     {
          about();
          getch();
          goto restart;
     }
     if(c == '4') return 0;

     printf("\n\nChat Mode?(Y/N)");
     fflush(stdin);
     e = getch();

     if((e == 'y') || (e == 'Y')) chat_mode = 1;
     else chat_mode = 0;

     if(chat_mode)
     {
          printf("\n\nChat Mode ON, running nickname: %s", nickname);
          printf("\n\nChange?(Y/N)");

          fflush(stdin);
          d = getch();
          if((d == 'y') || (d == 'Y'))
          {
               strlen_oldnickname = strlen(nickname);
               printf(" -> ");
               fflush(stdin);
               gets(nickname);

               // salvataggio nuovo nick in config.cfg
               frw = fopen("config.cfg", "r+");
               fseek(frw, 72, SEEK_SET);
               for(i = 0; i < strlen_oldnickname; i++) fprintf(frw, " ");
               fseek(frw, 72, SEEK_SET);
               fprintf(frw, "%s", nickname);
               fclose(frw);
          }
     }

     if(c == '1') client();
     if(c == '2') server();
     if(c == '3') return 0;

     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     color(12);
     sprintf(temp, "\nConnection closed. %d bytes received and %d bytes sent\n\n", r, s);
     logger(temp);
     printf("\n\nConnection closed. %d bytes received and %d bytes sent\n", r, s);
     color(text_color);
     r = 0;
     s = 0;
     printf("\n 1 - Menu");
     printf("\n 2 - Exit");

     fflush(stdin);
     c = getch();

     if(c == '1') goto restart;
     if(c == '3') return 0;
}

void color(int color)
{
     SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}

void gotoXY(int x, int y)
{
     COORD CursorPos = {x, y};
     HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
     SetConsoleCursorPosition(hConsole, CursorPos);
}

void client(void)
{
     char addr[512], *addrR;
     unsigned int port; // le porte hanno un range di valori da 0 a 65535, proprio come una variabile unsigned int
     long j; // temporaney counter
     int connectionTime = 0; // tempo di connessione in ms

     SOCKET sock;
     WSADATA wsadata;
     WSAStartup(MAKEWORD(2,2), &wsadata);
     sock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

     u_long nonblock = 1;
     ioctlsocket(sock, FIONBIO, &nonblock); // configurazione non bloccante

     printf("\n\nAddress: ");
     fflush(stdin);
     gets(addr);

     printf("\nPort: ");
     fflush(stdin);
     scanf("%d", &port);

     color(12);
     printf("\nPress any key to connect");
     color(text_color);
     fflush(stdin);
     getch();

     hostent *hstnt = gethostbyname(addr);

     if(hstnt == NULL)
     {
          printf("\n\n%s can't be resolved", addr);
          return;
     }

     sockaddr_in sockaddr;
     sockaddr.sin_family = AF_INET;
     sockaddr.sin_addr = *((struct in_addr *)hstnt->h_addr); // DNS risolto in indirizzo IP (addrR)
     sockaddr.sin_port = htons(port);

     addrR = inet_ntoa(sockaddr.sin_addr);
     printf("\n\n%s resolved in %s", addr, addrR);

     connect(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     printf("\n\nConnecting");

     i = 0;
     while(send(sock, "", 0, 0) == -1)
     {
          Sleep(150);
          i += 150;
          connectionTime += 150;
          if(i == 150) printf(".");
          if(i == 300) printf(".");
          if(i == 450) printf(".");
          if(i == 600) printf(".");
          if(i == 750) printf(".");
          if(i == 900)
          {
               printf("\b \b\b \b\b \b\b \b\b \b");
               i = 0;
          }
          if(connectionTime == timeout)
          {
               printf("\rConnecting.....");
               printf("\nTimeout, no connection for %dms!!", timeout);
               return;
          }
     }

     printf("\rConnecting.....");
     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     printf("\n\nConnected to %s!! \n\n", addr);

     // logga indirizzo e porta
     if(logger_mode)
     {
          SYSTEMTIME st;
          GetLocalTime(&st);

          sprintf(temp, "\n\n >> >> >> New Connection - Client Mode - %02d/%02d/%02d %02d:%02d.%02d << << << \n\n", st.wDay, st.wMonth, st.wYear-2000, st.wHour, st.wMinute, st.wSecond);
          logger(temp);
          sprintf(temp, "Address: %s - %s", addr, addrR);
          logger(temp);
          sprintf(temp, "\nPort: %d\n\n", port);
          logger(temp);
     }

     while(1)
     {
          if(kbhit()) // se viene premuto un tasto non stampa ciò che riceve, e invia la frase battuta sulla tastiera
          {
               if(chat_mode) printf("<%s> ", nickname); // se chat_mode = 1 allora stampa a schermo il nickname quando si scrive qualcosa
               memset(temp, 0, 1024);
               memset(tx, 0, 1024);
               fgets(temp, 1023, stdin);

               if(strcmp(temp, "link.break\n") == 0) break; // se viene digitato "link.break" la connessione termina

               temp[strlen(temp)+1] = '\r';

               if(chat_mode) sprintf(tx, "<%s> %s", nickname, temp); // chat_mode 1 = aggiunge il nick all'inizio della roba da inviare
               else strcpy(tx, temp); // altrimenti invia solo ciò che è stato digitato

               if(logger_mode) logger(tx);
               j = send(sock, tx, strlen(tx), 0);
               if(j != -1) s += j;
               else break; // se send ritorna -1 allora byebye connessione.....
          }

          memset(rx, 0, 1024);
          j = recv(sock, rx, 1024, 0);

          if(j != -1)
          {
               if(acustic_segnalations && (j > 0)) Beep(beep_frequency, beep_time_ms);
               if(logger_mode) logger(rx);
               printf("%s", rx);
               r += j;
          }

          Sleep(1); // un sospiro per la CPU
     }

     closesocket(sock);
}

void server(void)
{
     unsigned int port; // le porte hanno un range di valori da 0 a 65535, proprio come una variabile unsigned int
     long j; // temporaney counter

     SOCKET sock, acceptsock;
     WSADATA wsadata;
     WSAStartup(MAKEWORD(2,2), &wsadata);
     sock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

     u_long nonblock = 1;
     ioctlsocket(sock, FIONBIO, &nonblock); // configurazione non bloccante

     printf("\n\nPort: ");
     fflush(stdin);
     scanf("%d", &port);

     color(12);
     printf("\nPress any key to listen");
     color(text_color);
     fflush(stdin);
     getch();

     sockaddr_in sockaddr;
     sockaddr.sin_family = PF_INET;
     sockaddr.sin_addr.s_addr = INADDR_ANY;
     sockaddr.sin_port = htons(port);

     bind(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     listen(sock, 1);

     printf("\n\nListening on port %d", port);
     acceptsock = (SOCKET)SOCKET_ERROR;

     i = 0;
     while(acceptsock == SOCKET_ERROR)
     {
          acceptsock = accept(sock, 0, 0);

          Sleep(150);
          i += 150;
          if(i == 150) printf(".");
          if(i == 300) printf(".");
          if(i == 450) printf(".");
          if(i == 600) printf(".");
          if(i == 750) printf(".");
          if(i == 900)
          {
               printf("\b \b\b \b\b \b\b \b\b \b");
               i = 0;
          }
     }

     printf("\rListening on port %d.....", port);
     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     printf("\n\nConnected!\n\n");

     // logga porta
     if(logger_mode)
     {
          SYSTEMTIME st;
          GetLocalTime(&st);

          sprintf(temp, "\n\n >> >> >> New Connection - Server Mode - %02d/%02d/%02d %02d:%02d:02 << << << \n\n", st.wDay, st.wMonth, st.wYear-2000, st.wHour, st.wMinute, st.wSecond);
          logger(temp);
          sprintf(temp, "Port: %d\n\n", port);
          logger(temp);
     }

     sock = acceptsock;

     while(1)
     {
          if(kbhit()) // se viene premuto un tasto non stampa ciò che riceve, e invia la frase battuta sulla tastiera
          {
               if(chat_mode) printf("<%s> ", nickname); // se chat_mode = 1 allora stampa a schermo il nickname quando si scrive qualcosa
               memset(temp, 0, 1024);
               memset(tx, 0, 1024);
               fgets(temp, 1023, stdin);

               if(strcmp(temp, "link.break\n") == 0) break; // se viene digitato "link.break" la connessione termina

               temp[strlen(temp)+1] = '\r';
               if(chat_mode) sprintf(tx, "<%s> %s", nickname, temp); // chat_mode 1 = aggiunge il nick all'inizio della roba da inviare
               else strcpy(tx, temp); // altrimenti invia solo ciò che è stato digitato

               if(logger_mode) logger(tx);
               j = send(sock, tx, strlen(tx), 0);
               if(j != -1) s += j;
               else break; // se send ritorna -1 allora byebye connessione.....
          }

          memset(rx, 0, 1024);
          j = recv(sock, rx, 1024, 0);

          if(j != -1)
          {
               if(acustic_segnalations && (j > 0)) Beep(beep_frequency, beep_time_ms);
               if(logger_mode) logger(rx);
               printf("%s", rx);
               r += j;
          }

          Sleep(1); // un sospiro per la CPU
     }

     closesocket(sock);
     closesocket(acceptsock);
}

void intro(void)
{
     int i = 1;

     while(1)
     {
          color(i);
          gotoXY(10, 5);

          printf("\n - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
          printf("\n  __       __     ______      ______       ______     __   __      __ ");
          printf("\n |  \\     |  |   /      \\    /      \\     /   _  \\   |  | |  |    |  |");
          printf("\n |   \\    |  |  /   __   \\  |    _   \\   |   / \\  \\  |  | |  |    |  |");
          printf("\n |    \\   |  | |   /  \\   | |   / \\   |  |  |   |  | |  | |   \\  /   |");
          printf("\n |     \\  |  | |  |    |  | |  |   |  |  |   \\_/  /  |  |  \\   \\/   / ");
          printf("\n |      \\ |  | |  |    |  | |   \\_/   /  |       /   |  |   \\      /  ");
          printf("\n |  |\\   \\|  | |  |    |  | |        /   |      |    |  |    |    |   ");
          printf("\n |  | \\      | |  |    |  | |   _   |    |    _  \\   |  |   /      \\  ");
          printf("\n |  |  \\     | |  |    |  | |  | \\  \\    |   / \\  \\  |  |  /   /\\   \\ ");
          printf("\n |  |   \\    | |   \\__/   | |  |  \\  \\   |  |   |  | |  | |   /  \\   |");
          printf("\n |  |    \\   |  \\        /  |  |   \\  \\  |   \\_/   / |  | |  |    |  |");
          printf("\n |__|     \\__|   \\______/   |__|    \\__\\  \\_______/  |__| |__|    |__|");
          printf("\n\n                        -- Client/Server v2c --                      \n");
          printf("\n - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
          printf("\n\n\n");

          Sleep(50);
          gotoXY(10, 5);

          if(i == 15) i = 1;
          else i++;

          if(kbhit())
          {
               getch();
               break;
          }
     }
}

void cfg_reader(void) // legge le impostazioni dal file config.cfg e le inserisce nelle varie variabili
{
     FILE *fr;
     FILE *fw;

     fr = fopen("config.cfg", "r");

     if(fr == NULL) // se non esiste il file di configurazione ne crea uno nuovo
     {
          fw = fopen("config.cfg", "w");

          fprintf(fw, "timeout_ms 3000");
          fprintf(fw, "\nlogger_mode 1");
          fprintf(fw, "\nlogfile CS_v2c.log");
          fprintf(fw, "\ntextcolor 10");
          fprintf(fw, "\nnickname N0R81X");
          fprintf(fw, "\nacustic_segnalations 1");
          fprintf(fw, "\nbeep_frequency 5000");
          fprintf(fw, "\nbeep_time_ms 50\n");

          fclose(fw);
          fr = fopen("config.cfg", "r");
     }

     fscanf(fr, "%s %d", temp, &timeout);
     fscanf(fr, "%s %d", temp, &logger_mode); // abilita la registrazione delle conversazioni/dati su file di testo
     fscanf(fr, "%s %s", temp, log_file); // nome del file di testo menzionato sopra
     fscanf(fr, "%s %d", temp, &text_color); // colore del testo
     fscanf(fr, "%s %s", temp, nickname); // nickname per il chat_mode
     fscanf(fr, "%s %d", temp, &acustic_segnalations); // abilita le segnalazioni acustiche quando c'è una connessione, e quando si ricevono messaggi
     fscanf(fr, "%s %d", temp, &beep_frequency); // frequenza dell'avviso acustico
     fscanf(fr, "%s %d", temp, &beep_time_ms); // durata in millisecondi degli avvisi acustici

     fclose(fr);
}

void logger(char *text)
{
     FILE *log;
     log = fopen(log_file, "a");
     if(log != NULL)
     {
          fprintf(log, "%s", text);
          fclose(log);
     }
}

void about(void)
{
     printf("\n\nN0R81X Client/Server Software, version 2c\n\n");
     printf("Author: N0R81X\n");
     printf("E-Mail: xibron[at]gmail[dot]com\n");
     printf("MSN:    bobcat01@hotmail.com\n\n");
     printf("\"One of these days.. I\'m going to cut you into little pieces\" - Pink Floyd\n\n");
     printf("- Type \"link.break\" while connected to break connection\n");
     printf("- A config.cfg file is generated in the same directory of the main program, edit it to change various software options\n");
}
