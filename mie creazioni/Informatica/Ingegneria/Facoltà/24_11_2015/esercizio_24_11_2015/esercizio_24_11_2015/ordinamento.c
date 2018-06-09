#include <stdio.h>

#include "ordinamento.h"

int swap_count = 0;
int comp_count = 0;

void incSwap() { swap_count++; }
void incComp() { comp_count++; }

void resetCounters()
{
	swap_count = 0;
	comp_count = 0;
}

void printCounters()
{
	printf("Numero di confronti effettuati: %d\n", comp_count);
	printf("Numero di scambi effettuati: %d\n", swap_count);
}

void naiveSort(int v[], int n) {
	int p;
	while (n>1) {
		p = trovaPosMax(v,n);
		incComp();
		if ( p < n-1 )
			scambia( &v[p], &v[n-1]);
		n--;
	}
}

int trovaPosMax(int v[], int n) {
	int i, posMax=0;
	for (i=1; i<n; i++)
		if (v[posMax]<v[i])
			posMax=i;
	return posMax;
}
void scambia(int * a, int * b) {
	int temp;
	temp = *a;
	*a = *b;
	*b = temp;
	incSwap();
}

void bubbleSort(int v[], int n){
	int i, ordinato = 0;
	while (n>1 && !ordinato){
		ordinato = 1;
		incComp();
		for (i=0; i<n-1; i++)
			if (v[i]>v[i+1]) {
				scambia(&v[i],&v[i+1]);
				ordinato = 0;
			}
			n--;
	}
}

void mergeSort(int v[], int first, int last, int vout[]) {
		int mid;
		if ( first < last ) {
			mid = (last + first) / 2;
			mergeSort(v, first, mid, vout);
			mergeSort(v, mid+1, last, vout);
			merge(v, first, mid+1, last, vout);
		}
}

void merge(int v[], int i1, int i2, int fine, int vout[]) {
		int i=i1, j=i2, k=i1;
		while ( i <= i2-1 && j <= fine ) {
			incComp();
			if (v[i] < v[j]) {
				vout[k] = v[i++]; }
			else {
				vout[k] = v[j++]; }
			k++;
		}
		while (i<=i2-1) { incComp(); vout[k] = v[i++]; k++; }
		while (j<=fine) { incComp(); vout[k] = v[j++]; k++; }
		for (i=i1; i<=fine; i++) v[i] = vout[i];
}

void quickSort(int a[], int dim)
{
	quickSortR(a[], 0, dim - 1);
}