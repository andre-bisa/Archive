// Bisacchi Andrea 0000753177

#ifndef SORTING_H
#define SORTING_H

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"


// DICHIARAZIONI FUNZIONI ORDINAMENTO

// NAIVESORT
void naiveSort(Element v[], int n); //ordina con il naive

// BUBBLESORT
void bubbleSort(Element v[], int n); //ordina con il bubble

// INSERTSORT
void insertSort(Element v[], int n); //ordina con l'insert

// MERGESORT
void merge(Element v[], int i1, int i2, int fine, Element vout[]);
void mergeSortR(Element v[], int first, int last, Element vout[]); // ordina con il merge
void mergeSort(Element vett[], int dim);

// QUICKSORT
void quickSortR(Element a[], int iniz, int fine); // ordina con il quick
void quickSort(Element a[], int dim); // come sopra ma parte da posizione 0, solitamente la più usata

// DICHIARAZIONI FUNZIONI INTERNE PER ORDINAMENTO
int trovaPosMax(Element v[], int n);
void insOrd(Element v[], int pos);


// MACRO PER L'ORDINAMENTO
#define SWAP_ELEMENT(x, y)  {Element t; assegna(&t, (*x)); assegna(x,(*y)); assegna(y,t);}
#define SWAP(type, x, y)  {type t; t=*(x); *(x)=*(y); *(y)=t;}












#endif