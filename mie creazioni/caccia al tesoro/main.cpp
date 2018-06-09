#include <cstdlib>
#include <iostream>
#include <windows.h>

using namespace std;

int c1,c2,c3,c4;

int main()
{
    a:
    //frigo
    system("cls");
    cout<<"Sembra un tipo freddo e ombroso,\npallido d'aspetto e dal contegno silenzioso,\nma se gli affidi qualcosa di essenziale\nlui, anche dopo mesi, te lo restituisce tale e quale"<<endl;
    cout<<endl<<"Scrivi il codice per passare al prossimo enigma"<<endl;
    cin>>c1;
    if(c1!=11) goto a;
    b:
    system("cls");
    //tv
cout<<"Ha una magia veramente grande:\n"
<<"in un minuto ti porta dal Giappone alle Ande,\n"
<<"ha tanti numeri pieni di immagini e suoni,\n"
<<"non sa i giochi con le carte, ma va forte coi cartoni,\n"
<<"conosce anche il modo per farti rilassare"<<endl;
    cin>>c2;
    if(c2!=64) goto b;
    c:
    system("cls");
    //lavatrice
    cout<<"Di programmi e' sempre piena e gira tanto che fa un po' pena,\nma quando ha finito leva le tende\ne finalmente sul balcone si stende\n"<<endl;
    cout<<endl<<endl<<"Scrivi il codice per passare al prossimo enigma"<<endl;
    cin>>c3;
    if(c3!=04) goto c;
    d:
    system("cls");
    //forno
    cout<<"Ha un carattere di fuoco,\n"
<<"per scaldarsi gli ci vuole poco:\n"
<<"se ad esempio l'orologio gli toccate\n"
<<"dopo qualche minuto ve le avrà suonate!"<<endl;
    cout<<endl<<"Scrivi il codice per passare al prossimo enigma"<<endl;
    cin>>c4;
    if(c4!=47) goto d;
    system("cls");
    //bagno
    cout<<"Ora l'avrete senz'altro capita,\nma la caccia non è ancora finita,\nperchè nella casa di questo splendore,\nforte d'aspetto, puro/a di cuore,\nc'è un posto segreto che non si può dire\ne non perchè non voglia farvi finire:\nse non lo dico, fate attenzione,\nè solo un motivo di buona educazione!"<<endl;
    cout<<endl<<"Scrivi il codice per passare al prossimo enigma"<<endl;
    system("pause>nul");
    system("cls");
    cout<<endl<<endl<<"COMPLIMENTI hai trovato, spero che ti piaccia questo regalo"<<endl;
    system("PAUSE>nul");
    exit(8);
}
