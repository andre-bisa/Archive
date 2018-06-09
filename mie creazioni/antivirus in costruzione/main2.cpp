#include <iostream>
#include <fstream> 
#include <string.h>
#include "stdio.h" 
#include "conio.h" 
#include <windows.h>

using namespace std;

//inizio dichiarazioni variabili
char* nome_file="ciao.txt";
int i=0;
int p=0;
int q=0;
string a[1000000];
string scrivi[1000000];
char prova[1000000];
int virus;
int w=0;

//inizio dichiarazione funzioni
int apri_file(const char* nome_file);
int controllo();

int main() {
                

    cout <<"Scrivi il nome del file da aprire --> ";
    cout<<endl<<"Ricerca in corso di virus..."<<endl;
    
    apri_file(nome_file);
    
    

system("pause>nul");
return 0;
}


int apri_file(const char* nome_file){
    
    
    fstream f(nome_file, ios::in);  
    if(!f) {
        cout<<"\nIl file "<<nome_file<<" non esiste!\n";
        return -1;
    }
    while(f.good()) //fino a quando c'è qualcosa da leggere ..
    {
        p=i+1;
        getline(f, a[i]); 
        fstream g("mio.txt", ios::out);
        g<<a[i];
        g.close();
        fstream h("mio.txt", ios::in);
        h>>scrivi[i]>>scrivi[p];
        h.close();
        cout<<scrivi[i]<<" "<<scrivi[p]<<endl;
        i++;
    controllo();
    fstream k("mio.txt", ios::out|ios::trunc);
    
}
f.close();
}


int controllo(){
    fstream h("mio.txt", ios::in);
    
    for(q=0;q<=50;q++){
    prova[q] = ' ';
    }
    
    for(q=0;q<=50;q++){
    h>>prova[q];
    prova[q] = toupper(prova[q]);
    }
    h.close();
    
    if((prova[0]=='D')&&(prova[1]=='E')&&(prova[2]=='L'))
    virus++;
    if((prova[0]=='T')&&(prova[1]=='A')&&(prova[2]=='S')&&(prova[3]=='K')&&(prova[4]=='K')&&(prova[5]=='I')&&(prova[6]=='L')&&(prova[7]=='L'))
    virus--;
    
    cout<<prova<<endl;
    cout<<"virus totali: "<<virus<<endl;
    system("pause");
    system("pause");
    }


