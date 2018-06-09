#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
	char giorno[3];
	char mese[3];
	char anno[5];
} Data;

typedef struct {
	char cognome[20];
	char nome[20];
	Data dataNascita;
	char sesso;
} Persona;

int readField(char* ritorno, char separatore, FILE* f);
void lettura(char* nomeFile, Persona* persone, int* indice_persone);

#define DIM 20

int main() {
	Persona persone[DIM];
	int indice_persone = 0;
	
	
	lettura("PEOPLE.TXT", persone, &indice_persone);
	






	system("pause");
	return 0;
}

void lettura(char* nomeFile, Persona* persone, int * indice_persone) {
	FILE* f;
	Persona letto;

	(*indice_persone) = 0;

	if ((f=fopen(nomeFile, "r")) == NULL) {
		exit(1);
	}

	while (((*indice_persone) < DIM) && (readField(letto.cognome, ';', f) > 0) && (readField(letto.nome, ';', f) > 0) && (readField(letto.dataNascita.giorno, '/', f) > 0) && (readField(letto.dataNascita.mese, '/', f) > 0) && (readField(letto.dataNascita.anno, ' ', f) > 0) && (letto.sesso = fgetc(f)))
	{
		fgetc(f); // mangio lo \n finale
		persone[(*indice_persone)] = letto;
		(*indice_persone)++;
	}

	fclose(f);
}

int readField(char* strLetta, char separatore, FILE* f) {
	int i = 0;
	char c = fgetc(f);
	while (c != EOF && c != '\n' && c != separatore) {
		strLetta[i] = c;
		i++;
		c = fgetc(f);
	}
	if (i > 0) {
		strLetta[i] = '\0';
		i++;
	}
	return i;
}