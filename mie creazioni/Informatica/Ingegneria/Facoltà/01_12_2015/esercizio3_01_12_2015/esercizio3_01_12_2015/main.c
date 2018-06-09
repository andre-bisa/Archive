#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
	char marca[20];
	char tipologia[20];
	float prezzo;
	int numeroVenduti;
} Item;

Item* articoli(FILE* listino,FILE* venduti, char* tipologia, int* len);

int main() {
	FILE* flistino;
	FILE* fvenduti;

	Item* vett;
	int size_vett;

	if ((flistino = fopen("listino.txt", "r")) == NULL) {
		exit(1);
	}

	if ((fvenduti = fopen("venduti.txt", "r")) == NULL) {
		exit(1);
	}

	vett = articoli(flistino, fvenduti, "pasta", &size_vett);
	

	fclose(flistino);
	fclose(fvenduti);

	system("pause");
	return 0;
}

Item* articoli(FILE* listino, FILE* venduti, char* tipologia, int* len) {
	Item* ritorno;

	Item letto;

	Item letto_v;

	int i;

	(*len) = 0;

	//conto quanti sono
	while (fscanf(listino, "%s %s %f", letto.tipologia, letto.marca, &letto.prezzo) == 3) {
		if (strcmp(letto.tipologia, tipologia) == 0) (*len)++;
	}

	//"riavvolgo"
	rewind(listino);

	ritorno = (Item*) malloc(sizeof(Item) * (*len));

	i=0;
	while (fscanf(listino, "%s %s %f", letto.tipologia, letto.marca, &letto.prezzo) == 3) {
		if (strcmp(letto.tipologia, tipologia) == 0) {
			strcpy(ritorno[i].tipologia,letto.tipologia);
			strcpy(ritorno[i].marca, letto.marca);
			ritorno[i].prezzo = letto.prezzo;
			
			//lo azzero
			ritorno[i].numeroVenduti = 0;

			rewind(venduti);
			// e conto quanti sono
			while (fscanf(venduti, "%s %s", letto_v.tipologia, letto_v.marca) == 2) {
				if ((strcmp(letto.tipologia, letto_v.tipologia) == 0) && (strcmp(letto.marca, letto_v.marca) == 0)) {
					ritorno[i].numeroVenduti++;
				}
			}
			i++;
		}
	}


	return ritorno;
}