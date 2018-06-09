# include <iostream>
# include <fstream>
# include <string>
# include <windows.h>

using namespace std;


extern void procedura1();
extern void procedura2();
extern void procedura3();
extern void procedura4();
extern void procedura5();

int main()
{
  int scelta;
  cout << "1- Rifornisci (proprietario)" << endl;  
  cout << "2- Acquista auto (cliente)" << endl;
  cout << "3- Vendi auto usata (il cliente vende al concessionario)" << endl;
  cout << "4- Gestioni Consegne (proprietario)" << endl;
  cout << "5- Disdisci auto (Il cliente disdisce l'auto che voleva acquistare)" << endl;
  cin >> scelta;
  
  if (scelta==1)
                {  
                 procedura1();
                }
  if (scelta==2)
                {
                 procedura2();
                }                          

  if (scelta==3) 
                {
                 procedura3();
                }  
                
    /* GESTIONE CONSEGNE */                
  if (scelta==4)   
               {
                procedura4();      
               } 
                   
  if (scelta==5) 
                {
                 procedura5();        
                }              
                  
  bool canc=false;   
  ifstream read("Fattura.txt",ios::in);
  if(read)
          {
           canc=true;                            
           string linea;                            
           system("CLS");
           while(!read.eof())
                          {
                           getline(read,linea,'\n');
                           cout << linea << endl;
                          }  
          }  
  read.close();
  if(canc==true)      
               system("DEL Fattura.txt");  
                
  system("PAUSE");            
}
