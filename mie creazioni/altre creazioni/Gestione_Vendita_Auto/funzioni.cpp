# include <iostream>
# include <fstream>
# include <string>
# include <sstream> 

using namespace std;

int GeneraID(string NomeFile)
{
  int ID;   
  ifstream trovaID(NomeFile.c_str(), ios::in);//ID.txt file contentente il numero                                     // dell'ultimo ID inserito
  if (trovaID)
              {
               trovaID >> ID;
               ID=ID+1;
               trovaID.close();
              } 
              else
              ID=1;  
              
// Aggiorna L'ID che viene scritto sul file ID.txt
  ofstream aggID(NomeFile.c_str(), ios::out); 
  aggID << ID<<;    
  aggID.close();              
  return ID;           
}
//----------------------------------------------------------------------------//
string Dimensiona(float Num, int DimCampo)
{
    stringstream s;     
    string Id;                  
    s << Num;       
    Id = s.str();    
    Id.resize(DimCampo); 
    return Id;         
}
//----------------------------------------------------------------------------//
int trovaID(string Nomefile)
{
 int idfile;   
 ifstream trovaID(Nomefile.c_str(), ios::in);
 if (trovaID)
             {
              trovaID >> idfile;
              trovaID.close();
             } 
             
 return idfile;
}
//----------------------------------------------------------------------------//
int quantitapresente(string NomeFile, int IDriga, int trac_record ,int pos)
{
    int quantita;
    fstream leggi(NomeFile.c_str(),ios::in | ios::out);
    leggi.seekp(((trac_record+2)*IDriga)+pos,ios_base::beg);
    leggi >> quantita;
    return quantita;
}
//----------------------------------------------------------------------------//
void aggiornamentoquantita(string NomeFile, int IDriga, int trac_record ,int pos, int num)
{
      int aggnum;
      string aggstr;
      aggnum=num-1;
      aggstr=Dimensiona(aggnum,5);
      fstream scrivi(NomeFile.c_str(),ios::in | ios::out);
      scrivi.seekp((IDriga*trac_record)+pos,ios_base::beg);  
      scrivi << aggstr;        
      scrivi.close();
}
//----------------------------------------------------------------------------//
void stampa(string NomeFile)
{
     string riga;
     ifstream read(NomeFile.c_str(),ios::in);
     if(read)
             {
               while(!read.eof())
                                 {
                                  getline(read,riga,'\n');
                                  cout << riga << endl;
                                 }
              }
              else
              cout << "Impossibile aprire il file: " << NomeFile.c_str()<< endl;
}
//----------------------------------------------------------------------------//
void AggiornaConsegne()
{
  int g,m,a,gg,mm,aa;	
  int riga=0;
  char flag;
  //string restostringa;
       
  time_t tempo;
  struct tm *data;
  tempo = time(NULL);
  data = localtime(&tempo);

  g = data->tm_mday;
  m = data->tm_mon+1;
  a = data->tm_year%100;
  

  fstream r_w("consegne.txt",ios::in | ios::out);
  if(r_w)
         {
          while(!r_w.eof())
                {                           
                 r_w.seekp((riga*98)+(riga*2)+35,ios_base::beg);
                 r_w >> gg;
                 r_w.seekp((riga*98)+(riga*2)+38,ios_base::beg);
                 r_w >> mm;
                 r_w.seekp((riga*98)+(riga*2)+41,ios_base::beg);
                 r_w >> aa; 
                 r_w.seekp((riga*98)+(riga*2)+96,ios_base::beg);
                 r_w >> flag;
                 if (flag=='N')
                 {
                  if (a>aa)
                         {
                          r_w.seekp((riga*98)+(riga*2)+96,ios_base::beg); 
                          r_w << "S";
                         }
                          else
                          {
                          if (a==aa)
                                    {
                                     if (m>mm)
                                              {
                                               r_w.seekp((riga*98)+(riga*2)+96,ios_base::beg);
                                               r_w << "S";                           
                                              }
                                              else
                                              if (m==mm)
                                                       {
                                                        if (g>=gg)
                                                                 {
                                                                  r_w.seekp((riga*98)+(riga*2)+96,ios_base::beg);
                                                                  r_w << "S";
                                                                 }
                                                       }
                                    } 
                          }
                 }
             /*    r_w.seekp((riga*98)+(riga*2)+97,ios_base::beg);         
                 getline(r_w,restostringa,'\n');          */                               
                 riga++;
                }   
          cout << "Consegne Aggiornate!" << endl;      
         } 
         else
         cout << "Impossibile trovare il file consegne.txt" << endl;
}
