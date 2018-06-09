// Bisacchi Andrea 0000753177

#ifndef STRINGHE_H
#define STRINGHE_H

#include <string.h>

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

// RICORDATI LO '\0' A FINE STRINGA OPPURE -1

/*
* Inverte una stringa ben formata
* INPUT: una stringa
* OUTPUT: la stessa stringa invertita
*/
void invertiStringa(char* str);

/*
* Restituisce il numero di occorrenze all'interno di una stringa
*INPUT : una stringa A (occorrenza da cercare) una stringa B (dove cercare l'occorrenza)
*OUTPUT : Un numero che indica le occorrenze della stringa A nella stringa B
*/
int occorrenze(char a[], char b[]);

/*
*Stampa una stringa
INPUT: Stringa da stampare
OUTPUT : //
*/
void stampastringa(char stringa[]);


#endif