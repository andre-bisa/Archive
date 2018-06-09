#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <fstream> 

#define MAX_CARATTERI 1024
#define MAX_ID 1024

using namespace std;

// dichiarazione variabili
int c=1;
int a;

//dichiarazione funzioni
void color(int color);
void cancella();

class person {
                    private:
                            int cont;
                            int id[MAX_ID];
                            string nome[MAX_ID];
                            string cognome[MAX_ID];
                            string tel[MAX_ID];
                            string cell[MAX_ID];
                            string mail[MAX_ID];
                            
                    public:
                            void leggi();
                            void stampa();
                            void aggiungi();
                            void canc_nome();
             };

int main()
{
    system("title Rubrica by Blackname");
    person person;
    //person.definisci();    funzione che scrive
    while(1)
    {
    system("cls");
    color(12);
    cout<<"Benvenuto nella rubrica di Blackanme"<<endl;
    cout<<"Scegli un'opzione"<<endl<<endl;
    
   if (c==1)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Leggi rubrica\n";
   if (c==2)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Aggiungi a rubrica\n";
   if (c==3)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Cancella nome\n";
   if(c==4)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Cancella rubrica\n";
   if (c==5)
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
                     if (a==13) { person.leggi(); system("pause"); }
                     if (a==72) c=5;
                     if (a==80) c=2;
                     break;
                     
            case (2):
                     if (a==13) person.aggiungi();
                     if (a==72) c=1;
                     if (a==80) c=3;
                     break;
            
            case (3):
                     if (a==13) person.canc_nome();
                     if (a==72) c=2;
                     if (a==80) c=4;
                     break;
            
            case (4):
                     if (a==13) cancella();
                     if (a==72) c=2;
                     if (a==80) c=5;
                     break;
            
            case (5):
                     if (a==13) exit(1);
                     if (a==72) c=4;
                     if (a==80) c=1;
                     break;
}
    
    }
    exit(2);
}


inline void person::leggi()
{
    system("cls");
    color(11);
    cont=0;
    int i=0;
    int ab;
    char a[MAX_CARATTERI];
    fstream rubrica("rubrica.txt", ios::in|ios::out);
    
    if (!rubrica.good()) MessageBox(NULL,"Il file rubrica.txt non esiste...","File inesistente",MB_OK|MB_ICONINFORMATION);
    
    while(rubrica.good()) //fino a quando c'è qualcosa da leggere ..
    {
        memset(a,0,MAX_CARATTERI);
        if (i==0) rubrica>>ab;
        else rubrica>>a;
        
        if (i==0) id[cont] = ab;
        if (i==1) nome[cont] = a;
        if (i==2) cognome[cont] = a;
        if (i==3) tel[cont] = a;
        if (i==4) cell[cont] = a;
        if (i==5) 
        {
                  mail[cont] = a;
                  stampa();
                  cout<<"-----------------------------------------------------"<<endl;
                  i=-1;
                  cont++;
        }
        i++;
    }
    rubrica.close();
}

inline void person::stampa()
{
       cout<<"Id: " <<id[cont]<<endl;
       cout<<"Nome: "<<nome[cont]<<endl;
       cout<<"Cognome: "<<cognome[cont]<<endl;
       cout<<"Tel: "<<tel[cont]<<endl;
       cout<<"Cell: "<<cell[cont]<<endl;
       cout<<"Mail: "<<mail[cont]<<endl;
}

inline void person::canc_nome()
{
       while(1) {
       leggi();
       fstream rubrica_cn("rubrica2.txt", ios::out|ios::trunc);
       if (!rubrica_cn.good()) break;
       int c_id;
       cout<<"ID dell'utente da eliminare:";
       cin>>c_id;
       cont=0;
       int p;
       for (p=0;p<MAX_ID;p++)
       {
           if (id[cont]==0) break;
           if (id[cont]==c_id) continue;
           rubrica_cn<<id[cont]<<" "<<nome[cont]<<" "<<cognome[cont]<<" "<<tel[cont]<<" "<<cell[cont]<<" "<<mail[cont]<<endl;
           cont++;
       }
       rubrica_cn.close();
       cont=0;
       system("del rubrica.txt");
       system("ren rubrica2.txt rubrica.txt");
       break;
       }
}

inline void person::aggiungi()
{
    system("cls");
    string nome_nuovo,cognome_nuovo,tel_nuovo,cell_nuovo,mail_nuovo;
    color(11);
    cont=0;
    int i=0;
    int max=0;
    char a[MAX_CARATTERI];
    int ab;
    int xid;
    fstream rubrica("rubrica.txt", ios::in|ios::out);
    
    while(rubrica.good()) //fino a quando c'è qualcosa da leggere ..
    {
        memset(a,0,MAX_CARATTERI);
        if(i==0) rubrica>>ab;
        else rubrica>>a;
        if (i==0) id[cont] = ab;
        if (i==1) nome[cont] = a;
        if (i==2) cognome[cont] = a;
        if (i==3) tel[cont] = a;
        if (i==4) cell[cont] = a;
        if (i==5) 
        {
                  mail[cont] = a;
                  i=-1;
                  cont++;
        }
        
        i++;
    }
    rubrica.close();
    for (cont=0;cont<MAX_ID;cont++)
    {
        if(id[cont]!=cont) { xid=cont; break; }
    }
    cont=0;    
    
    fstream aggiungi("rubrica.txt",ios::in|ios::out|ios::ate);
    cout<<"Scrivi il nome: ";
    cin>>nome_nuovo;
    cout<<"Scrivi il cognome: ";
    cin>>cognome_nuovo;
    cout<<"Scrivi il tel: ";
    cin>>tel_nuovo;
    cout<<"Scrivi il cell: ";
    cin>>cell_nuovo;
    cout<<"Scrivi la mail: ";
    cin>>mail_nuovo;
    //aggiungi nuovi dati
    aggiungi<<endl<<xid<<" "<<nome_nuovo<<" "<<cognome_nuovo<<" "<<tel_nuovo<<" "<<cell_nuovo<<" "<<mail_nuovo;
    
    
    aggiungi.close();
    cont=0;
    
    
}

void color(int color)
{
     SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}

void cancella()
{
     system("cls");
     int messaggio = MessageBox(NULL,"Eliminare la rubrica?","Rubrica",MB_YESNO|MB_ICONINFORMATION);
     
     if (messaggio==IDYES) 
     { 
     MessageBox(NULL,"Rubrica eliminata...","Rubrica",MB_OK|MB_ICONINFORMATION);
     fstream rub("rubrica.txt", ios::out|ios::trunc);
     rub.close();
     }
     else
     cout<<"Rubrica non cancellata..."<<endl;
     Sleep(1000);
}
