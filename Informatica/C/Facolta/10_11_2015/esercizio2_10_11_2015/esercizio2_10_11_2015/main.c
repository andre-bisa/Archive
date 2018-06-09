#include <stdio.h>
#include <stdlib.h>

#define DIM 8

#define pari(n) ((n % 2 == 0) ? 1 : 0)


int main() {
	int vett[DIM];
	int pari[DIM];
	int dim_pari=0;
	int dispari[DIM];
	int dim_dispari=0;

	int i;

	for(i=0; i<DIM; i++) {
		printf("Inserisci il %d numero: ", i+1);
		scanf("%d", &vett[i]);
	}

	printf("\n");

	for(i=0; i<DIM; i++) {
		if (vett[i] >= 0) {
			if (pari(vett[i])) {
				pari[dim_pari] = vett[i];
				dim_pari++;
			} else {
				dispari[dim_dispari] = vett[i];
				dim_dispari++;
			}
		}
	}

	system("pause>nul");
	return 0;
}