# include <iostream>
# include <fstream>
# include <string>

using namespace std; 

struct record2
{
 string id,flag,marca,modello,colore,cilindrata,anno,descrizione,prezzo;
};

extern string Dimensiona(float Num, int DimCampo);
extern int GeneraID(string NomeFile);
 
void procedura3()                
 {
  struct record2 A2; 
  char accet;
  int cilind,anno_imm,prez1,prez2,x;               
  cout << "Marca auto: ";
  cin.sync();
  getline(cin,A2.marca);
  A2.marca.resize(15);
  cout << "Modello auto: ";
  cin.sync();
  getline(cin,A2.modello); 
  A2.modello.resize(15);
  cout << "Colore: ";  
  cin.sync();
  getline(cin,A2.colore);
  A2.colore.resize(10);
  cout << "Cilindrata: ";
  cin >> cilind;
  A2.cilindrata = Dimensiona(cilind,5);
  cout << "Anno di immatricolazione: ";
  cin >> anno_imm;
  if (anno_imm>2000)
     {   
      cout << "Descrizione (stato, accessori) MAX 100 caratteri" << endl;     
      cin.sync();
      getline(cin, A2.descrizione);
      A2.descrizione.resize(100);          
      A2.anno = Dimensiona(anno_imm,5);
      cout << "A quale prezzo vorrebbe venderla?: ";
      cin >> prez1;
      if (prez1>=3000)
                      prez2=prez1-1700;
                      else
                      prez2=prez1-460;
      cout << "Noi possiamo offrirle: " << prez2 << " euro" << endl;
      cout << "Accetta? (S/N)" << endl;
      cin >> accet;
      if (accet=='s' | accet=='S')
                     {
                      cout << "Bene, ecco a voi i "<<prez2<<" euro"<< endl;
                      ofstream write("Auto/autousate.txt",ios::app);
                      x = GeneraID("ID/IDautousate.txt");
                      A2.id = Dimensiona(x,5);
                      write << A2.id <<";0;";
                      write << A2.marca;
                      write << A2.modello;
                      write << A2.colore;
                      write << A2.cilindrata;
                      write << A2.anno;
                      int prezzomio=prez1+900;
                      A2.prezzo = Dimensiona(prezzomio,10);
                      write << A2.prezzo;
                      write << A2.descrizione << endl;               
                      write.close();
                     }
                     else
                     cout << "Arrivederla!" << endl;
                    }
                    else
                    {
                    cout << "Ci dispiace," << endl;
                    cout << "Ma accettiamo solo auto con immatricolazione" << endl;
                    cout << "superiore all'anno 2000." << endl;
     }
 }  
