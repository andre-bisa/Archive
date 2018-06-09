// Bisacchi Andrea 0000753177

#ifndef RICERCA_H
#define RICERCA_H

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

// DICHIARAZIONI FUNZIONI

/*
* Cerca con la bisezione
* INPUT: vettore, grandezza vettore, elemento da cercare
* OUTPUT: posizione dove si trova l'elemento
* N.B.! il vettore deve essere già ordinato
*/
int binarySearch(Element vet[], int dim, Element el);

/*
* Cerca un elemento
* INPUT: vettore, grandezza vettore, elemento da cercare
* OUTPUT: posizione dove si trova l'elemento
*/
int ricercaElemento(Element vet[], int dim, Element el);








#endif