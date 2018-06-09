#include <stdio.h>
#include <stdlib.h>

#define DIM 3


int main() {
	int v1[DIM];
	int v2[DIM];
	int v3[DIM * 2];
	
	int i;

	printf("Riempimento v1:\n");
	for(i=0; i<DIM; i++) {
		printf("Inserisci l'elemento %d: ", i+1);
		scanf("%d", &v1[i]);
	}

	printf("Riempimento v2:\n");
	for(i=0; i<DIM; i++) {
		printf("Inserisci l'elemento %d: ", i+1);
		scanf("%d", &v2[i]);
	}

	//riempo v3
	for (i=0; i < (DIM*2); i++) {
		if (i % 2 == 0) { //pari quindi riempo con v1
			v3[i] = v1[i/2];
		} else { //dispari quindi riempo con v2
			v3[i] = v2[i/2];
		}
	}

	system("pause>nul");
	return 0;
}
