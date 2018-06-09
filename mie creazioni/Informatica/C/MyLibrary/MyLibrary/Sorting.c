// Bisacchi Andrea 0000753177

#include <stdlib.h>

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"


/**************************
*                         
*	FUNZIONI PER ORDINARE
*                          
/**************************/
int trovaPosMax(Element v[], int n) {
	int i;
	int posMax = 0;
	for (i = 1; i < n; i++)
		if (compare(v[posMax], v[i]) < 0) posMax = i;
		//if (v[posMax] < v[i]) posMax = i;
	return posMax;
}


/**************************
*
*	FUNZIONI DI ORDINAMENTO
*
/**************************/

// NAIVE
void naiveSort(Element v[], int n) {
	int p;
	while (n>1) {
		p = trovaPosMax(v, n);
		if (p<n - 1) SWAP_ELEMENT(&v[p], &v[n - 1]);
		n--;
	}
}

// BUBBLE
void bubbleSort(Element v[], int n) {
	int i;
	Boolean ordinato = 0;
	while (n>1 && !ordinato) {
		ordinato = 1;
		for (i = 0; i<n - 1; i++)
			if (compare(v[i], v[i+1]) > 0) {
				SWAP_ELEMENT(&v[i], &v[i + 1]);
				ordinato = 0;
			}
		n--;
	}
}

// INSERT
//funzione d'appoggio
void insOrd(Element v[], int pos) {
	int i = pos - 1;
	Element x;
	assegna(&x, v[pos]);
	//x = v[pos];
	//while (i >= 0 && x<v[i]) {
	while (i >= 0 && (compare(x, v[i]) < 0)) {
		assegna(&v[i + 1], v[i]);
		//v[i + 1] = v[i]; /* crea lo spazio */
		i--;
	}
	assegna(&v[i+1], x);
	//v[i + 1] = x; /* inserisce l’elemento */
}

//ordinamrnto vero e proprio
void insertSort(Element v[], int n) {
	int k;
	for (k = 1; k<n; k++)
		insOrd(v, k);
}

// MERGE
//funzione d'appoggio
void merge(Element v[], int i1, int i2, int fine, Element vout[]) {
	int i = i1, j = i2, k = i1;
	while (i <= i2 - 1 && j <= fine) {
		if (compare(v[i], v[j]) < 0) {
			assegna(&vout[k], v[i]); i++;
			//vout[k] = v[i++];
		} else {
			assegna(&vout[k], v[j]); j++;
			//vout[k] = v[j++];
		}
		k++;
	}
	//while (i <= i2 - 1) { vout[k] = v[i++]; k++; }
	//while (j <= fine) { vout[k] = v[j++]; k++; }
	//for (i = i1; i <= fine; i++) v[i] = vout[i];
	while (i <= i2 - 1) { assegna(&vout[k], v[i]); k++; i++; }
	while (j <= fine) { assegna(&vout[k], v[j]); k++; j++; }
	for (i = i1; i <= fine; i++) assegna(&v[i], vout[i]);
}

//ordinamento vero e proprio
void mergeSortR(Element v[], int first, int last, Element vout[]) {
	int mid;
	if (first < last) {
		mid = (last + first) / 2;
		mergeSortR(v, first, mid, vout);
		mergeSortR(v, mid + 1, last, vout);
		merge(v, first, mid + 1, last, vout);
	}
}

void mergeSort(Element vett[], int dim) {
	Element* tmp;
	tmp = malloc(sizeof(Element) * dim);
	mergeSortR(vett, 0, dim - 1, tmp);
	// copio tmp dentro a vett, che sarà ora ordinato
	copiaArray(tmp, dim, vett, dim);
	// libero tmp
	free(tmp);
}

// QUICK
//funzione d'appoggio
void quickSort(Element a[], int dim)
{
	quickSortR(a, 0, dim - 1);
}

//ordinamento vero e proprio
void quickSortR(Element a[], int iniz, int fine)
{
	int i;
	int j;
	int iPivot;
	Element pivot;
	if (iniz < fine)
	{
		i = iniz;
		j = fine;
		iPivot = fine;
		//pivot = a[iPivot];
		assegna(&pivot, a[iPivot]);
		do /* trova la posizione del pivot */
		{
			//while (i < j && a[i] <= pivot) i++;
			//while (j > i && a[j] >= pivot) j--;
			while (i < j && (compare(a[i], pivot) <= 0)) i++;
			while (j > i && (compare(a[j], pivot) >= 0)) j--;
			if (i < j) SWAP_ELEMENT(&a[i], &a[j]);
		} while (i < j);
			/* determinati i due sottoinsiemi */
			/* posiziona il pivot */
			//if (i != iPivot && a[i] != a[iPivot])
			if (i != iPivot && !equal(a[i], a[iPivot]))
			{
				SWAP_ELEMENT(&a[i], &a[iPivot]);
				iPivot = i;
			}
		/* ricorsione sulle sottoparti, se necessario */
		if (iniz < iPivot - 1)
			quickSortR(a, iniz, iPivot - 1);
		if (iPivot + 1 < fine)
			quickSortR(a, iPivot + 1, fine);
	} /* (iniz < fine) */
} /* quickSortR */


