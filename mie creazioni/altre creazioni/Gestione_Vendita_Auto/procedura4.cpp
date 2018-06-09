# include <iostream>
# include <fstream>
# include <string>

using namespace std; 

extern void formconsegne();
extern void stampa(string NomeFile);
extern void AggiornaConsegne();

void procedura4()
 {
  int stscelta,x;
  string riga;
  char flag;
  x=0;
  system("CLS");
  cout << "1- Visualizza Consegne da effettuare ancora" << endl;
  cout << "2- Aggiorna Consegne" << endl;     
  cin >> stscelta;
  if (stscelta==1)
     {        
      formconsegne();
      //stampa("consegne.txt");
      fstream r_w("consegne.txt",ios::in | ios::out);
      if (r_w)
         { //apre if
          while(!r_w.eof())
          {    
           r_w.seekp((x*98)+(x*2)+96,ios_base::beg);
           r_w >> flag;
           if (flag=='N')
                        {
                         r_w.seekp((x*98)+(x*2),ios_base::beg); 
                         getline(r_w,riga,'\n');
                         cout << riga << endl;
                        }
          riga="";              
          x++; 
          }             
         } // chiude if
         else
         cout << "Impossibile aprire il file consegne.txt!" << endl;
     }
  if (stscelta==2)      
                  AggiornaConsegne();         
 } 
