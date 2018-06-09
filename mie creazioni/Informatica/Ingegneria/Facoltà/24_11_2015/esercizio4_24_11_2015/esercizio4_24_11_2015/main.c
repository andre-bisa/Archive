#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "merge.h"

#define MAXDIM 10


int main() {
	Stazione v[MAXDIM];
	Stazione vOUT[MAXDIM];
	int i;

	for (i=0; i<MAXDIM; i++) {
		v[i].cmNeve = rand();
		strcpy(v[i].nome, "Localita'");
	}


	mergeSort(v, 0, MAXDIM-1, vOUT);

	printf("\n\n\n\n");
	for (i=0; i<MAXDIM; i++) {
		printf("Localita': %s\nCm neve: %d\n\n", vOUT[i].nome, vOUT[i].cmNeve);
	}

	system("pause");
	return 0;
}