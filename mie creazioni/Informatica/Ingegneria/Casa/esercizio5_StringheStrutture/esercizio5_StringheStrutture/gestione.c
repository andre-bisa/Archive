#include <stdio.h>
#include <string.h>
#include "gestione.h"


RitornoLeggi leggi(Booking * dest) {
	printf("\nInserisci il nome del cliente: ");
	scanf("%s", dest->nomeCliente);
	// controllo l'inserimento corretto del nome cliente
	if ((*dest).nomeCliente == "fine") {
		(*dest).nomeCliente[0] = '\0'; // svuoto la stringa in quanto l'inserimento non è valido
		return FINE_LEGGI;
	}
	else if ((*dest).nomeCliente == "stampa") {
		(*dest).nomeCliente[0] = '\0'; // svuoto la stringa in quanto l'inserimento non è valido
		return STAMPA_LEGGI;
	}
	// il nome cliente va bene quindi posso procedere
	printf("Inserisci il numero posto: ");
	scanf("%d", &((*dest).numeroPostoPrenotato));
	return OK_LEGGI;
}

RitornoAssegna assegna(Booking list[], int dim, int * lenghtList, char * name, int preferenza) {
	int i;
	Boolean trovato = FALSE;

	// controllo che ci sia posto nel vettore
	if (*lenghtList >= dim) return NON_ASSEGNATO;

	// cerco se il numero del posto è già prenotato
	for (i = 0; i < *lenghtList && !trovato; i++) 
		if (list[i].numeroPostoPrenotato == preferenza)
			trovato = TRUE;
	
	// restituisco che non l'ho assegnato
	if (trovato)
		return NON_ASSEGNATO;

	// altrimenti assegno il posto
	strcpy(list[*lenghtList].nomeCliente, name);
	list[*lenghtList].numeroPostoPrenotato = preferenza;
	// la lista adesso ha un nuovo elemento
	(*lenghtList)++;
	
	return OK_ASSEGNA;
}