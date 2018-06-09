/*

Questo programma permette di: nascondere file (quali .zip .rar .exe ecc.) e/o file di testo e di decriptarli

Autore: Andrea
Mail/msn: grandeandrea@live.it


Questo per ora sarebbe il mio programma più utile che io abbiamo mai ctreato almeno così credo!
Spero vi piaccia!!

*/
#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;

//inizio dichiarazione variabili
int a;
string immagine;
string nascondere;
string finale;

//inizio dichiarazioni funzioni
int nascondi();
int rivela();
int informazioni();
//fine dichiarazioni inizio main principale

int main(){
 
 system("title Nascondere file in immagini");
 
 inizio:
 system("cls");
 cout<<"Scegli tra:"<<endl;
 cout<<"1 - Nascondere file in file"<<endl;
 cout<<"2 - Rivela file nascosto"<<endl;
 cout<<"3 - Informazioni sul programma"<<endl;
 cout<<"4 - Esci"<<endl;
 
 a = getch();
 
 if (a == '1')
 {
       nascondi();
       goto inizio;
 }
 if (a == '2')
 {
       rivela();
       goto inizio;
 }
 if (a == '3')
 {
       informazioni();
       goto inizio;
 }
 if (a == '4')
 exit(1);
 else
 goto inizio;
}

//funzione che permette il nascondimento di un file in un file
int nascondi()
{
          cout<<"Scrivi il nome dell'immagine dove devo mettere il file che selezionerai più avanti."<<endl;
          cout<<"L'immagine deve essere nella stessa cartella di questo programma."<<endl;
          cout<<"L'unica estensione accettata è la .bmp quindi non scrivete l'estensione solo il nome del file."<<endl;
          
          cin>>immagine;
          
          cout<<endl<<endl<<"Scrivi adesso il file da nascondere compreso di estensione e il file si deve trovare nella stessa cartella del programma."<<endl;
          
          cin>>nascondere;
          
          finale="copy /b ";
          finale+=immagine;
          finale+=".bmp + ";
          finale+=nascondere;
          finale+=" immagine_nascosta.bmp";
          
          ofstream bat("nascondi_file.bat",ios::trunc);
          bat<<"@echo off\n";
          bat<<finale;
          bat<<"\n";
          bat<<"exit";
          bat.close();
          
          system("nascondi_file.bat");
          system("@del nascondi_file.bat");
          
          system("pause");
          
          
          
}

//funzione che indica le informazioni principali
int informazioni()
{
    
MessageBox (NULL, "Questo file permette il nascondimento di un file/testo in un'immagine e poi permette anche il passo indietro \nAutore: Andrea\nMail: grandeandrea@live.it", "Informazioni", MB_OK);

}

//funzione che permette il rivelamento del file nascosto
int rivela()
{
    string nome;
    string estensione;
    cout<<"Scrivi il nome del file dove ci hai nascosto un file\n";
    
    cin>>nome;
    
    cout<<endl<<"Adesso scrivi l'estensione del file nascosto dentro l'immagine senza il punto (attenzione non quella dell'immagine!)"<<endl;
    
    cin>>estensione;
    
    finale="";
    finale="rename ";
    finale+=nome;
    finale+=" ";
    finale+=nome;
    finale+=".";
    finale+=estensione;
    
    ofstream bat("nascondi_file.bat",ios::trunc);
          bat<<"@echo off\n";
          bat<<finale;
          bat<<"\n";
          bat<<"exit";
          bat.close();
          
    system("nascondi_file.bat");
    system("@del nascondi_file.bat");
    
    cout<<"\nAdesso il file e' stato rinominato quindi dovrai aprirlo solo con WINRAR perchè sia possibile vedere il file che hai nascosto nell'immagine!!";
    cout<<endl;
    
    system("pause");
    
}







