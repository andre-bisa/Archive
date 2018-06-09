#include <windows.h>
#include <tchar.h>
#include <stdio.h>
#include <time.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <string.h>
#include <sstream>
#include <iostream>
#include <windows.h>
#include <stdio.h>
#include <time.h>
#include <iostream>
#include <fstream>
#include <string.h>
#include <sstream>

using namespace std;

int gg_agg,mese_agg,anno_agg,ora_agg,min_agg,sec_agg;

int da_capo;

string comando;
string percorso;


int main() {
HWND hWnd = FindWindow("ConsoleWindowClass" , NULL);
ShowWindow(hWnd, SW_HIDE);

while(1){
da_capo=0;
fstream f("C:\\Salvataggio.txt", ios::in);
f>>gg_agg>>mese_agg>>anno_agg>>ora_agg>>min_agg>>sec_agg;
//cout<<gg_agg<<" "<<mese_agg<<" "<<anno_agg<<" "<<ora_agg<<" "<<min_agg<<" "<<sec_agg<<endl;

gg_agg+=7;
if(gg_agg>30){ gg_agg-=30; mese_agg+=1;}
f.close();
while(da_capo<2){
         da_capo++;
         //Sleep(2000);
         time_t t = time(NULL);
         tm *time;
         time = localtime(&t);
         int ora = time->tm_hour;
         int min = time->tm_min;
         int sec = time->tm_sec;
         int giorno = time->tm_mday;
         int mese = time->tm_mon;
         int anno = time->tm_year;
         anno=anno+1900;
         mese=mese+1;
         cout<<giorno<<" "<<mese<<" "<<anno<<endl;
         cout<<ora<<" "<<min<<" "<<sec<<endl;
         system("cls"); 

         if(((gg_agg<=giorno)&&(mese_agg<=mese)&&(ora_agg<=ora)&&(min_agg<=min)&&(sec_agg<=sec))||(mese_agg<mese)||(anno_agg<anno))
         {
          fstream f2("\\\\PC-ANDREA\\File_mamma\\ok.txt", ios::in);
          if(f2)
          { 
          f2.close();
          MessageBox(NULL,"Sto' per inviare i files premere OK per inizare il caricamento.\nDurante il caricamento sarebbe meglio non modificare il desktop.","Inizializzazione invio files",MB_OK|MB_ICONINFORMATION);
          gg_agg=giorno+7;
          mese_agg=mese;
          anno_agg=anno;
          ora_agg=ora;
          min_agg=min;
          sec_agg=sec;
          if(gg_agg>30){ gg_agg-=30; mese_agg+=1;}
          
          //////////////////////////////////
          /*system("del \\\\PC-ANDREA\\File_mamma /S /Q");
          system("echo ok>>\\\\PC-ANDREA\\File_mamma\\ok.txt");
          *//////////////////////////////////////////
          
          comando="xcopy C:\\Users\\Daniela\\Desktop \\\\PC-ANDREA\\File_mamma\\";//<<giorno<<" "<<mese<<" "<<anno<<" /E /C /Y /I /H";
          
          stringstream s,ss,sss,ssss,sssss,ssssss;
          s << giorno;    //s.str()= al valore di girono in stringa
          comando+=s.str();
          comando+=".";
          ss << mese;
          comando+=ss.str();
          comando+=".";
          sss << anno;
          comando+=sss.str();
          comando+=" /E /C /Y /I /H";
          cout<<comando;
          system(comando.c_str());
          
          percorso="\\\\PC-ANDREA\\File_mamma\\";
          ssss << giorno;
          percorso+=ssss.str();
          percorso+=".";
          sssss << mese;
          percorso+=sssss.str();
          percorso+=".";
          ssssss << anno;
          percorso+=ssssss.str();
          percorso+="\\data.txt";
          fstream z(percorso.c_str(), ios::out);
          z<<(giorno+(mese*30)+(anno*365));
          z.close();
          
          //system("xcopy C:\\Users\\Daniela\\Desktop \\\\PC-ANDREA\\File_mamma\\ /E /C /Y /I /H");
          
          fstream f3("C:\\Salvataggio.txt", ios::out|ios::trunc);
          f3<<giorno<<" "<<mese<<" "<<anno<<" "<<ora<<" "<<min<<" "<<sec;
          f3.close();
          MessageBox(NULL,"Files inviati.","Inviati",MB_OK|MB_ICONINFORMATION);
          }
          Sleep(1800000);
          }


}}}
