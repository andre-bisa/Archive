// Bisacchi Andrea 0000753177

#include "Ricerca.h"

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

int binarySearch(Element vet[], int dim, Element el) {
	int startPos;
	int med = dim / 2;
	if (compare(vet[med], el) == 0)
		return med;
	if (med == 0)
		return -1;
	if (compare(el, vet[med]) < 0)
	{
		return binarySearch(vet, med, el);
	}
	else {
		startPos = med + 1;
		return startPos + binarySearch(&vet[startPos], dim - startPos, el);
	}
}


int ricercaElemento(Element vet[], int dim, Element el) {
	int i;
	int ritorno = -1;

	for (i = 0; i<dim && ritorno==-1; i++) 
		if (equal(vet[i], el))
			ritorno = i;

	return ritorno;
}