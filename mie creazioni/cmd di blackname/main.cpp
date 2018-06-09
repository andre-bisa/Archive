#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <string>
using namespace std; 

//lista variabili
int a=0, b=0, c=0;
int r=0;
char comando[1000];

//lista funzioni

int utente_crea();
int utente_elimina();
int utente_admin();

int main() 
{ 
cout<<"Scrivi il comando da eseguire:"<<endl;
restart:
b=0;
c=0;
r=0;
cout<<"->";
gets(comando);
//comando scrivi
if ((comando[0]=='s')&&(comando[1]=='c')&&(comando[2]=='r')&&(comando[3]=='i')&&(comando[4]=='v')&&(comando[5]=='i')&&(comando[6]==' '))
{
b=1;
for (a=7;a<1000;a++)
{
if (comando[a]!= NULL) 
{
cout<<comando[a];
comando[a]=NULL;
}
}
cout<<endl;
}
//comando esegui

if ((comando[0]=='e')&&(comando[1]=='s')&&(comando[2]=='e')&&(comando[3]=='g')&&(comando[4]=='u')&&(comando[5]=='i'))
{
b=1;
string c;
c="start ";
for (a=6;a<1000;a++)
{
if (comando[a]!=NULL) c = c + comando[a];
}

if ((comando[7]=='/')&&(comando[8]=='?'))
{
r=1;
cout<<"Sintassi comando giusta:"<<endl
<<"esegui [percorsofile]       Avvia un programma"<<endl
<<"esegui [sitoweb]            Apre una pagina web"<<endl;
}

if ((comando[6]!=NULL)&&(comando[7]!=NULL))
{
if (r!=1) system(c.c_str());
}
else cout<<"Sintassi comando errata."<<endl;
}

//comando esci
if ((comando[0]=='e')&&(comando[1]=='s')&&(comando[2]=='c')&&(comando[3]=='i')) exit(8);
if ((comando[0]=='e')&&(comando[1]=='x')&&(comando[2]=='i')&&(comando[3]=='t')) exit(8);

//comando aiuto
if ((comando[0]=='a')&&(comando[1]=='i')&&(comando[2]=='u')&&(comando[3]=='t')&&(comando[4]=='o'))
{
b=1;
cout<<"Comandi:"<<endl
<<"esci       Per uscire dal programma"<<endl
<<"aiuto      Fa vedere questa guida"<<endl
<<"utente     Permette la gestione di utenti nel pc"<<endl
<<"scrivi     Permette di effettuare una scritta sullo schermo"<<endl
<<"esegui     Apre un programma/pagina web"<<endl
<<"elimina    Permette l'eliminazione di file/cartelle dal pc in modo definitivo"<<endl
<<"spegni     Spegni il pc dopo 10 secondi"<<endl
<<"riavvia    Riavvia il pc dopo 10 secondi"<<endl
<<"iberna     Iberna il pc dopo 10 secondi"<<endl;
}
//comando utente (richiama funzione)
if ((comando[0]=='u')&&(comando[1]=='t')&&(comando[2]=='e')&&(comando[3]=='n')&&(comando[4]=='t')&&(comando[5]=='e'))
{

b=1;

char nome[50];
string utente;
string dopo;
string totale;

//crea
if ((comando[7]=='/')&&(comando[8]=='c')&&(comando[9]=='r')&&(comando[10]=='e')&&(comando[11]=='a'))
{
c=1;
utente_crea();
}

//elimina
if ((comando[7]=='/')&&(comando[8]=='e')&&(comando[9]=='l')&&(comando[10]=='i')&&(comando[11]=='m')&&(comando[12]=='i')&&(comando[13]=='n')&&(comando[14]=='a'))
{
c=1;
utente_elimina();
}

if ((comando[7]=='/')&&(comando[8]=='?')) c=1;

//rendi amministratore
if ((comando[7]=='/')&&(comando[8]=='a')&&(comando[9]=='d')&&(comando[10]=='m')&&(comando[11]=='i')&&(comando[12]=='n'))
{
c=1;
utente_admin();
}

if (c!=1) cout<<"Sintassi comando errata."<<endl;

if ((c!=1)||((comando[7]=='/')&&(comando[8]=='?')))
{
cout
<<"utente /crea [nomeutente]          Permette la creazione di un utente"<<endl
<<"utente /elimina [nomeutente]       Permette l'eliminazione di un utente"<<endl
<<"utente /admin [nomeutente]         Permette di rendere amministratore un utente"<<endl
<<"utente /?                        Visualizza questa guida"<<endl;

}
}

//comando elimina
if ((comando[0]=='e')&&(comando[1]=='l')&&(comando[2]=='i')&&(comando[3]=='m')&&(comando[4]=='i')&&(comando[5]=='n')&&(comando[6]=='a'))
{
r=0;
b=1;
//elimina file
if ((comando[8]=='/')&&(comando[9]=='f')&&(comando[10]=='i')&&(comando[11]=='l')&&(comando[12]=='e'))
{
r=1;
char nome[50];
string utente;
string dopo;
string totale;
if ((comando[13]==' ')&&(comando[14]!=NULL))
{

utente="del ";
dopo=" /f";
     
totale=utente;
    int w;
    
    for (w=14;w<1000;w++)
    {
     
    if (comando[w]!=NULL) totale+=comando[w];
    
    }
    
    totale+=dopo;
    
    system(totale.c_str());
    cout<<"File eliminato con successo"<<endl;
}

else
{

cout<<"Scrivi il percorso del file da eliminare"<<endl;
gets(nome);

utente="del ";
dopo=" /f";
     
totale=utente;
totale+=nome + dopo;
system(totale.c_str());
cout<<"File eliminato con successo"<<endl;

}

}


//elimina cartella
if ((comando[8]=='/')&&(comando[9]=='c')&&(comando[10]=='a')&&(comando[11]=='r')&&(comando[12]=='t')&&(comando[13]=='e')&&(comando[14]=='l')&&(comando[15]=='l')&&(comando[16]=='a'))
{
r=1;
char nome[50];
string utente;
string dopo;
string totale;
if ((comando[17]==' ')&&(comando[18]!=NULL))
{

utente="rd ";
dopo=" /s /q";
     
totale=utente;
    int w;
    
    for (w=18;w<1000;w++)
    {
     
    if (comando[w]!=NULL) totale+=comando[w];
    
    }
    
    totale+=dopo;
    
    system(totale.c_str());
    cout<<"Cartella eliminata con successo"<<endl;
}

else
{

cout<<"Scrivi il percorso della cartella da eliminare"<<endl;
gets(nome);

utente="rd ";
dopo=" /s /q";
     
totale=utente;
totale+=nome + dopo;
system(totale.c_str());
cout<<"Cartella eliminata con successo"<<endl;
}
}


if (r!=1) cout<<"Sintassi comando errata."<<endl;

if ((r!=1)||((comando[8]=='/')&&(comando[9]=='?')))
{
cout
<<"elimina /file [percorsofile]       Elimina un file"<<endl
<<"elimina /cartella [percorsofile]   Elimina una cartella"<<endl
<<"elimina /?                         Visualizza questa guida"<<endl;
}

}


//comando cancella
if ((comando[0]=='c')&&(comando[1]=='a')&&(comando[2]=='n')&&(comando[3]=='c')&&(comando[4]=='e')&&(comando[5]=='l')&&(comando[6]=='l')&&(comando[7]=='a'))
{
b=1;
system("cls");
}

//comando spegni
if ((comando[0]=='s')&&(comando[1]=='p')&&(comando[2]=='e')&&(comando[3]=='g')&&(comando[4]=='n')&&(comando[5]=='i'))
{
b=1;
system("shutdown -s -t 10 -c \"Lo spegnimento del pc avverrà tra 10 secondi.\"");
}

//comando iberna
if ((comando[0]=='i')&&(comando[1]=='b')&&(comando[2]=='e')&&(comando[3]=='r')&&(comando[4]=='n')&&(comando[5]=='a'))
{
b=1;
system("shutdown -h -f -t 10 -c \"L' ibernazione del pc avverrà tra 10 secondi.\"");
}

//comando riavvia
if ((comando[0]=='r')&&(comando[1]=='i')&&(comando[2]=='a')&&(comando[3]=='v')&&(comando[4]=='v')&&(comando[5]=='i')&&(comando[6]=='a'))
{
b=1;
system("shutdown -r -t 10 -c \"Il riavvio del pc avverrà tra 10 secondi.\"");
}

//se non lo trova scrive comando
if (b!=1) system(comando);
goto restart;
system("pause");
     
return 0; 
} 






int utente_crea()
{
char nome[50];
string utente;
string dopo;
string totale;

if ((comando[12]==' ')&&(comando[13]!=NULL))
{
     utente="net user ";
     dopo=" /add";
     
     totale=utente;
     int w;
     
     for (w=13;w<1000;w++)
     {
     
     if (comando[w]!=NULL) totale+=comando[w];
     
     }
     
     totale+=dopo;
     
     system(totale.c_str());
     cout<<"Utente creato con successo"<<endl;
     
return (0);
}

cout<<"Scrivi il nome dell'utente da creare (senza spazi)"<<endl;
     gets(nome);
     utente="net user ";
     dopo=" /add";
     
     totale=utente;
     totale+=nome + dopo;
     
     
     system(totale.c_str());
     cout<<"Utente creato con successo"<<endl;
}

int utente_elimina()
{
char nome[50];
string utente;
string dopo;
string totale;
string file;

if ((comando[15]==' ')&&(comando[16]!=NULL))
{     
     utente="net user ";
     dopo=" /delete";
     
     totale=utente;
     int w;
     
     for (w=16;w<1000;w++)
     {
     
     if (comando[w]!=NULL) totale+=comando[w];
     
     }
     
     totale+=dopo;
     
     system(totale.c_str());
     
     cout<<"Utente eliminato con successo"<<endl;
     
return (0);
}

cout<<"Scrivi il nome dell'utente da eliminare"<<endl;
     gets(nome);
          
     utente="net user ";
     dopo=" /delete";
     
     totale=utente;
     int w;
     
     totale+=nome + dopo;
     
     system(totale.c_str());
     cout<<"Utente eliminato con successo"<<endl;
}

int utente_admin()
{

char nome[50];
string utente;
string dopo;
string totale;
string nome2;

if ((comando[13]==' ')&&(comando[14]!=NULL))
{
     utente="net localgroup Administrators ";
     dopo=" /add";
     
     totale=utente;
     int w;
     
     for (w=14;w<1000;w++)
     {
     
     if (comando[w]!=NULL) totale+=comando[w];
     if (comando[w]!=NULL) nome2+=comando[w];
     
     }
     
     totale+=dopo;
     
     system(totale.c_str());
     
     cout<<nome2<<" adesso e' amministratore"<<endl;
     
return (0);
}

cout<<"Scrivi il nome da rendere amministratore"<<endl;
     gets(nome);
          
     utente="net localgroup Administrators ";
     dopo=" /add";
     
     totale=utente;
     int w;
     
     totale+=nome + dopo;
     cout<<totale<<endl;
     system(totale.c_str());
     cout<<nome<<" adesso e' amministratore"<<endl;
}












