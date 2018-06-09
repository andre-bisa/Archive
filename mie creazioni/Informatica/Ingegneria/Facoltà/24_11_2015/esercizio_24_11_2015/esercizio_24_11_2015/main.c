#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>


#include "ordinamento.h"

#define DIM 1000

int main(void) {
	int v1[DIM];
	int v2[DIM];
	int v3[DIM];
	int vOUT[DIM];
	int i;

	for (i=0; i<DIM; i++) {
		v1[i] = rand();
		v2[i] = v1[i];
		v3[i] = v1[i];
	}

	resetCounters();
	printf("-----Naive-----\n");
	naiveSort(v1, DIM);
	for (i=0; i<DIM; i++)
		printf("%d | ", v1[i]);
	printf("\n");
	printCounters();
	system("PAUSE");

	resetCounters();
	printf("-----Bubble-----\n");
	bubbleSort(v2, DIM);
	for (i=0; i<DIM; i++)
		printf("%d | ", v2[i]);
	
	printCounters();
	system("PAUSE");

	resetCounters();
	printf("-----Merge-----\n");
	mergeSort(v3, 0, DIM, vOUT);
	for (i=0; i<DIM; i++)
		printf("%d | ", vOUT[i]);

	printf("\n");
	printCounters();
	system("PAUSE");
	return (0);
}