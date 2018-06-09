#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int readLength(FILE *f, int *even, int *odd);

int main() {
	FILE* f;
	int even;
	int odd;
	int totale;

	int* vettore;
	int size_even;
	int size_odd;
	int letto;


	if ((f=fopen("valori.dat", "rb")) == NULL) {
		exit(1);
	}

	totale = readLength(f, &even, &odd);

	// creo vettore
	vettore = (int*) malloc(sizeof(int) * totale);

	//"riavvolgo" il file
	rewind(f);

	// leggo i pari
	size_even = 0;
	size_odd = even;
	while (fread(&letto, sizeof(letto), 1, f)) {
		if ((letto % 2) == 0) {
			vettore[size_even++] = letto;
		} else {
			vettore[size_odd++] = letto;
		}
	}
	
	//chiudo il file
	fclose(f);

	// libero il vettore
	free(vettore);
	
	
	system("pause");
	return 0;
}


int readLength(FILE *f, int *even, int *odd) {
	int letto;

	(*even) = (*odd) = 0;

	while (fread(&letto, sizeof(letto), 1, f)) {
		if ((letto % 2) == 0) {
			(*even)++;
		} else {
			(*odd)++;
		}
	}

	return (*even) + (*odd);
}