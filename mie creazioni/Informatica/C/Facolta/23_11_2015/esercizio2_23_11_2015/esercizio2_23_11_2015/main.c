#include <stdio.h>
#include <stdlib.h>

#define DIM 3

typedef struct {
	char nome[20];
	int codice;
	int golfatti;
	int golsubiti;
} Squadra;

void clearBuffer(void) {
	while (!getchar()) ;
}

int main() {
	Squadra squadra[DIM];
	int i;
	char risposta;
	int codiceDaCercare;

	for (i=0; i<DIM; i++) {
		printf("Inserisci il nome: ");
		scanf("%s", squadra[i].nome);
		printf("Inserisci il codice: ");
		scanf("%d", &squadra[i].codice);
		printf("Inserisci gol fatti: ");
		scanf("%d", &squadra[i].golfatti);
		printf("Inserisci gol subiti: ");
		scanf("%d", &squadra[i].golsubiti);
		system("cls");
	}

	for (i=0; i<DIM; i++) {
		if (squadra[i].golfatti > squadra[i].golsubiti) {
			printf("%s\t%d\n", squadra[i].nome, squadra[i].codice);
		}
	}

	system("pause");
	system("cls");
	clearBuffer();
	printf("Vuoi cercare una squadra? (S/N) ");
	scanf("%c", &risposta);
	if ((risposta=='s') || (risposta == 'S')) {
		printf("Inserisci il codice da cercare: ");
		scanf("%d", &codiceDaCercare);
		printf("\n-----------------\n\n");
		for (i=0; i<DIM; i++)
			if (squadra[i].codice == codiceDaCercare)
				printf("%s\n%d\n%d\n%d\n", squadra[i].nome, squadra[i].codice, squadra[i].golfatti, squadra[i].golsubiti);
	}

	system("pause");
	return 0;
}
