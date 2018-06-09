// Bisacchi Andrea 0000753177

#ifndef LIST_H
#define LIST_H

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

typedef struct List_element {
	Element value;
	struct List_element *next;
} Item;

typedef Item *List;


// PRIMITIVE

/*
* Ritorna una lista vuota
*/
List emptyList(void); 

/*
* Dice se la lista  è vuota
* OUTPUT: TRUE / FALSE
*/
Boolean empty(List);

/*
* Dà il primo elemento di una lista
* N.B. (controllare che la lista sia != da emptyList)
* OUTPUT: Primo elemento
*/
Element head(List);

/*
* Dà una lista senza il primo elemento 
* N.B. (controllare che la lista sia != da emptyList)
* OUTPUT: Puntatore alla lista senza il primo elemento
*/
List tail(List);

/*
* Aggiunge un elemento in testa ad una lista
* OUTPUT: Puntatore al nuovo elemento (che sarà l'inizio della lista)
*/
List cons(Element, List);


// NON PRIMITIVE

/*
* Stampa una lista
*/
void showList(List);

/*
* Dice se c'è un elemento in una lista
* OUTPUT: TRUE / FALSE
*/
Boolean member(Element, List);

/*
* Dà la lunghezza della lista
* OUTPUT: 0=empty, altrimenti il numero della lunghezza della lista
*/
int length(List lista);

/*
* Concatena 2 liste
* N.B. l1 viene duplicata, l2 è invece condivisa
* N.B. Genera una lista CONDIVISA
*/
List append(List l1, List l2);

/*
* Crea una nuova lista "ribaltata"
* OUTPUT: radice della nuova lista
*/
List reverse(List lista);

/*
* Duplica una lista
* OUTPUT: Radice della nuova lista
*/
List copy(List l);

/*
* Elimina un'elemento da una lista
* N.B. I valori prima del valore da eliminare verranno duplicati, gli altri saranno condivisi
* OUTPUT: Radice della "nuova" lista
* N.B. Genera una lista CONDIVISA
*/
List elimina(Element el, List l);

/*
* Genera una lista ordinata da l1 e l2 in l3 ordinata senza ripetizioni
* INPUT: due liste
* OUTPUT: lista ordinata con elementi di l1 e l2
*/
List mergeList(List l1, List l2);

/*
* Dealloca una lista. Ricordarsi di annullare il puntatore!
* N.B. Ricorda di mettere la lista uguale ad emptyList()
*/
void dealloca(List l);

#endif