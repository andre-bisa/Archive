#include <cstdlib>
#include <iostream>
#include <windows.h>
#include <stdio.h>
#include <math.h>
#include <conio.h>
#include "string.h"
#include <stdlib.h>
#include <time.h>
#include <fstream>
#include <ShellAPI.h>

using namespace std;

#define TITOLO "title Snake By Andre_bisa - ver 2.0.0.7"
#define VERSIONE "2.0.0.7"
#define SALVATAGGIO "C:\\snake\\salvataggio\\partita"
#define CONFIG "C:\\snake\\config.cfg"
#define CLASSIFICA "C:\\snake\\classifica\\snake"
#define CTRL_T 20
#define CTRL_Q 17
#define F1 59
#define ESC 27
#define GIU 80
#define SU 72
#define DX 77
#define SX 75
#define ENTER 13
#define MOSSE_BONUS 50 //mosse di durata del bonus

int dif[]={1,50,100,150,200,250,300,350,400,450};
int velocita=100;
int velo=velocita;
int trucco=0;
const char bordo=4;     // fanno venire la grafica
const char mela_ch=1;   // del serpente e della 
const char snake_ch=15; // frutta e del bonus e del bordo
const char bonus_ch[]={2,3,5,6}; // codice ascii dei vari bonus
string direzione="destra"; 
int errore;
int punteggio;
int mela;
int x_mela;
int y_mela;
int x_bonus;
int y_bonus;
int bonus_cont;
int bonus;
int bonus_tempo;
int bonus_usato;
int snake=3; //numero che indica da quanti pezzi è formato lo snake
int x_pezzo[1000]; // indica la posizione x dei vari pezzi dello snake
int x_pezzo2[1000]; // serve per lo spostamento
int y_pezzo[1000]; // indica la posizione y dei vari pezzi dello snake
int y_pezzo2[1000]; // serve per lo spostamento
string giocatore;
string top_nome;
int top_score;
string top_nome_mond;
int top_score_mond;
string versione_online;
int pausa;
int livello=5;
int snake_punteggio;
int m1=1; //per la selezione nei menu
int m2=1; //""
int m3=1; //""
int m4=1; //""
int tasto; //per i menu prende il valore del tasto premuto
//int a=FACILE; //tempo di Sleep per il processore
int niente; //serve per impedire di premere un tasto prima che si veda la schermata successiva
int nuova_partita;
int caricato; //serve per vedere se sono stati caricati dei file e quindi permette l'avvio senza menu
//int opz=0;
int online=1;

//inizio dichiarazioni funzioni
void color(int color);
void gotoxy(int x, int y);
//void contorno();
void classifica(); //scrive la classifica
void opzioni(); //modifica nome giocatore e livello scelti al primo avvio
void f1(); //cosa succese a premere F1
void salva(); //funzione che salva la partita
void carica(); //carica un salvataggio
void scrivi_punt();
//fine dichiarazioni funzioni


//inizio colore
void color(int color)
{
     SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}
//fine colore

//inizio funzione per il goto
void gotoxy (int x, int y)
{

COORD coord;
coord.X = x;
coord.Y = y;

SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
}
//fine funzione per il goto

//inizio funzione per i bordi
void scrivi_punt(){
    if (snake_punteggio==0) {
    fstream f("C:\\snake\\classifica\\snake", ios::in|ios::out);
    if (f) f>>top_nome>>top_score; 
    else { top_score=0; top_nome=""; }
    f.close();
    gotoxy(0,0);
    cout<<"Record nel tuo pc: "<<top_score;
    gotoxy(25,0);
    cout<<"Punteggio: "<<punteggio;
    gotoxy(45,0);
    cout<<"Record online: "<<top_score_mond; 
    if ((bonus_cont>=5)&&(bonus==0)){
    gotoxy(65,0);
    cout<<"Mosse bonus: "<<(MOSSE_BONUS-bonus_tempo);
    }
    }
}

//fine funzione per i bordi

void f1(){
MessageBox(NULL,"Leggere attentamente le istruzioni:\n-NON RIDIMENSIONARE IL PROGRAMMA\n-Usare le frecce direzionali per la selezione nei menù e invio per scegliere\n-Premere \"F1\" per vedere la guida\n-Frecce direzionali per modificare la direzione dello snake\n-\"P\" per mettere in pausa il gioco\n-\"ESC\" Per finire la partita in corso\n\n Per problemi contattatemi a: grandeandrea@live.it","Snake - Istruzioni",MB_OK|MB_ICONINFORMATION);
}

void inserimenti(){
system("cls");
if (giocatore=="")
{
cout<<"Nome giocatore: ";
cin>>giocatore;
}
fstream file(CONFIG, ios::out|ios::trunc);
file<<giocatore<<" "<<livello;
velocita=dif[livello-1];
file.close();
}

void crea_file(){
fstream f(CONFIG, ios::in);
if (!f) { f1(); inserimenti(); }
else f>>giocatore>>livello;
f.close();

if (online==1){
fstream a("a.bat",ios::out|ios::trunc);
a<<"title Scaricamento classifica in corso... NON CHIUDERE!"<<endl<<"ftp -v -i -s:C:ftp.txt"<<endl<<"move classifica.txt C:\\snake\\classifica.txt"<<endl<<"move versione.txt C:\\snake\\versione.txt"<<endl<<"cls"<<endl<<"exit";
a.close();
system("attrib +h a.bat");
fstream b("b.bat",ios::out|ios::trunc);
b<<"title Scaricamento classifica in corso... NON CHIUDERE!"<<endl<<"del /q C:\\snake\\classifica.txt"<<endl<<"del /q C:\\snake\\versione.txt"<<endl<<"del /q ftp.txt"<<endl<<"cls"<<endl<<"exit";
b.close();
system("attrib +h b.bat");

fstream ftp("ftp.txt",ios::out|ios::trunc);
ftp<<"open bisamma.altervista.org"<<endl<<"bisamma"<<endl<<"bisamma2011"<<endl<<"cd /snake"<<endl<<"mget \"classifica.txt\""<<endl<<"mget \"versione.txt\""<<endl<<"quit";
ftp.close();

cout<<"PREGO ATTENDERE E NON CHIUDERE LA FINESTRA..."<<endl;
cout<<"CARICAMENTO CLASSIFICA ONLINE IN CORSO..."<<endl<<endl<<endl;
system("cmd /c start /min /wait a.bat");
fstream class_mond("C:\\snake\\classifica.txt",ios::in);
class_mond>>top_nome_mond>>top_score_mond;
class_mond.close();

fstream vers("C:\\snake\\versione.txt",ios::in);
vers>>versione_online;
vers.close();
system("cmd /c start /min /wait b.bat");
Sleep(500);
system("attrib -h a.bat");
system("attrib -h b.bat");
system("del /q \"a.bat\"");
system("del /q \"b.bat\"");
system("cls");
#define ver_on versione_online
string check_vers="Versione non aggiornata (vers. attuale: "VERSIONE", vers. disponibile: "+versione_online+")\nCliccare su \"Si\" per avviare il download del nuovo software.";
if (versione_online=="") {cout<<"Connessione a internet assente"; Sleep(500);}
else if (versione_online!=VERSIONE) {if(MessageBox(NULL,check_vers.c_str(),"Snake - Avviso",MB_YESNO|MB_ICONINFORMATION)==IDYES){
cout<<"SCARICAMENTO FILE IN CORSO..."<<endl<<"ATTENDERE PREGO..."<<endl;
fstream ok("ok.bat",ios::out|ios::trunc);
ok<<"title Scaricamento aggiornamento snake.zip"<<endl<<"ftp -v -i -s:C:ftp(ok).txt"<<endl<<"del ftp(ok).txt //f"<<endl<<"exit";
ok.close();
system("attrib +h ok.bat");
fstream ftp_ok("ftp(ok).txt",ios::out|ios::trunc);
ftp_ok<<"open bisamma.altervista.org"<<endl<<"bisamma"<<endl<<"bisamma2011"<<endl<<"cd /snake"<<endl<<"binary"<<endl<<"mget \"snake.zip\""<<endl<<"quit";
ftp_ok.close();
system("cmd /c start /min /wait ok.bat");
system("@del ok.bat /f");
system("@del ftp(ok).txt /f");
system("cls");
cout<<"FILE SCARICATO... PER VEDERE LA NUOVA VERSIONE APRIRE \"snake.zip\""<<endl;
Sleep(3000);
exit(5);
}}

system("if not exist C:\\snake\\config.cfg echo.>>C:\\snake\\config.cfg"); //crea file di configurazione dove sono salvati tutti i valori
system("if not exist C:\\snake md c:\\snake");
system("attrib +h C:\\snake");
system("if not exist C:\\snake\\classifica md C:\\snake\\classifica");
system("attrib +h C:\\snake\\classifica");
system("if not exist C:\\snake\\salvataggio md C:\\snake\\salvataggio");
fstream file(CLASSIFICA, ios::in|ios::out); 
file>>top_nome>>top_score;
file.close();
} online=0; }

void menu(){
while(1){
for (int i=0;i<100;i++) if (kbhit()) niente=getch();
system("cls");
system("color 0f");
   gotoxy(30,1);
   cout<<"Premi F1 per vedere la guida!";
   gotoxy(30,9);
   if (m1==1)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Nuova partita\n";
   gotoxy(30,10);
   if (m1==2)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Continua\n";
   gotoxy(30,11);
   if (m1==3)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Classifica\n";
   gotoxy(30,12);
   if (m1==4)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Opzioni\n";
   gotoxy(30,13);
   if (m1==5)
   {
   color(13);
   cout<<"-->";
   }
   else color(10);
   cout<<"Esci\n";
   
   tasto = getch();


if (tasto == ESC ) exit(1);
if (tasto == CTRL_Q ) { if (trucco==0) {trucco=1; MessageBox(NULL,"Trucco attivato","Snake - Trucco attivo",MB_OK|MB_ICONINFORMATION); } else {trucco=0; MessageBox(NULL,"Trucco disattivato", "Snake - Trucco disattivato",MB_OK|MB_ICONINFORMATION);}} //se si preme ctrl+q abilita il trucco

if (tasto == 224) {  //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch();
if (tasto == SU) { if (m1==1) m1=5; else m1--; }
if (tasto == GIU) { if (m1==5) m1=0; m1++; }
}
else if (tasto == 0) { //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch(); 
if (tasto == F1 ) f1();
}
else {
if (tasto == ENTER){
if (m1==1) break; //interrompe ed esce dal ciclo e fa iniziare la partita
if (m1==2) { carica(); break; } //carica un salvataggio
if (m1==3) classifica(); //funzione che scrive un punteggio migliore
if (m1==4) opzioni(); //modifica le opzioni
if (m1==5) exit(2); //uscita

}}}}

void classifica(){
system("cls");
cout<<"Punteggio migliore:"<<endl<<endl;
fstream f("C:\\snake\\classifica\\snake", ios::in|ios::out);
if (f){ f>>top_nome>>top_score; f.close(); cout<<top_nome<<" ha fatto "<<top_score<<endl<<endl;}
else { cout<<"Nessuna partita giocata"<<endl<<endl; top_score=0; top_nome=""; }
f.close();
cout<<"Punteggio migliore online:"<<endl<<endl;
cout<<top_nome_mond<<" ha fatto "<<top_score_mond<<endl<<endl;
system("pause");
}

void opzioni(){
while(1){
system("cls");
color(10);
cout<<"Nome giocatore: "<<giocatore<<endl<<endl;
if (m4==1)
{
color(13);
cout<<"-->";
}
else color(10);
cout<<"Cambia nome giocatore\n";
if (m4==2)
{
color(13);
cout<<"-->";
}
else color(10);
cout<<"Cambia difficolta'";
char a1,a2;
a1=176;
a2=178;
cout<<"        -";
for (int i=1;i<=10;i++) if (i==livello) cout<<a2; else cout<<a1;
cout<<"+"<<endl;
if (m4==3)
{
color(13);
cout<<"-->";
}
else color(10);
cout<<"Cancella classifiche\n";
if (m4==4)
{
color(13);
cout<<"-->";
}
else color(10);
cout<<"Indietro\n";

   tasto = getch();


if (tasto == ESC ) { inserimenti(); break; }
                        
if (tasto == 224) {  //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch();
if (tasto == SU) { if (m4==1) m4=4; else m4--; }
if (tasto == GIU) { if (m4==4) m4=0; m4++; }
if ((tasto == DX)&&(m4==2)) if (livello!=10) livello++;
if ((tasto == SX)&&(m4==2)) if (livello!=1) livello--;
}
else if (tasto == 0) { //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch(); 
if (tasto == F1 ) f1();
}
else {
if (tasto == ENTER){
if (m4==1) { giocatore=""; inserimenti(); }; //interrompe ed esce dal ciclo e fa iniziare la partita
if (m4==2) { continue; }
if (m4==3) { if (MessageBox(NULL,"La classifica sta per essere elminata\n\nContinuare?","Snake - Avviso",MB_YESNO|MB_ICONQUESTION)==IDYES){
system("del C:\\snake\\classifica /q"); 
MessageBox(NULL,"Classifica eliminata con successo","Snake - Avviso",MB_OK|MB_ICONINFORMATION);
}} //carica un salvataggio
if (m4==4) { inserimenti(); break; }
}}
}}

void salva(){
if (errore==1) exit(4);
//-----ordine variabili--------------------------------------------------------------------------------------------------------------------
//snake, direzione, livello, x_mela, y_mela, mela, x_bonus, y_bonus, punteggio, bonus_usato, bonus_tempo, bonus_cont, bonus, x_pezzo[0..1000], y_pezzo[0..1000]
//-----------------------------------------------------------------------------------------------------------------------------------------
fstream file(SALVATAGGIO, ios::out|ios::trunc);
file<<snake<<endl
<<direzione<<endl
<<x_mela<<endl
<<y_mela<<endl
<<mela<<endl
<<x_bonus<<endl
<<y_bonus<<endl
<<punteggio<<endl
<<bonus_usato<<endl
<<bonus_tempo<<endl
<<bonus_cont<<endl
<<bonus<<endl;

for (int i=0; i<snake; i++){
file<<x_pezzo[i]<<endl;
}
for (int i=0; i<snake; i++){
file<<y_pezzo[i]<<endl;
}
if (file) MessageBox(NULL,"Partita salvata","Snake - Slavataggio riuscito",MB_OK|MB_ICONINFORMATION);
else MessageBox(NULL,"Impossibile creare il file","Snake - Errore nel salvataggio",MB_OK|MB_ICONERROR);
file.close();
}

void carica(){
//-----ordine variabili--------------------------------------------------------------------------------------------------------------------
//snake, direzione, livello, x_mela, y_mela, mela, x_bonus, y_bonus, punteggio, bonus_usato, bonus_tempo, bonus_cont, bonus, x_pezzo[0..1000], y_pezzo[0..1000]
//-----------------------------------------------------------------------------------------------------------------------------------------
fstream file(SALVATAGGIO, ios::in);
file>>snake>>direzione>>x_mela>>y_mela>>mela>>x_bonus>>y_bonus>>punteggio>>bonus_usato>>bonus_tempo>>bonus_cont>>bonus;

for (int i=0; i<snake; i++){
file>>x_pezzo[i];
}
for (int i=0; i<snake; i++){
file>>y_pezzo[i];
}
file.close();
caricato=1;
if (file) MessageBox(NULL,"Caricamento avvenuto con successo","Snake - Caricamento riuscito",MB_OK|MB_ICONINFORMATION);
else { MessageBox(NULL,"Impossibile caricare il file","Snake - Errore nel caricamento",MB_OK|MB_ICONERROR); caricato=2; }
file.close();
system("del C:\\snake\\salvataggio\\partita /q");
}

int main()
{
system(TITOLO);
srand(time(NULL));//modifica il random
inizio:
if (caricato==0){
m1=1;
m2=1;
m3=1;
m4=1;
pausa=0;
snake_punteggio=0;
direzione="destra";
giocatore="";
snake=3;
punteggio=0;
errore=0;
mela=0;
x_mela=0;
y_mela=0;
x_bonus=0;
y_bonus=0;
bonus_cont=0;
bonus=0;
bonus_tempo=0;
bonus_usato=0;
for (int i=0;i<1000;i++)
{
    x_pezzo[i]=0;
    x_pezzo2[i]=0;
    y_pezzo[i]=0;
    y_pezzo2[i]=0;
}
crea_file();
inserimenti();
//RANDOMIZZA I VALORI
x_mela=rand() % 80 + 1; // randomizza la 
y_mela=rand() % 25 + 1; // mela

x_pezzo[0]=rand() % 50 + 1; // randomizza il
y_pezzo[0]=rand() % 20 + 1; // serpente

for (int i=1;i<snake;i++){
x_pezzo[i]=x_pezzo[i-1]-1;
y_pezzo[i]=y_pezzo[0];
}

x_bonus=rand() % 80 + 1; // randomizza il 
y_bonus=rand() % 25 + 1; // bonus

bonus_usato=rand() % 3; //randommizza il tipo di bonus  
//FINITO DI RANDOMIZZARE I VALORI
if (nuova_partita==0) { menu(); }
if (caricato==1) { pausa=1; goto inizio; }
if (caricato==2) { caricato=0; goto inizio; }
}
velocita=dif[10-livello];
velo=velocita;
caricato=0;
nuova_partita=0;

//da qua inizia lo snake
system("cls");
cout<<"Caricamento in corso..."<<endl;
Sleep(500);
system("cls");
system("color 3b");
cout<<"Caricamento in corso..."<<endl;
Sleep(500);

//inizio programma con serpente

while(1){ 
for (int i=0;i<100;i++) if (kbhit()) niente=getch();
//INIZIO ISTRUZIONI PER PAUSA

while(pausa==1){
for (int i=0;i<100;i++) if (kbhit()) niente=getch();
system("cls");
   system("cls");
   system("color 3b");
   scrivi_punt();
   gotoxy(34,6);
   cout<<"GIOCO IN PAUSA";
   gotoxy(22,7);
   cout<<"Premere \"P\" per continuare a giocare";
   gotoxy(30,10);
   if (m2==1)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Riprendi\n";
   gotoxy(30,11);
   if (m2==2)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Menu principale\n";
   gotoxy(30,12);
   if (m2==3)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Nuova partita\n";
   gotoxy(30,13);
   if (m2==4)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Fine partita\n";
   
   tasto = getch();


if (tasto == ESC ) { errore=1; pausa=0; }
if (tasto == CTRL_Q ) { if (trucco==1) {trucco=0; MessageBox(NULL,"Trucco disattivato", "Snake - Trucco disattivato",MB_OK|MB_ICONINFORMATION);}} //se si preme ctrl+q abilita il trucco

if ((tasto == CTRL_T )&&(trucco==1)) punteggio+=10000; //trucco
if ((tasto == 80 )||( tasto == 112)) pausa=0;
if (tasto == 224) {  //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch();
if (tasto == SU) { if (m2==1) m2=4; else m2--; }
if (tasto == GIU) { if (m2==4) m2=0; m2++; }
}
else if (tasto == 0) { //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch(); 
if (tasto == F1 ) f1();
}
else {
if (tasto == ENTER){
if (m2==1) pausa=0; //riprende il gioco
if (m2==2) { salva(); goto inizio; } //va al menu
if (m2==3) { nuova_partita=1; goto inizio; } //fa ripartire la partita
if (m2==4) { errore=1; pausa=0; } //finisce la partita

}}}
//FINE ISTRUZIONI PER PAUSA
    
    while((!kbhit()&&(pausa==0))){
             scrivi_punt(); //posizionamento bordi
             
             for (int i=1; i<snake;i++){
             if ((y_pezzo[i]==0)||(y_pezzo[i]==1)||(y_mela==0)||(y_mela==1)||((y_bonus==0)&&(bonus_cont>=5))||((y_bonus==1)&&(bonus_cont>=5))) {snake_punteggio=1; break;}
             else snake_punteggio=0;
             }
             
             if ((x_pezzo[0]==80)||(y_pezzo[0]==25)||(x_pezzo[0]==-1)||(y_pezzo[0]==-1)) { errore=1; break; }         /////////////////////////
             for (int i=1; i<snake;i++){                                                                            // se il serpente tocca//
             if ((x_pezzo[0]==x_pezzo[i])&&(y_pezzo[0]==y_pezzo[i])) { errore=1; break; }                           // un lato o tocca un  //
             }                                                                                                      // suo pezzo finisce la//
             if (errore==1) break;                                                                                  // partita             //
                                                                                                                    /////////////////////////
             
             //permette il mangiare della mela
             if ((x_pezzo[0]==x_mela)&&(y_pezzo[0]==y_mela)) { mela=1; punteggio+=5; bonus_cont++; x_pezzo[snake]=x_mela; y_pezzo[snake]=y_mela; snake++; }
             if (mela==1) { 
                          x_mela=rand() % 77 + 1;
                          y_mela=rand() % 23 + 1; 
                          mela=0;
                          }
             gotoxy(x_mela,y_mela);
             cout<<mela_ch;
             //finisce con le istruzioni per la mela
             
             //inizio istruzioni per bonus
             if ((x_pezzo[0]==x_bonus)&&(y_pezzo[0]==y_bonus)&&(bonus_cont>=5)) { bonus=1; bonus_cont=0; 
             if (bonus_usato==0) punteggio+=(rand() % 25 + 1);                    //
             if (bonus_usato==1) punteggio+=50;                                   //punteggio diverso a seconda
             if (bonus_usato==2) punteggio+=(rand() % 50 + 25);                   //dei vari bonus possibili
             if (bonus_usato==3) punteggio+=(rand() % 50 + 1);                    //
             bonus_usato=rand() % 3;
             }
             if (bonus_cont>=5){
             bonus_tempo++;
             if (bonus_tempo==MOSSE_BONUS) { bonus_cont-=5; bonus=1; bonus_usato=rand() % 3; bonus_tempo=0; }
             if (bonus==0) {
             gotoxy(x_bonus,y_bonus);
             cout<<bonus_ch[bonus_usato];
             }}
             if (bonus==1) { 
                          x_bonus=rand() % 77 + 1;
                          y_bonus=rand() % 23 + 1; 
                          bonus=0;
                          bonus_tempo=0;
                          }
             //fine istruzioni per bonus
             
             for (int i=0;i<snake;i++){  //scrive i vari pezzi dello snake
                                       gotoxy(x_pezzo[i],y_pezzo[i]);
                                       if (i==0) cout<<snake_ch;
                                       else cout<<"*";                                       
                                       
                                       }
               
             for (int i=0;i<snake;i++){  //copia tutto pezzo[xxx] in pezzo2[xxx]
                                      x_pezzo2[i]=x_pezzo[i];
                                      
                                      }
                                      
             for (int i=0;i<snake;i++){ //sposta l'ordine della variabile x_pezzo verso destra (es. x_pezzo[0] diventa x_pezzo[1])
                                      x_pezzo[i+1]=x_pezzo2[i];
                                      
                                      }
             for (int i=0;i<snake;i++){  //copia tutto pezzo[xxx] in pezzo2[xxx]
                                      y_pezzo2[i]=y_pezzo[i];
                                      
                                      }
                                      
             for (int i=0;i<snake;i++){ //sposta l'ordine della variabile x_pezzo verso destra (es. y_pezzo[0] diventa y_pezzo[1])
                                      y_pezzo[i+1]=y_pezzo2[i];
                                      
                                      }
                                      
             if (direzione=="destra") { x_pezzo[0]+=1; }
             if (direzione=="giu") { y_pezzo[0]+=1; }
             if (direzione=="sinistra") { x_pezzo[0]-=1; } 
             if (direzione=="su") { y_pezzo[0]-=1; }
             
             if ((direzione=="giu")||(direzione=="su")){
                                                        velocita==velo+(25*8.7/80);
                                                        }
             if ((direzione=="destra")||(direzione=="sinistra")){
                                                                 velocita=velo;
                                                                 }
             
             Sleep(velocita);
             system("cls");
            }
            if (errore==1) break; //permette chiusura in caso di sbattuta contro a oggetto                        
                        
                        int c = getch();
                        if (c == ESC ) break;
                        if ((c == CTRL_T )&&(trucco==1)) {
                                      punteggio+=10000;
                                      }
                        
                        if (c == 224) {  //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
                        c = getch();
                        if (pausa==0){
                        if ((c == GIU )&&(direzione!="giu")&&(direzione!="su")) { direzione="giu"; continue; }
                        if ((c == SU )&&(direzione!="su")&&(direzione!="giu")) { direzione="su"; continue; }
                        if ((c == DX )&&(direzione!="destra")&&(direzione!="sinistra")) { direzione="destra"; continue; }
                        if ((c == SX )&&(direzione!="sinistra")&&(direzione!="destra")) { direzione="sinistra"; continue; }
                        }}
                        else if (c == 0) { //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
                        c = getch(); 
                        if (c == F1 ) { 
                                      pausa=1;
                                      f1();
                                      }
                                         }
                        else {
                             if ((c == 80 )||( c == 112)) { if (pausa==0) pausa=1; else pausa=0; }
                             }
            }
            
            
    system("cls");
    system("color 3b");
    if (punteggio>=top_score) { 
                             fstream file("C:\\snake\\classifica\\snake", ios::in|ios::out|ios::trunc); file<<giocatore<<" "<<punteggio; file.close();
                             }
   
if (punteggio>top_score_mond){
if (MessageBox(NULL,"Record online superato, Complimenti!\nVuoi mandare online il tuo record?","Snake - Classifica online",MB_YESNO|MB_ICONQUESTION)==IDYES){
fstream carica_on("ftp.txt",ios::out);
carica_on<<"open bisamma.altervista.org"<<endl<<"bisamma"<<endl<<"bisamma2011"<<endl<<"cd /snake"<<endl<<"mput \"classifica.txt\""<<endl<<"quit";
carica_on.close();
fstream carica_on2("classifica.txt",ios::out);
carica_on2<<giocatore<<" "<<punteggio;
carica_on2.close();
fstream c("c.bat",ios::out);
c<<"title Invio record in corso... NON CHIUDERE!"<<endl<<"ftp -v -i -s:C:ftp.txt"<<endl<<"del /q ftp.txt"<<endl<<"del /q classifica.txt"<<endl<<"cls"<<endl<<"exit";
c.close();
system("attrib +h c.bat");
system("cls");
cout<<"Record in invio..."<<endl;
system("cmd /c start /min /wait c.bat");
cout<<"Record mandato";
top_nome_mond=giocatore;
top_score_mond=punteggio;
system("attrib -h c.bat");
system("del /q c.bat");
MessageBox(NULL,"Record online inviato con successo","Snake - Record online",MB_OK);
}}

while(1){
for (int i=0;i<100;i++) if (kbhit()) niente=getch();
system("cls");
gotoxy(0,0);
cout<<"Punteggio finale: "<<punteggio<<endl<<endl;
if (punteggio>top_score) cout<<"Record di "<<top_nome<<" = "<<top_score<<" superato. Complimenti!!"<<endl; 
system("color 3b");
   gotoxy(30,6);
   if (m3==1)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Torna al menu"<<endl;
   gotoxy(30,7);
   if (m3==2)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Nuova partita"<<endl;
   gotoxy(30,8);
   if (m3==3)
   {
   color(12|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"-->";
   }
   else color(11|BACKGROUND_GREEN|BACKGROUND_BLUE);
   cout<<"Esci"<<endl;
   
   tasto = getch();


if (tasto == ESC ) exit(4);

if (tasto == 224) {  //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch();
if (tasto == SU) { if (m3==1) m3=3; else m3--; }
if (tasto == GIU) { if (m3==3) m3=0; m3++; }
}
else if (tasto == 0) { //permette il controllo per esempio di F1 che altrimenti andrebbe con ";"
tasto = getch(); 
if (tasto == F1 ) f1();
}
else {
if (tasto == ENTER){
if (m3==1) goto inizio; //torna al menu
if (m3==2) { nuova_partita=1; goto inizio; } //riparte la partita
if (m3==3) exit(3); //uscita
}}}
    
    return (8);
}
