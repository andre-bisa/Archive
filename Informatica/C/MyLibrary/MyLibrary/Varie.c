// Bisacchi Andrea 0000753177

#define _CRT_SECURE_NO_WARNINGS


#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"


int ascii(char c1)
{
	int x;
	/* Togliere commento per far stampare
	if ((c1 >= 'a' && c1 <= 'z') ||  // se il carattere e' compreso tra a/A e z/Z o 0-9 ne stampa il valore ascii
		(c1 >= 'A' && c1 <= 'Z') || (c1 >= '1' && c1 <= '0'))
		printf("%c %d\n", c1, c1);
	*/
	x = c1;
	return x;
}

float media_Ric(float sommaparziale, int contatore) {
	float num;
	scanf("%f", &num);
	if (num == 0)
		return sommaparziale / contatore;
	else return media_Ric(sommaparziale + num, contatore + 1);
}

float media_letta() { 
	return media_Ric(0, 0);
}

Boolean isPrimo(int x) {
	int i;
	int resto;
	Boolean result;
	result = FALSE;
	if ((x == 1) || (x == 2))
		result = 1;
	else {
		i = 2;
		do {
			resto = x % i;
			i++;
		} while ((resto != 0) && (i < x));
		result = (resto != 0) ? TRUE : FALSE;
	}
	return result;
}

int reverseRic(int num, int part) {
	if (num == 0)
		return part;
	else {
		return reverseRic(num / 10, part * 10 + num % 10);
	}
}

int ReverseNum(int num) {
	return reverseRic(num, 0);
}

int reversechars() {
	char c;
	int partialResult;
	c = getchar();
	if (c == '\n')
		return 0;
	else {
		partialResult = reversechars();
		printf("%c", c);
		return partialResult + 1;
	}
}

int leggitutto(int vet[], int dim) {
	int size = 0;
	int num;
	do {
		printf("Inserisci il %d elemento: ", size + 1);
		//num = getElement();
		scanf("%d", &num);
		if (num != 0 && size < dim) {
			vet[size] = num;
			size++;
		}
	} while (num != 0 && size < dim);
	return size;
}
																									
void stampatutto(Element vet[], int dim) {
	if (dim != 0)
	{
		stampatutto(vet, dim - 1);
		printElement(vet[dim - 1]);
		printf("\n");
		//printf("%d\n", vet[dim - 1]);
	}
}

int leggipositivi(int vet[], int dim) {
	int num, i;
	i = 0;
	do {
		printf("Inserisci un numero:");
		scanf("%d", &num);
		if (num > 0 && i < dim) {
			vet[i] = num;
			i++;
		}
	} while (num != 0 && i < dim);
	return i;
}

int legginegativi(int vet[], int dim) {
	int num, i;
	i = 0;
	do {
		printf("Inserisci un numero:");
		scanf("%d", &num);
		if (num < 0 && i < dim) {
			vet[i] = num;
			i++;
		}
	} while (num != 0 && i < dim);
	return i;
}

int invertiArray(Element vet[], int dimvet, Element vout[]) {
	int i, j;
	j = 0;
	for (i = dimvet - 1; i >= 0; i--) {
		assegna(&vout[j], vet[i]);
		//vout[j] = vet[i];
		j++;
	}
	return j;
}

float mediArray(int vet[], int dim) {
	float media = 0;
	int i;
	for (i = 0; i < dim; i++)
	{
		media += vet[i];
	}
	return media / i;
}

int intersezione(Element v1[], int size1, Element v2[], int size2, Element vout[], int sizefisicaout) {
	int i, j;
	Boolean trovato;
	int dimlogicaout = 0;
	for (i = 0; i < size1; i++) {
		trovato = FALSE;
		for (j = 0; j < size2 && !trovato; j++)
			if (equal(v1[i], v2[j])) // se sono uguali
				trovato = TRUE;
		if (trovato) {
			assegna(&vout[dimlogicaout], v1[i]);
			//vout[dimlogicaout] = v1[i];
			dimlogicaout++;
		}
	}
	return (dimlogicaout);
}

int eliminaRipetuti(Element values[], int dim_v, Element vout[], int dimFisicaVOUT) {
	int dimLogicaVOUT = 0;
	int i, j;
	Boolean trovato;
	for (i = 0; i < dim_v && dimLogicaVOUT < dimFisicaVOUT; i++) {
		trovato =	FALSE;
		for (j = 0; j < dimLogicaVOUT && !trovato; j++) {
			//if (values[i] == vout[j])
			if (equal(values[i], vout[j]))
				trovato = TRUE;
		}
		if (!trovato) {
			assegna(&vout[dimLogicaVOUT], values[i]);
			//vout[dimLogicaVOUT] = values[i];
			dimLogicaVOUT++;
		}
	}
	return dimLogicaVOUT;
}

int copiaArray(Element v[], int size, Element vout[], int dimout) {
	int i;
	for (i = 0; i < size; i++) {
		assegna(&vout[i], v[i]);
		//vout[i] = v[i];
	}
	return i;
}

COMPARE_RESULT compareTo(Element v1[], int dim1, Element v2[], int dim2) {
	Boolean * checked; // Array dinamico (grazie alla malloc). Serve per segnare le caselle che ho già controllato
	int i, j;
	Boolean currentEquality = TRUE;
	COMPARE_RESULT result;
	if (dim1 != dim2)
		result = COMPARE_DIFFERENT_LENGTH;
	else {
		checked = (Boolean *)malloc(dim2 * sizeof(Boolean));
		for (i = 0; i < dim1; i++) //uso la dimensione logica
			checked[i] = FALSE;
		for (i = 0; i < dim1 && currentEquality; i++) {
			currentEquality = FALSE;
			for (j = 0; j < dim2 && !currentEquality; j++) {
				if (!checked[j]) {
					currentEquality = equal(v1[i], v2[j]);
					if (currentEquality) {
						checked[j] = TRUE;
					}
				}
			}
		}
		if (currentEquality)
			result = COMPARE_EQUAL;
		else
			result = COMPARE_DIFFERENT;
	}
	// libero dopo la malloc
	free(checked);
	return result;
}

void gestisciRitornoCompare(COMPARE_RESULT ritorno) {
	switch (ritorno) {
	case COMPARE_DIFFERENT:
		printf("Diversi");
		break;
	case COMPARE_DIFFERENT_LENGTH:
		printf("Lunghezze diverse");
		break;
	case COMPARE_EQUAL:
		printf("Uguali");
		break;
	default:
		puts("ciao sono Chesani");
	}
}

Element* generaArrayDinamico(Element terminazione, int* dim_logica) {
	Element* appoggio;
	Element letto;
	Element* vettore;
	(*dim_logica) = 1;
	appoggio = NULL;
	vettore = NULL;
	do {
		free(appoggio);
		appoggio = (Element*) malloc(sizeof(Element) * (*dim_logica));
		letto = getElement();
		if (!equal(letto, terminazione)) {
			if ((*dim_logica) != 1) copiaArray(vettore, (*dim_logica) - 1, appoggio, (*dim_logica) - 1);
			assegna(&appoggio[*dim_logica - 1], letto);
			free(vettore);
			vettore = (Element*) malloc(sizeof(Element) * (*dim_logica));
			copiaArray(appoggio, (*dim_logica), vettore, (*dim_logica));
			(*dim_logica)++;
		}
	} while (!equal(letto, terminazione));
	
	free(appoggio);
	appoggio = NULL;
	(*dim_logica)--;
	return (vettore);
}