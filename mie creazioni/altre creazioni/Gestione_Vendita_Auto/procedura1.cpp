# include <iostream>
# include <fstream>
# include <string>

using namespace std;

struct record1
{    
 string id,marca,modello,cilindrata,pbase,pFulloptional, quantbase, quantfulloptional,Nporte_max;      
};

extern int GeneraID(string NomeFile);
extern string Dimensiona(float Num, int DimCampo);
extern void formautonuove();
extern void stampa(string NomeFile);
extern int trovaID(string Nomefile);

 void procedura1()
 {  
  int stscelta;    
  cout << "1- Inserisci nuovo tipo d'auto" << endl;
  cout << "2- Inserisci tipo d'auto gia presente" << endl;
  cin >> stscelta;
  switch (stscelta)
  {
    case 1:
     {
     int x,Nbase,Nfull,Nportemax;  
     float base,fulloptional,cilind;   
     struct record1 A1;
     x = GeneraID("ID/IDautonuove.txt"); 
     A1.id = Dimensiona(x,5);
     A1.marca = "Fiat";
     A1.marca.resize(6);
     cout << "NOME MODELLO: ";
     cin.sync();
     getline (cin, A1.modello);
     A1.modello.resize(14);
     cout << "CILINDRATA: ";
     cin >> cilind;
     A1.cilindrata = Dimensiona(cilind,5);
     cout << "PREZZO BASE: ";
     cin >> base;
     A1.pbase = Dimensiona(base,10);
     cout << "PREZZO FULL-OPTIONAL: ";
     cin >> fulloptional;
     A1.pFulloptional = Dimensiona(fulloptional,10);
     cout << "NUMERO PEZZI BASE: ";
     cin >> Nbase;
     A1.quantbase = Dimensiona(Nbase,5);
     cout << "NUMERO PEZZI FULL-OPTIONAL: ";
     cin >> Nfull;
     A1.quantfulloptional = Dimensiona(Nfull,5);
     cout << "NUMERO PORTE MAX: ";
     cin >> Nportemax;
     A1.Nporte_max = Dimensiona(Nportemax,1);
     ofstream write("Auto/autonuove.txt",ios::app);
     write << A1.id;
     write << A1.marca;
     write << A1.modello;
     write << A1.cilindrata;                                 
     write << A1.pbase;
     write << A1.pFulloptional;
     write << A1.quantbase;
     write << A1.quantfulloptional;
     write << A1.Nporte_max << endl;
     write.close();
    break; 
     }
     
    case 2:
     {
      formautonuove();              
      stampa("Auto/autonuove.txt");
      int ID,idfile;
      cout << "Inserisci l'ID dell'auto: " << endl;
      cin >> ID;
      idfile = trovaID("ID/IDautonuove.txt");

      if (ID<=idfile)
         {
          string mod, nuovo;
          int base,optional,letto;   
          system("CLS"); 
          ID--;         
          cout << "Bene, hai scelto:" << endl;
          fstream r_w("autonuove.txt",ios::in | ios::out);
          cout << "Fiat     ";
          r_w.seekp((ID*63)+11,ios_base::beg); 
          getline(r_w,mod,'\0');
          cout << mod << endl;
          cout << "Quanti pezzi del modello base hai acquistato?: ";
          cin >> base;
          cout << "Quanti pezzi del modello Full-optional hai acquistato?: ";
          cin >> optional;  
          if (base!=0)
             {
              r_w.seekp((ID*63)+50,ios_base::beg);
              r_w >> letto;
              letto=letto+base;
              nuovo = Dimensiona(letto,10);
              r_w.seekp((ID*63)+50,ios_base::beg);
              r_w << letto;
             }  
             
          if (optional!=0)
             {
              r_w.seekp((ID*63)+55,ios_base::beg);
              r_w >> letto;
              letto=letto+optional;
              nuovo = Dimensiona(letto,10);
              r_w.seekp((ID*63)+55,ios_base::beg);
              r_w << letto;
             }                                                   
          r_w.close();
         } 
         else
         cout << "ID inserito non VALIDO!" << endl;    
    break;       
     }
     
    default:
     cout << "Valore inserito non Corretto!" << endl; 
  } // chiude switch

 }
