#include <stdio.h>
#include <stdlib.h>

#define DIM 3


int main() {
	int localita[DIM];
	int cmNeve[DIM];
	int dim_logica=0;
	int i;
	int stop=0;

	float media;
	int somma=0;

	for (dim_logica=0; dim_logica<DIM && !stop; dim_logica++) {
		printf("Inserisci localita: ");
		scanf("%d", &localita[dim_logica]);
		stop = (localita[dim_logica]==0);
		if (!stop) {
			printf("Inserisci cm neve: ");
			scanf("%d", &cmNeve[dim_logica]);
			stop = (cmNeve[dim_logica]==0);
			somma += cmNeve[dim_logica];
		}
	}

	media = somma / dim_logica;

	for (i=0; i < dim_logica; i++) {
		if (cmNeve[i] < media)
			printf("Localita: %d\tNeve: %d\n", localita[i], cmNeve[i]);
	}


	
	system("pause>nul");
	return 0;
}