# include <iostream>
# include <fstream>
# include <string>

using namespace std; 
   
void procedura5()   
{
 string nome,cognome,nom,cogn,marca,mod;
 int riga=0;
 char flag,disd;
 bool trovato=false;
 cout << "Come si chiama?: " << endl;
 cin.sync();
 getline(cin,nome);
 cout << "Qual'e' il suo cognome?: " << endl;   
 cin.sync();    
 getline(cin,cognome);
 fstream r_w("consegne.txt");
 if (r_w)
    {
     while(!r_w.eof())
      {
       r_w.seekp((riga*98)+(riga*2)+5,ios_base::beg);  
       getline(r_w,nom,'\0');
       r_w.seekp((riga*98)+(riga*2)+15,ios_base::beg);
       getline(r_w,cogn,'\0');
       if (nom==nome & cogn==cognome)
          {
           trovato=true;          
           r_w.seekp((riga*98)+(riga*2)+45,ios_base::beg); 
           getline(r_w,marca,'\0');
           r_w.seekp((riga*98)+(riga*2)+60,ios_base::beg);
           getline(r_w,mod,'\0');
           r_w.seekp((riga*98)+(riga*2)+96,ios_base::beg);
           r_w >> flag;
           if (flag=='N')
              {
               cout << "Bene, lei voleva acquistare una "<<marca<<"  "<< mod <<endl;
               cout << "E' sicura che vuole disdirla? (S/N)" << endl;
               cin >> disd;
               if (disd=='S' | disd=='s')
                 {
                  r_w.seekp((riga*98)+(riga*2)+96,ios_base::beg); 
                  r_w << "X";
                  cout << "L'auto e' stata disdetta!" << endl;
                 }                                
              }
              else
              {
               cout << "Non e' possibile disdirre l'auto" << endl;
               cout << "Lei ha gia' ricevuto l'auto" << endl;
              }
          }       
       riga++;   
      }
      
     if (trovato==false)
        {
         cout << "Il suo nome e cognome non sono presenti" << endl;
         cout << "nella nostra lista" << endl;
        }   
    } 
    else
    cout << "Impossibile aprire il file consegne.txt!" << endl;            
}             
