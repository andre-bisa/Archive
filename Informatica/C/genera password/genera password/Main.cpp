#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

FILE* f;
int l_stringa;

#define PERCORSO "dizionario.txt"
//#define CARATTERI "0123456789"
#define CARATTERI "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 /*-+\|!""£$%&/()='ì?^è+é*òàùç°§,.-;:_<>@#[]€{}"

int lunghezza_stringa(char * str) {
	/*if (str == NULL)
		return 0;
	else
		return strlen(str);*/
	return (str == NULL) ? 0 : strlen(str);
}

void func(int num, char* base) {
	int l_base = lunghezza_stringa(base);
	if (num != 1) {
		for (int i = 0; i < l_stringa; i++) {
			char* nuova_base;
			int j;
			nuova_base = (char*)malloc(sizeof(char)*l_base + 2);
			for (j = 0; j < l_base; j++) {
				nuova_base[j] = base[j];
			}
			nuova_base[j] = CARATTERI[i];
			nuova_base[j + 1] = '\0';
			func(num - 1, nuova_base);
			free(nuova_base);
		}
		return;
	}
	//if (num != 1) return;
	for (int i = 0; i < l_stringa; i++) {
		/*if (l_base <= 0)
		{
			fprintf(f, "%c\n", CARATTERI[i]);
		}
		else {
			fprintf(f, "%s%c\n", base, CARATTERI[i]);
		}*/
		(l_base <= 0) ? fprintf(f, "%c\n", CARATTERI[i]) : fprintf(f, "%s%c\n", base, CARATTERI[i]);
	}
}

/*
* /start     NUMERO
* /end       NUMERO
* /base      STRINGA
* /append    0/1
* /h         Mostra l'aiuto
* /help      Mostra l'aiuto
*/
int main(int argc, char *argv[]) {

	char * base = NULL;
	int inizio_caratteri = 1;
	int fine_caratteri = 0;
	char modo[] = "w"; // w/a   write/append

	

	if (argc <= 1) {
		puts("Quanti caratteri combinare? ");
		scanf_s("%d", &fine_caratteri);
	} else {
		int i;
		for (i = 1; i < argc; i+=2) {
			if ((strcmp(argv[i], "/h") == 0) || (strcmp(argv[i], "/help") == 0)) {
				printf("/start NUMERO\tNumero di caratteri iniziali.\n");
				printf("/end NUMERO\tNumero di caratteri finali.\n");
				printf("/base NUMERO\tBase da cui partire.\n");
				printf("/append NUMERO\tSe accodare al file gia esistente.\n");
				return 0;
			}
			if (strcmp(argv[i], "/start") == 0) {
				sscanf(argv[i+1], "%d", &inizio_caratteri);
			}
			else if (strcmp(argv[i], "/end") == 0) {
				sscanf(argv[i+1], "%d", &fine_caratteri);
			}
			else if (strcmp(argv[i], "/base") == 0) {
				base = (char*)malloc(sizeof(char) * strlen(argv[i+1]) + 1);
				strcpy(base, argv[i+1]);
			}
			else if (strcmp(argv[i], "/append") == 0) {
				if (strcmp(argv[i + 1], "1") == 0)
					strcpy(modo, "a");
			}
		}

	}

	if (strcmp(modo, "a") == 0)
		puts("Append mode ON.");

	f = fopen(PERCORSO, modo);
	//remove(PERCORSO);

	l_stringa = lunghezza_stringa(CARATTERI);

	for (int i = inizio_caratteri; (i <= fine_caratteri) || (fine_caratteri == -1); i++) {
		printf("\nSto eseguendo a %d caratteri.\n", i);
		func(i, base);
	}

	if (base != NULL) 
		free(base);
	
	fclose(f);

	printf("\n");
	//system("PAUSE");
	return 0;
}