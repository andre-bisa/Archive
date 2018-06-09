# include <iostream>
# include <windows.h>

using namespace std;

bool gotoxy(const WORD x, const WORD y)  
{  
	COORD posizione;  
	posizione.X = x;  
	posizione.Y = y;  
	return SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), posizione);  
}
//----------------------------------------------------------------------------//
void formautonuove()
{
 system("CLS");     
 cout <<"ID";
 gotoxy(5,0);
 cout <<"Marca";
 gotoxy(11,0);
 cout <<"Modello";
 gotoxy(25,0);
 cout <<"Cil.";
 gotoxy(30,0);
 cout <<"Pr.Base";
 gotoxy(40,0);
 cout <<"Pz.Full";
 gotoxy(50,0);
 cout <<"Q.bs";
 gotoxy(55,0);
 cout << "Q.fl";
 gotoxy(60,0);
 cout << "N.porte MAX" << endl;
}
//----------------------------------------------------------------------------//
void formautousate()
{
 system("CLS");
 cout <<"ID   ; ;";
 gotoxy(8,0);
 cout <<"Marca";
 gotoxy(23,0); 
 cout <<"Modello";
 gotoxy(38,0);
 cout << "Colore";
 gotoxy(48,0);
 cout << "Cil.";
 gotoxy(53,0);
 cout << "Immt";
 gotoxy(58,0);
 cout <<"Prezzo";
 gotoxy(68,0);
 cout << "Descrizione" << endl;  
}
//----------------------------------------------------------------------------//
void formconsegne()
{
 system("CLS");
 cout <<"ID";
 gotoxy(5,0);
 cout <<"Nome";
 gotoxy(15,0);
 cout <<"Cognome";
 gotoxy(25,0);
 cout << "D.di acq.";
 gotoxy(35,0);
 cout << "D.di cons.";
 gotoxy(45,0);
 cout << "Marca";
 gotoxy(60,0);
 cout << "Modello";
 gotoxy(75,0);
 cout << "Colore";
 gotoxy(5,1);
 cout << "Prz";
 gotoxy(15,1);
 cout << "Flag" << endl;
}
//----------------------------------------------------------------------------//
