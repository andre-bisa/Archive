// Bisacchi Andrea 0000753177

#include <stdio.h>
#include <stdlib.h>

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

 /* ---- PRIMITIVE ---- */

List emptyList(void) { 
	return NULL; 
}

Boolean empty(List lista) {
	if (lista == emptyList()) 
		return TRUE; 
	else 
		return FALSE;
}

Element head(List lista) {
	if (empty(lista)) 
		abort();
	else 
		return lista->value;
}

List tail(List lista) {
	if (empty(lista)) 
		abort();
	else 
		return lista->next;
}

List cons(Element elemento, List lista) {
	List tmp;
	tmp = (List) malloc(sizeof(Item));
	//tmp->value = elemento;
	assegna(&(tmp->value), elemento);
	tmp->next = lista;
	return tmp;
}

/* ---- NON PRIMITIVE ---- */

void showList(List lista) {
	printf("[");
	while (!empty(lista)) {
		//printf("%d", head(lista));
		printElement(head(lista));
		lista = tail(lista);
		if (!empty(lista)) printf(", ");
	} printf("]\n");
}

Boolean member(Element el, List lista) {
	while (!empty(lista)) {
		if (equal(el, head(lista))) return TRUE;
		else lista = tail(lista);
	}
	return FALSE;
}

int length(List lista) {
	int n = 0;
	while (!empty(lista)) {
		n++;
		lista = tail(lista);
	}
	return n;
}

List append(List l1, List l2) {
	if (empty(l1)) 
		return l2;
	else 
		return cons(head(l1), append(tail(l1), l2));
}

List reverse(List lista) {
	if (empty(lista)) 
		return emptyList();
	else 
		return append(reverse(tail(lista)), cons(head(lista), emptyList()));
}

List copy(List l) {
	if (empty(l)) 
		return l;
	else 
		return cons(head(l), copy(tail(l)));
}

List elimina(Element el, List l) {
	if (empty(l)) 
		return emptyList();
	else 
		if (equal(el, head(l))) 
			return tail(l);
		else 
			return cons(head(l), elimina(el, tail(l)));
}

List mergeList(List l1, List l2) {
	if (empty(l1)) return l2;
	else if (empty(l2)) return l1;
	else {
		if (compare(head(l1), head(l2)) < 0)
			return cons(head(l1), mergeList(tail(l1), l2));
		else if (equal(head(l1), head(l2)))
			return cons(head(l1), mergeList(tail(l1), tail(l2)));
		else return cons(head(l2), mergeList(l1, tail(l2)));
	}
}

void dealloca(List l) {
	List lTemp;
	while (!empty(l)) {
		lTemp = tail(l);
		free(l);
		l = lTemp;
	}
}