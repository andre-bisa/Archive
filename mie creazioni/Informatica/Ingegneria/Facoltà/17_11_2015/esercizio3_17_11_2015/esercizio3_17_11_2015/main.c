#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <math.h>

#define TRUE 1
#define FALSE 0
#define RESULT_OK 1
#define RESULT_ADDRESS_TOO_LONG -1
#define RESULT_COMPRESSED_NAME -2
#define MAX 50

typedef int BOOL;
typedef int resultType;resultType componiIndirizzo(char * cognome, char * nome, char * indirizzo,
	int maxChars) {
		int requiredChars;
		int compressNome = 0, size;
		strcpy(indirizzo, ""); //inizializzazione...
		requiredChars = strlen(cognome) + 1 + strlen(nome);
		if (requiredChars > maxChars) {
			requiredChars = strlen(cognome) + 3;
			if (requiredChars > maxChars)
				return RESULT_ADDRESS_TOO_LONG;
			else compressNome = 1;
		}
		strcat(indirizzo, cognome);
		strcat(indirizzo, " ");
		if (!compressNome)
			strcat(indirizzo, nome);
		else {
			size = strlen(indirizzo);
			indirizzo[size] = nome[0];
			indirizzo[size+1] = '.';
			indirizzo[size+2] = '\0'; 
		}
				if (!compressNome)
					return RESULT_OK;
				else
					return RESULT_COMPRESSED_NAME;
		}
		void handleError(resultType result) {
			switch (result) {
			case RESULT_OK:
				printf("Nessun errore occorso!\n"); break;
			case RESULT_ADDRESS_TOO_LONG:
				printf("L'indirizzo e' troppo lungo...\n"); break;
			case RESULT_COMPRESSED_NAME:
				printf("Il nome e' stato compresso...\n"); break;
			default:
				printf("Unknown Error!\n");
			}
		}
		int main(void)
		{
			char indirizzo[MAX];
			resultType result;
			result = componiIndirizzo("Chesani", "Federico", indirizzo, MAX-1);
			if ((result == RESULT_OK) || (result == RESULT_COMPRESSED_NAME)) {
				printf("%s\n", indirizzo);
				printf("Lunghezza indirizzo: %d\n", strlen(indirizzo));
			}
			else
				handleError(result);
			system("PAUSE");
			return (0);
		}