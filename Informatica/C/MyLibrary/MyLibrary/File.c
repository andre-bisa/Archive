// Bisacchi Andrea 0000753177

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

#include "File.h"


//apre un file;
FILE* openFile(char percorso[], char come[]) {
	FILE* file;
	if ((file = fopen(percorso, come)) == NULL) {
		perror("Errore nell'aprire il file!");
		exit(1);
	}
	return file;
}

int readField(char buffer[], char sep, FILE *f) {
	int i = 0;
	char ch = fgetc(f);
	while (ch != sep && ch != 10 && ch != EOF) {
		buffer[i] = ch;
		i++;
		ch = fgetc(f);
	}
	buffer[i] = '\0';
	return ch;
}

