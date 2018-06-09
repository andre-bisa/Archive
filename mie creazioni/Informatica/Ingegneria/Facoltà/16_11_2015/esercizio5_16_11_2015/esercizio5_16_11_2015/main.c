#include <stdio.h>
#include <stdlib.h>

// RESULT
#define RESULT int
#define DIFFERENT_LENGTH -1
#define EQUAL 0
#define DIFFERENT 1

#define TYPE int

// BOOLEAN
#define BOOLEAN int
#define TRUE 1
#define FALSE 0

int trovaPos(int vet[], int dim, int el);

RESULT compareTo1(TYPE v1[], TYPE v2[], int dim1, int dim2) {
	int i;
	RESULT result;
	if(dim1 != dim2)
		result = DIFFERENT_LENGTH;
	else {
		result = EQUAL;
		for(i = 0; i < dim1 && result == EQUAL; i++) {
			if( !equals(v1, dim1, v2, dim2) )
				result = DIFFERENT;
		}
	}
	return result;
}


BOOLEAN equals(TYPE el1[], int dim1, TYPE el2[], int dim2) {
	//return (el1 == el2); //uguaglianza dipendente dal tipo
	BOOLEAN ritorno = TRUE;
	int i;
	for (i=0; i<dim1; i++) {
		if (trovaPos(el2, dim2, el1[i] < 0)) {
			ritorno = FALSE;
		}
	}
	return ritorno;
}

int main() {
	int v1[] = {1, 2, 3, 4, 5, 6, 7, 8, 9};
	int v2[] = {9, 8, 7, 6, 5, 4, 3, 2, 1};

	int dim1 = 9;
	int dim2 = 9;

	switch (compareTo1(v1, v2, dim1, dim2)) {
	case DIFFERENT_LENGTH:
		printf("Lunghezza diversa");
		break;

	case EQUAL:
		printf("uguali");
		break;

	case DIFFERENT:
		printf("Diverso");
		break;

	default:
		printf("Non dovevo finire qui...");
	}


	system("pause");
	return 0;
}


int trovaPos(int vet[], int dim, int el) {
	int trovato, i;
	trovato = -1;
	for (i=0; i<dim && trovato<0; i++) {
		if (vet[i] == el)
			trovato = i;
	}
	return trovato;
}