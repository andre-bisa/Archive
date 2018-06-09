// Bisacchi Andrea 0000753177

#ifndef VARIE_H
#define VARIE_H

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

/*
* FUNZIONI DI VARIO GENERE
*/


/*
* restituisce il codice ascii di un carattere o di un numero
* INPUT: carattere
* OUTPUT: intero del carattere
*/
int ascii(char c1);

float media_Ric(float sommaparziale, int contatore);	// Esegue la media ricorsivamente
/*
* Esegue la media
* INPUT: nulla, ha una scanf la funzione
* OUTPUT: media dei numeri letti
*/
float media_letta();


/*
* Dice se il numero è primo
* INPUT: un numero
* OUTPUT: TRUE / FALSE
*/
Boolean isPrimo(int x);

int reverseRic(int num, int part);						// Inverte un numero e ne restituisce il numero invertito
/*
* Inverte un numero
* INPUT: un numero
* OUTPUT: il numero invertito
*/
int ReverseNum(int num);

/*
* Inverte i caratteri che legge
* INPUT: /
* OUTPUT: i caratteri letti al contrario
*/
int reversechars();


/*
* Riempe l'array passato
* INPUT: vettore, dim fisica
* OUTPUT: dim logica
*/
int leggitutto(int vet[], int dim);


/*
* Stampa l'array che viene passato
* INPUT: vettore, dim logica
* OUTPUT: /
*/
void stampatutto(Element vet[], int dim);

/*
* Riempe l'array solo con numeri positivi
* INPUT: vettore, dim fisica
* OUTPUT: dim logica
*/
int leggipositivi(int vet[], int dim);

/*
* Riempe l'array solo con numeri negativi
* INPUT: vettore, dim fisica
* OUTPUT: dim logica
*/
int legginegativi(int vet[], int dim);

/*
* Inverte gli elementi di un array
* INPUT: vettore, dim fisica, vettore uscita
* OUTPUT: dim logica del vettore di uscita
*/
int invertiArray(Element vet[], int dimvet, Element vout[]);

/*
* Esegue la media degli elementi di un array
* INPUT: vettore, dim fisica
* OUTPUT: media degli elementi
*/
float mediArray(int vet[], int dim);

/*
* Restituisce in vout l'interesezione degli elementi di v1 e v2
* INPUT: vettore1, dim fisica1, vettore2, dim fisica2, vettore di out, grandezza fisica vett out
* OUTPUT: dimensione logica di vout
*/
int intersezione(Element v1[], int size1, Element v2[], int size2, Element vout[], int sizefisicaout);

/*
* Restituisce in vout il vettore senza "doppioni"
* INPUT: vettore, grandezza, vettore vout, grandezza fisica di vout
* OUTPUT: dimensione logica di vout
*/
int eliminaRipetuti(Element values[], int dim_v, Element vout[], int dimFisicaVOUT);

/*
* Copia il vettore v[] in vout[]
* INPUT: vettore, grandezza, vettore vout, grandezza fisica di vout
* OUTPUT: dimensione logica di vout
*/
int copiaArray(Element v[], int size, Element vout[], int dimout);



// Per questa funzione
typedef enum COMPARE_RESULT {
	COMPARE_EQUAL,
	COMPARE_DIFFERENT_LENGTH,
	COMPARE_DIFFERENT
} COMPARE_RESULT;

/*
* Confronta 2 array. Sono uguali se hanno gli stessi elementi anche in posizioni diverse
* INPUT: vettore1, grandezza1, vettore2, grandezza2 
* OUTPUT: COMPARE_RESULT
*/
COMPARE_RESULT compareTo(Element v1[], int dim1, Element v2[], int dim2);

// Gestisce gli errori della funzione "compareTo"
void gestisciRitornoCompare(COMPARE_RESULT ritorno);



/*
* Genera dinamicamente un array e lo riempie(magicamente!)
* INPUT: Elemento di terminazione e dimensione logica 
* OUTPUT: Array generato dinamicamente e riempito (In return)
*		  dim_logica sarà la dimensione logica (passata per riferimento)
* N.B.: Ricorda la free() del vettore generato
*/
Element* generaArrayDinamico(Element terminazione, int* dim_logica);

#endif