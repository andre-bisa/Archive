// Bisacchi Andrea 0000753177

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

#include "Element.h"


Boolean equal(Element d1, Element d2) {
	return (compare(d1, d2) == 0) ? TRUE : FALSE;
}

Element assegna(Element * a, Element b) {
	(*a) = b;
	//strcpy(*a, b);
	return b;
}

int compare(Element d1, Element d2) {
	return d1 - d2;
	//return strcmp(d1, d2);
}

Element getElement() {
	Element el;

	// Intero
	scanf("%d", &el);
	
	// Carattere
	//scanf("%c", &el);

	// Float
	//scanf("%f", &el);

	// Unsigned
	//scanf("%u", &el);

	return el;
}

void printElement(Element el) {

	// Intero
	printf("%d", el);

	// Carattere
	//printf("%c", el);

	// Float
	//printf("%f", el);

	// Unsigned
	//printf("%u", el);

	// Stringa
	//printf("%s", el);

	//Indirizzi
	//printf("%a",el);		

}
