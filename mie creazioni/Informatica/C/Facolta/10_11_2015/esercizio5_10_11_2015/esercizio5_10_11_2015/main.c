#include <stdlib.h>
#include <stdio.h>

#define DIM 5

int inserimentoArray(int vett[], int dim);
int eliminaRipetizioni(int vett[], int dim, int nuovo_vett[]);
int ricercainArray(int vett[], int dim, int cosa_cercare, int* posizione);

int main() {
	int vett[DIM];
	int size_vett;

	int vett2[DIM];
	int size_vett2;

	size_vett = inserimentoArray(vett, DIM);

	size_vett2 = eliminaRipetizioni(vett, size_vett, vett2);
	
	printf("%d", size_vett2);


	system("pause");
	return 0;
}


int eliminaRipetizioni(int vett[], int dim, int nuovo_vett[]) {
	int i;
	int dim_nuovo=0;
	int inutile;

	for (i=0; i<dim; i++) {
		if (!ricercainArray(nuovo_vett, dim_nuovo, vett[i], &inutile)) {
			nuovo_vett[dim_nuovo] = vett[i];
			dim_nuovo++;
		}
	}
	return dim_nuovo;
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