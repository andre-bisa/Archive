#include <stdlib.h>
#include <stdio.h>

#define TYPE int

//boolean
#define BOOLEAN int
#define TRUE 1
#define FALSE 0

//result
#define RESULT int
#define DIFFERENT_LENGTH -1
#define EQUAL 0
#define DIFFERENT 1

BOOLEAN equals(TYPE el1, TYPE el2) {
	return(el1 == el2); //uguaglianza dipendente dal tipo
}

int trovaPos(int vet[], int dim, int el) {
	int trovato, i;
	trovato = -1;
	for (i = 0; i<dim && trovato<0; i++) {
		if (vet[i] == el)
			trovato = i;
	}
	return trovato;
}

RESULT compareTo1(TYPE v1[], TYPE v2[], int dim1, int dim2) {
	int i;
	RESULT result;
	if (dim1 != dim2)
		result = DIFFERENT_LENGTH;
	else {
		result = EQUAL;
		for (i = 0; i < dim1 && result == EQUAL; i++) {
			if (!equals(v1[i], v2[i]))
				result = DIFFERENT;
		}
	}
	return result;
}

RESULT compareTo2(TYPE v1[], TYPE v2[], int dim1, int dim2) {
	int i, j;
	BOOLEAN currentEquality = TRUE;
	RESULT result;
	if (dim1 != dim2)
		result = DIFFERENT_LENGTH;
	else {
		for (i = 0; i < dim1 && currentEquality; i++) {
			currentEquality = FALSE;
			for (j = 0; j < dim2 && !currentEquality; j++) {
				currentEquality = equals(v1[i], v2[j]);
			}
		}
		if (currentEquality)
			result = EQUAL;
		else
			result = DIFFERENT;
	}
	return result;
}

RESULT compareTo3(TYPE v1[], TYPE v2[], int dim1, int dim2) {
	RESULT ritorno = EQUAL;
	int i;
	int j;
	int conta_v1; // conta quante volte lo incontro in v1
	int conta_v2; // conta quante volete lo incontro in v2

	if (dim1 != dim2) {
		ritorno = DIFFERENT_LENGTH;
	} else {
		for (i = 0; i < dim1 && ritorno == EQUAL; i++) {
			conta_v2 = 0; // per ora non l'ho ancra trovato nell'altro vettore
			conta_v1 = 1; // l'elemento selezionato
			for (j = 0; j < dim2; j++) {
				if (equals(v1[i], v2[j])) {
					conta_v2++;
				}
			}
			// se ne ho trovato più di uno controllo che che ce ne siano lo stesso numero anche in v1
			if (conta_v2 > 1) {
				conta_v1 = 0;
				for (j = 0; j < dim2; j++) {
					if (equals(v1[i], v1[j])) {
						conta_v1++;
					}
				}
			}
			// se c'è un numero diverso di elementi allora sono diversi
			if (conta_v2 != conta_v1) {
				ritorno = DIFFERENT;
			}
		}
	}
	return ritorno;
}

int main() {
	int v1[] = {1, 1, 3, 5, 4};
	int v2[] = {3, 5, 1, 4, 1};

	int dim1 = 5;
	int dim2 = 5;

	switch (compareTo3(v1, v2, dim1, dim2)) {
	case EQUAL:
		printf("Vettori uguali.\n");
		break;
	case DIFFERENT:
		printf("Vettori diversi.\n");
		break;
	case DIFFERENT_LENGTH:
		printf("Vettori di grandezza diversa.\n");
		break;
	default:
		printf("Perchè sono finito qui?!?\n");
	}

	system("pause");
	return 0;
}