#include <stdio.h>
#include <stdlib.h>

#define MAXDIM 10

typedef struct {
	char nome_corso[20];
	char cognome[15];
	int iscritti;
} Corso;

int main() {
	Corso corso[MAXDIM];
	int dim;
	int i;
	int somma=0;
	float media;

	printf("Quanti corsi ci sono?");
	scanf("%d", &dim);
	system("cls");

	dim = (dim > MAXDIM) ? MAXDIM : dim;

	for (i=0; i < dim; i++) {
		printf("Inserisci il nome del corso: ");
		scanf("%s", corso[i].nome_corso);
		printf("Inserisci il cognome del docente: ");
		scanf("%s", corso[i].cognome);
		printf("Inserisci il numero degli studenti: ");
		scanf("%d", &corso[i].iscritti);
		somma += corso[i].iscritti;
	}

	media = somma / (float)dim;

	for (i=0; i<MAXDIM; i++) {
		if (corso[i].iscritti >= media)
			printf("%s\n%s\n", corso[i].nome_corso, corso[i].cognome);
	}


	system("pause");
	return 0;
}