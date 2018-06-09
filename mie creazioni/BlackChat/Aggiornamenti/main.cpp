// mettere nelle opzioni del progetto poi nella scheda "Parametri" e poi nella sezione linker la scritta: "-lwsock32"

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
int i;
int w;
char tx[1024], rx[1024]; // buffer trasmissione e ricezione
char temp[1024]; // buffer temporaneo per ricevere il testo da tastiera

int main()
{
     SOCKET sock, acceptsock;
     inizio:
     acceptsock=332;
     system("cls");
     unsigned int port; // le porte hanno un range di valori da 0 a 65535, proprio come una variabile unsigned int
     long j, k; // temporaney counter

     //SOCKET sock, acceptsock;
     WSADATA wsadata;
     WSAStartup(MAKEWORD(2,2), &wsadata);
     sock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

     u_long nonblock = 1;
     ioctlsocket(sock, FIONBIO, &nonblock); // configurazione non bloccante
     port=4037;
     
     sockaddr_in sockaddr;
     sockaddr.sin_family = PF_INET;
     sockaddr.sin_addr.s_addr = INADDR_ANY;
     sockaddr.sin_port = htons(port);

     bind(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     listen(sock, 10);

     sock=128;
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
     printf("\n\nConnesso!\n\n");

     sock = acceptsock;
     
     j=-1;
     while(1)
     {
          while(j==-1)
          {
          memset(rx, 0, 1024);
          j = recv(sock, rx, 1024, 0);
          cout<<rx;
          }
          
          if((rx[0]=='1')&&(rx[1]=='.')&&(rx[2]=='3'))
          {
          
          k = send(sock, "1", 1024, 0);
          cout<<"\nSoftware gia' aggiornato\n";
          break;
          
          }
          else
          {
          
          k = send(sock, "0", 1024, 0);
          cout<<"Software da aggiornare\n";
          break;
          
          }


     }

     closesocket(sock);
     closesocket(acceptsock);
     goto inizio;
}




