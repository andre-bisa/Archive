// Bisacchi Andrea 0000753177

#ifndef ELEMENT_H
#define ELEMENT_H

#include "MyStruct.h"



typedef int Element;

/*******************************************
* FUNZIONE DI COMPARAZIONE PER LA RICERCA
* Ritorna:
* TRUE se d1 = d2
* FALSE se d1 != d2
*******************************************/
Boolean equal(Element d1, Element d2);

/*******************************************
* FUNZIONE DI COMPARAZIONE PER L'ORDINAMENTO
* Ritorna:
* Positivo:  d1 > d2
* Nullo:     d1 = d2
* Negativo:  d1 < d2
*******************************************/
int compare(Element d1, Element d2);

/*
* Esegue l'assegnamento. Utile se Element è una struttura particolare
*/
Element assegna(Element * a, Element b);

/*
* Legge l'elemento
*/
Element getElement(void);

/*
* Scrive l'elemento
*/
void printElement(Element);




#endif