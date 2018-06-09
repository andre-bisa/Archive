# include <iostream>
# include <fstream>
# include <string>

# include <cstdio>
# include <ctime>
# include <iomanip>

using namespace std; 

struct record3
{
 string id,nome,cognome,d_acq,d_cons, modello, marca,color,prezzo;
};

extern void formautonuove();
extern void stampa(string NomeFile); 
extern int trovaID(string Nomefile);
extern int quantitapresente(string NomeFile, int IDriga, int trac_record, int pos);
extern void aggiornamentoquantita(string NomeFile, int IDriga, int trac_record ,int pos, int num);
extern void formautousate();
extern int GeneraID(string NomeFile);
extern string Dimensiona(float Num, int DimCampo);

int ID;
 
void procedura2()
 {
  int scelta,stscelta,sconto; 
  float prezzo,prezzoFullOp;  
  char rottama,opz,opzCromo;
  bool via = false;
  bool ok = false;
  string colore,cilindrata;
  string marca, mod, anno, desc; 
  int Nporte,cilindrata2,opzCerchi,opzInterni,optional; 
  int N_porte_Max,lettore,tetto,cromo,num;  
  num=0;
  optional=0;  
  lettore=0;
  tetto=0; 
  cromo=0;        
  cout << "Hai un'auto da rottamare? (s/n): ";
  cin >> rottama;
  if (rottama=='s' | rottama=='S')
     {
      cout << "Di che cilindrata e'?" << endl;
      cout << "Se <= 1400  Lo sconto e' di 1500 euro"<< endl;
      cout << "Se >  1400  Lo sconto e' di 3000 euro"<< endl;
      cin >> cilindrata2;
      if (cilindrata2<=1400)
                            sconto=1500;
                            else
                            sconto=3000;
     }
  cout << "Vuoi acquistare un'auto nuova o usata?" << endl;
  cout << "1- nuova" << endl;
  cout << "2- usata" << endl;
  cin >> scelta;
  if (scelta==1)
     {
      formautonuove();
      stampa("Auto/autonuove.txt");
      int idmax;
      idmax=trovaID("ID/IDautonuove.txt");
      cout << "Inserisci l'ID dell'auto che vuoi acquistare: " << endl;
      cin >> ID;
      if (ID<=idmax)
         {
          ID--;              
          fstream r_w("Auto/autonuove.txt",ios::in | ios::out);
          r_w.seekp((ID*63)+11,ios_base::beg);
          getline(r_w,mod,'\0');
          system("CLS");
          cout << "Fiat "<< mod << endl;
          cout << "Vuoi acquistare:" << endl;
          cout << "1- Il modello Base" << endl;
          cout << "2- Il modello Full-Optional" << endl;
          cout << "3- Il modello personalizzato" << endl;
          cin >> stscelta;
          if (stscelta==1 | stscelta==3)
                          num=quantitapresente("Auto/autonuove.txt",ID,61,50);                                                  
          if (stscelta==2)
                          num=quantitapresente("Auto/autonuove.txt",ID,61,55);
          if (num>=1)
                     {                 
                      cout << "Colore: ";
                      cin.sync();
                      getline (cin, colore);
                                    
                      r_w.seekp((ID*63)+25,ios_base::beg); 
                      getline(r_w,cilindrata,'\0'); 
                      switch (stscelta)
                      {
                       case 1:
                       {
                        r_w.seekp((ID*63)+30,ios_base::beg); 
                        r_w >> prezzo;      
                        ofstream write("Fattura.txt",ios::out);
                        write << "Fiat " << mod << endl << endl;
                        write << "Colore: " << colore << endl;
                        write << "Numero di Porte: 3" << endl;
                        write << "Cilindrata: " <<cilindrata << endl;
                        write << "Cerchi di serie" << endl;
                        write << "Interni in tessuto" << endl << endl;
                        write << "PREZZO attuale: " << prezzo << endl << endl;
                        if (rottama=='s' | rottama=='S')
                           {
                            prezzo=prezzo-sconto;
                            write << "Con rottamazione"<< endl;
                            write << "PREZZO: " << prezzo << endl;
                           }
                        aggiornamentoquantita("Auto/autonuove.txt",ID,63,50,num);
                        cout << "Complimenti ottima scelta, l'auto e' sua." << endl; 
                        ok = true;
                        write.close();
                        stscelta=0;
                       }
                       break;
                       case 2:
                       {
                        r_w.seekp((ID*63)+40,ios_base::beg);
                        r_w >> prezzo;
                        ofstream write("Fattura.txt",ios::out);
                        write << "Fiat " << mod << endl << endl;
                        write << "Colore: " << colore << endl;
                        r_w.seekp((ID*63)+60,ios_base::beg);
                        r_w >> Nporte;
                        write << "Numero di Porte: "<< Nporte << endl;
                        write << "Cilindrata: " <<cilindrata << endl;
                        write << "Cerchi in Lega" << endl;
                        write << "Kit Cromo" << endl;
                        write << "Interni in pelle" << endl;
                        write << "Pomello cambio in pelle" << endl;
                        write << "Audio lettore CD+MP3, impianto Hifi 40W" << endl;
                        write << "Sist. vivavoce Blu&Me" << endl;
                        write << "Fari allo Xenon" << endl;
                        write << "Specchio retrovisore interno elettrocromico (giorno/notte automatic)" << endl;
                        write << "Tetto apribile elettrico SKY DOME" << endl << endl;
                        write << "PREZZO: " << prezzo << endl << endl;
                        if (rottama=='s' | rottama=='S')
                           {
                            prezzo=prezzo-sconto;
                            write << "Con rottamazione"<< endl;
                            write << "PREZZO: " << prezzo << endl;
                           }   
                        aggiornamentoquantita("Auto/autonuove.txt",ID,63,55,num);   
                        write.close();    
                        stscelta=0;   
                        cout << "Complimenti ottima scelta, l'auto e' sua." << endl;   
                        ok = true;                       
                       }     
                       break;
                       case 3:
                       {
                        string tipocerchi,tipointerni;    
                        r_w.seekp((ID*63)+30,ios_base::beg);
                        r_w >> prezzo;  
                        float prezbase=prezzo;
                        r_w.seekp((ID*63)+40,ios_base::beg);
                        r_w >> prezzoFullOp; 
                        r_w.seekp((ID*63)+60,ios_base::beg);
                        r_w >> N_porte_Max;
                        if (N_porte_Max>=5)
                           {
                            cout << "Numero di porte:" << endl;
                            cout << "3 porte" << endl;
                            cout << "5 porte (+800 euro)" << endl; 
                            cin >> Nporte;
                           }
                           else
                           Nporte=3;
                                        
                        if (Nporte==5)
                                      optional=optional+800;
                                      
                        cout <<"Cerchi: "<< endl;
                        cout <<"1- Di serie" << endl;
                        cout <<"2- In Lega(+500 euro)" << endl;
                        cin >> opzCerchi;
                        if (opzCerchi==2)
                           {
                            tipocerchi="Cerchi in Lega";      
                            optional=optional+500;
                           }
                           else
                            tipocerchi="Cerchi di serie";
                                                                                                                           
                        cout << "Interni:" << endl;
                        cout << "1- In tessuto" << endl;
                        cout << "2- In pelle(+850 euro)" << endl;
                        cin >> opzInterni;
                        if (opzInterni==2)
                           {
                            optional=optional+850;
                            tipointerni="Interni in pelle";
                           }
                           else
                            tipointerni="Interni in tessuto";
                                                       
                        cout << "Kit Cromo? (S/N) (+470 euro)" << endl;
                        cin >> opzCromo; 
                        if (opzCromo=='s' | opzCromo=='S')
                           {
                            optional=optional+470;
                            cromo=1;
                           }                 
                                                       
                        cout << "Audio lettore CD+MP3, impianto Hifi 40W? (S/N) (+450 euro)" << endl;
                        cin >> opz;
                        if (opz=='s' | opz=='S')
                           {
                            optional=optional+450;
                            lettore=1;
                           }
                        cout << "Tetto apribile elettrico? (S/N) (+950 euro)" << endl;
                        cin >> opz;    
                        if (opz=='s' | opz=='S')
                           {
                            optional=optional+950;  
                            tetto=1;
                           }     
                        prezzo=prezzo+optional;
                        if (prezzo>=prezzoFullOp)
                           {
                            cout << "Questa configurazione non conviene" << endl;
                            cout << "Prezzo: "<< prezzo << endl;;
                            cout << "Prezzo FULL-OPTIONAL: " <<prezzoFullOp << endl;
                            via = true;
                           } 
                        if (via==false)
                           {
                            //creazione fattura;
                            ofstream write("Fattura.txt",ios::out);
                            write << "Fiat " << mod << endl << endl;
                            write << "Colore: " << colore << endl; 
                            write << "Numero di Porte: "<< Nporte << endl;
                            write << "Cilindrata: " <<cilindrata << endl;  
                            write << tipocerchi << endl;
                            write << tipointerni << endl; 
                            if (cromo==1)
                                         write << "Kit Cromo" << endl; 
                            if (lettore==1)
                                           write << "Audio lettore CD+MP3, impianto Hifi 40W" << endl;
                            if (tetto==1)
                                         write << "Tetto apribile elettrico SKY DOME" << endl << endl; 
                                                       
                            write << endl << "Prezzo base: " << prezbase << endl;
                            write << endl << "Prezzo attuale: " << prezzo << endl << endl;
                            if (rottama=='s' | rottama=='S')
                               {
                                prezzo=prezzo-sconto;
                                write << "Con rottamazione"<< endl;
                                write << "PREZZO: " << prezzo << endl;
                               }     
                            aggiornamentoquantita("Auto/autonuove.txt",ID,63,50,num);   
                            cout << "Complimenti ottima scelta, l'auto e' sua." << endl; 
                            ok = true;                                                                                                                                               
                           }   
                        stscelta=0;                                                                                                                    
                       }     
                       break;
                      }
                     }//chiude if num>=1
                     else
                      {
                       cout << "Auto non Disponibile" << endl;
                       stscelta=0;
                      }
         }//chiude if id<=idmax
         else
         cout << "ID inserito non VALIDO! "<< endl;
     } // chiude if stscelta==1
     
  if (scelta==2)  
     {
      int idmax;       
      formautousate();       
      stampa("Auto/autousate.txt");  
      cout <<"\nInserisci l'ID dell'auto da acquistare: ";
      cin >> ID;
      idmax = trovaID("ID/IDautousate.txt");
      if (ID<=idmax)
         {
          ID--;
          int flag;
          fstream r_w("Auto/autousate.txt",ios::in | ios::out);
          r_w.seekp((ID*168)+(ID*2)+6,ios_base::beg);
          r_w >> flag;
          if (flag==0)
             {                        
              fstream leggi("Auto/autousate.txt",ios::in | ios::out);
              leggi.seekp((ID*168)+(ID*2)+8,ios_base::beg);
              getline(leggi,marca,'\0');
              leggi.seekp((ID*168)+(ID*2)+23,ios_base::beg); 
              getline(leggi,mod,'\0');
              leggi.seekp((ID*168)+(ID*2)+38,ios_base::beg);
              getline(leggi,colore,'\0');   
              leggi.seekp((ID*168)+(ID*2)+48,ios_base::beg);
              getline(leggi,cilindrata,'\0'); 
              leggi.seekp((ID*168)+(ID*2)+53,ios_base::beg);
              getline(leggi,anno,'\0');
              leggi.seekp((ID*168)+(ID*2)+58,ios_base::beg);
              leggi >> prezzo;
              leggi.seekp((ID*168)+(ID*2)+68,ios_base::beg);
              getline(leggi,desc,'\0');
              //creazione fattura
              ofstream write("Fattura.txt",ios::out);
              write << marca <<"  "<< mod << endl << endl;
              write << "Colore: " << colore << endl;
              write << "Cilindrata: " << cilindrata << endl;
              write << "Descrizione: " << desc << endl;
              write << "Prezzo: " << prezzo << endl << endl;
              if (rottama=='S' | rottama=='s')
                 {
                  prezzo=prezzo-sconto;
                  write <<"Con rottamazione: " << prezzo << endl;
                 }
              write.close();
              cout << "Complimenti ottima scelta, l'auto e' sua." << endl;
              ok = true;
              leggi.seekp((ID*168)+(ID*2)+6,ios_base::beg);
              leggi << "1";
              leggi.close();
             }
             else
             cout << "Mi dispiace, ma l'auto gia e' stata acquistata" << endl;
         }
         else
         cout << "ID inserito non VALIDO!" << endl;
         }   
         
      if (ok == true)
       {
        //gestione file consegna.txt
        struct record3 A3;
        cout << "Come si chiama?: " << endl;
        cin.sync();
        getline(cin, A3.nome);
        cout << "Qual'e' il suo cognome?" << endl;
        cin.sync();
        getline(cin, A3.cognome);
        if (scelta!=2)
                        marca="Fiat";
        cout << "Data Stimata di consegna(gg/mm/aa): " << endl;  
        cin >> A3.d_cons;   
        A3.d_cons.resize(10);           
        int x = GeneraID("ID/IDconsegne.txt");
        A3.id = Dimensiona(x,5);
        A3.nome.resize(10);
        A3.cognome.resize(10);
        A3.modello=mod;
        A3.modello.resize(15);
        A3.marca=marca;
        A3.marca.resize(15);
        A3.prezzo = Dimensiona(prezzo,10);
        ofstream write("consegne.txt",ios::app);
        write << A3.id;
        write << A3.nome;
        write << A3.cognome;
        //   DATA
        time_t tempo;
        struct tm *data;
        tempo = time(NULL);
        data = localtime(&tempo);
        write << setfill('0');
        write << setw(2) << data->tm_mday << "/";
        write << setw(2) << data->tm_mon+1 << "/";
        write << setw(2) << data->tm_year%100;  
        write << "  "; // per lasciare 2 spazi vuoti
        //    DATA
        write << A3.d_cons;
        write << A3.marca;
        write << A3.modello;
        if (scelta==2)
                      {
                       ID=(ID*168)+(ID*2)+38;   
                       fstream r_w("Auto\autousate.txt",ios::in | ios::out);
                       r_w.seekp(ID,ios_base::beg);
                       getline(r_w,colore,'\n');
                       A3.color=colore;
                       r_w.close();
                      }
                      else
                      A3.color=colore;

        A3.color.resize(10);              
        write << A3.color;              
        write << A3.prezzo;
        //flag per la disdetta;
        write <<";N;" << endl;    //==N per disdirre
        write.close();
       }      
 }          
