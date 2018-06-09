
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
#include <fstream>

using namespace std;


void client(void);
string a;

int main()
{
     system("CLS");
     client();
}


void client(void)
{


     while(1)
     {
             system("cls");
             fstream f("comandi.txt" , ios::out|ios::trunc);
             cout<<"Scrivi i comandi da inviare...\n\n";
             cin>>a;
             f<<a;
             f.close();
             system("ftp -v -i -s:a.txt");
             cout<<"Comando mandato"<<endl;
             
          Sleep(1); // un sospiro per la CPU
     }

     
}
