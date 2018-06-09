#include <stdio.h>
#include <stdlib.h>

#define DIM 5

int inserimentoArray(int vett[], int dim);
int ricercainArray(int vett[], int dim, int cosa_cercare, int* posizione);

int main() {
	int vett[DIM];
	int dim_logica_vett;
	int ricerca;
	int posizione_ricerca;
	int trovato;

	dim_logica_vett = inserimentoArray(vett, DIM);

	printf("\nInserisci valore da ricercare: ");
	scanf("%d", &ricerca);

	trovato = ricercainArray(vett, dim_logica_vett, ricerca, &posizione_ricerca);

	if (trovato) {
		printf("\n%d", posizione_ricerca);
	} else {
		printf("\n%d non presente nell'array.\n", ricerca);
	}

	
	system("pause>nul");
	return 0;
}


int inserimentoArray(int vett[], int dim) {
	int i=0;
	int read;
	printf("\nInserimento vettore...\n");
	do {
		printf("Inserisci l'elemento numero %d: ", i+1);
		scanf("%d", &read);
		if (read != 0) {
			vett[i] = read;
			i++;
		}
	} while(read!=0  &&  i<dim);
	return i;
}

int ricercainArray(int vett[], int dim, int cosa_cercare, int* posizione) {
	int i;
	int trovato=0; 
	
	for (i=0; i<dim && !trovato; i++) {
		if (vett[i] == cosa_cercare) {
			*posizione = i;
			trovato = 1;
		}
	}
	return trovato; 
}

