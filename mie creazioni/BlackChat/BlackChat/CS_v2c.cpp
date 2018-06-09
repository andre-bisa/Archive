// mettere nelle opzioni del progetto poi nella scheda "Parametri" e poi nella sezioni linker la scritta: "-lwsock32"

#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <string>

using namespace std;

long r = 0; 
long s = 0; 
int a;
int c=1;
int i;
int w;
char tx[1024], rx[1024], rx2[1024]; // buffer trasmissione e ricezione
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
void cfg_reader(void);
void logger(char *text);

void client(void);
void server(void);
void ricevere();

void about(void);

int main()
{
    system("title BlackChat by Blackname");
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

     port=4037;

     hostent *hstnt = gethostbyname("192.168.0.102");

     if(hstnt == NULL)
     {
          printf("\n\nImpossibile trovare host per ricercare aggirnamenti");
          exit(8);
     }

     sockaddr_in sockaddr;
     sockaddr.sin_family = AF_INET;
     sockaddr.sin_addr = *((struct in_addr *)hstnt->h_addr); // DNS risolto in indirizzo IP (addrR)
     sockaddr.sin_port = htons(port);

     addrR = inet_ntoa(sockaddr.sin_addr);

     connect(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     printf("\n\nRicerca aggiornamenti in corso");

     i = 0;
     int q=0;
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
          if(connectionTime == 3000)
          {
               printf("\rRicerca aggiornamenti in corso.....");
               printf("\nTimeout, non connesso in 3000ms!!\n");
               system("pause");
               q=1;
               break;
          }
     }
     
     if(q!=1)
     {
     
     printf("\rRicerca aggiornamenti in corso.....");
     printf("\n\nConnesso, ricerca aggiornamenti in corso... \nPremere un tasto per saltare la ricerca di aggiornamenti!\n\nLeggere il file LEGGIMI per avere il link del forum da dove scaricare gli \naggiornamenti!\n");
     int z;
     while(!kbhit())
     {
          send(sock, "1.3", 4, 0);
               
          memset(rx, 0, 1024);
          j = recv(sock, rx, 1024, 0);
          if(j != -1)
          {
          if (rx[0] == '1') break;
          if (rx[0] == '0') {
                    printf("\nVersione non aggiornata visitare il forum per scaricare gli ultimi aggiornamenti\nLeggere il file LEGGIMI per avere il link del forum da dove scaricare gli \naggiornamenti!\n");
                    system("pause");
                    break;                    
          }
          printf("%s\n", rx);
          system("pause");
          }
          if(z==1000) 
          {
          cout<<"Errore impossibile trovare aggiornamenti, Timeout!\n";
          system("pause");
          break;
          }
          z++;
          
     }
     char c, d, e;
     if(kbhit())
     {
                c = getch();
     }

     closesocket(sock);
     }
     
     
     
     FILE *frw;
     char d, e;
     int i, strlen_oldnickname;

     cfg_reader();

     restart:
     sock=0;
     c=1;
     color(text_color);
     
     while(1)
{
   system("cls");
   color(12);
   cout<<"Scegli:\n\n";
   if (c==1)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Client\n";
   if (c==2)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Server\n";
   if (c==3)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Informazioni\n";
   if (c==4)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Esci\n";
   
   a = getch();
   
   if (a==27) exit(8);
   switch(c)
   {
            case (1):
            if (a==13)
            {
            printf("\n\nVuoi far vedere il nickname?(S/N)");
     fflush(stdin);
     e = getch();

     if((e == 's') || (e == 'S')) chat_mode = 1;
     else chat_mode = 0;

     if(chat_mode)
     {
          printf("\n\nNickname: %s", nickname);
          printf("\n\nCambiare?(S/N)");

          fflush(stdin);
          d = getch();
          if((d == 's') || (d == 'S'))
          {
               strlen_oldnickname = strlen(nickname);
               printf(" -> ");
               fflush(stdin);
               gets(nickname);

               // salvataggio nuovo nick in config.cfg
               frw = fopen("config.cfg", "r+");
               fseek(frw, 82, SEEK_SET);
               for(i = 0; i < strlen_oldnickname; i++) fprintf(frw, " ");
               fseek(frw, 82, SEEK_SET);
               fprintf(frw, "%s", nickname);
               fclose(frw);
          }
     }

            client();
     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     color(12);
     sprintf(temp, "\nConnessione chiusa. %d bytes ricevuti e %d bytes inviati\n\n", r, s);
     logger(temp);
     printf("\n\nConnessione chiusa. %d bytes ricevuti e %d bytes inviati\n", r, s);
     color(text_color);
     r = 0;
     s = 0;
     printf("\n 1 - Menu");
     printf("\n 2 - Esci");
     chied:
     c=0;
     fflush(stdin);
     c = getch();

     if(c == '1') goto restart;
     if(c == '2') exit(8);
     else goto chied;
            }
            if (a==80) c=2;
            if (a==72) c=4;
            break;
            case (2):
            if (a==13)
            {
            printf("\n\nVuoi far vedere il nickname?(S/N)");
     fflush(stdin);
     e = getch();

     if((e == 's') || (e == 'S')) chat_mode = 1;
     else chat_mode = 0;

     if(chat_mode)
     {
          printf("\n\nNickname: %s", nickname);
          printf("\n\nCambiare?(S/N)");

          fflush(stdin);
          d = getch();
          if((d == 's') || (d == 'S'))
          {
               strlen_oldnickname = strlen(nickname);
               printf(" -> ");
               fflush(stdin);
               gets(nickname);

               // salvataggio nuovo nick in config.cfg
               frw = fopen("config.cfg", "r+");
               fseek(frw, 82, SEEK_SET);
               for(i = 0; i < strlen_oldnickname; i++) fprintf(frw, " ");
               fseek(frw, 82, SEEK_SET);
               fprintf(frw, "%s", nickname);
               fclose(frw);
          }
     }

            server();
     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     color(12);
     sprintf(temp, "\nConnessione chiusa. %d bytes ricevuti e %d bytes inviati\n\n", r, s);
     logger(temp);
     printf("\n\nConnessione chiusa. %d bytes ricevuti e %d bytes inviati\n", r, s);
     color(text_color);
     r = 0;
     s = 0;
     printf("\n 1 - Menu");
     printf("\n 2 - Esci");
     chiedi:
     c=0;
     fflush(stdin);
     c = getch();

     if(c == '1') goto restart;
     if(c == '2') exit(8);
     else goto chiedi;
            }
            if (a==80) c=3;
            if (a==72) c=1;
            break;
            case (3):
            if (a==13)
            {
            about();
            goto restart;
            }
            if (a==80) c=4;
            if (a==72) c=2;
            break;
            case (4):
            if (a==13)
            {
            exit(8);
            }
            if (a==80) c=1;
            if (a==72) c=3;
            break;
            
   }
}
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

     printf("\n\nIndirizzo: ");
     fflush(stdin);
     gets(addr);

     port=4036;

     color(12);
     printf("\nPremi un tasto per connetterti");
     color(text_color);
     fflush(stdin);
     getch();

     hostent *hstnt = gethostbyname(addr);

     if(hstnt == NULL)
     {
          printf("\n\n%s impossibile risolvere", addr);
          return;
     }

     sockaddr_in sockaddr;
     sockaddr.sin_family = AF_INET;
     sockaddr.sin_addr = *((struct in_addr *)hstnt->h_addr); // DNS risolto in indirizzo IP (addrR)
     sockaddr.sin_port = htons(port);

     addrR = inet_ntoa(sockaddr.sin_addr);
     printf("\n\n%s risolto in %s", addr, addrR);

     connect(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     printf("\n\nConnessione in corso");

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
               printf("\rConnessione in corso.....");
               printf("\nTimeout, non connesso in %dms!!", timeout);
               return;
          }
     }

     printf("\rConnessione in corso.....");
     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     printf("\n\nConnesso in %s!! \n\n", addr);

     // logga indirizzo e porta
     if(logger_mode)
     {
          SYSTEMTIME st;
          GetLocalTime(&st);

          sprintf(temp, "\n\n >> >> >> Nuova connessione - Modalità Client - %02d/%02d/%02d %02d:%02d.%02d << << << \n\n", st.wDay, st.wMonth, st.wYear-2000, st.wHour, st.wMinute, st.wSecond);
          logger(temp);
          sprintf(temp, "Indirizzo: %s - %s", addr, addrR);
          logger(temp);
          sprintf(temp, "\nPorta: %d\n\n", port);
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

               if(strcmp(temp, "chat.stop\n") == 0) break; // se viene digitato "link.break" la connessione termina

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

     port=4036;

     color(12);
     printf("\nPremi un tasto per ascoltare");
     color(text_color);
     fflush(stdin);
     getch();

     sockaddr_in sockaddr;
     sockaddr.sin_family = PF_INET;
     sockaddr.sin_addr.s_addr = INADDR_ANY;
     sockaddr.sin_port = htons(port);

     bind(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     listen(sock, 1);

     printf("\n\nIn ascolto alla porta %d", port);
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

     printf("\rIn ascolto alla porta %d.....", port);
     if(acustic_segnalations) Beep(beep_frequency, beep_time_ms);
     printf("\n\nConnesso!\n\n");

     // logga porta
     if(logger_mode)
     {
          SYSTEMTIME st;
          GetLocalTime(&st);

          sprintf(temp, "\n\n >> >> >> Nuova connessione - Modalità Server - %02d/%02d/%02d %02d:%02d:02 << << << \n\n", st.wDay, st.wMonth, st.wYear-2000, st.wHour, st.wMinute, st.wSecond);
          logger(temp);
          sprintf(temp, "Porta: %d\n\n", port);
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

               if(strcmp(temp, "chat.stop\n") == 0) break; // se viene digitato "link.break" la connessione termina

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
          fprintf(fw, "\nlogfile conversazioni.log");
          fprintf(fw, "\ntextcolor 10");
          fprintf(fw, "\nnickname Anonymous");
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
     MessageBox(HWND_DESKTOP,"Autore: Blackname\n- Programma per chattare, inviare la scritta \"chat.stop\" per interrompere la chat aperta\n- Se si vuole vedere le varie conversazioni salvate bisogna aprire il file che verrà salvato dove si ha aperto il programma, si chiama \"conversazioni.log\"\n","Informazioni",MB_OK);
}


