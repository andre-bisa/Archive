#include <stdio.h>
#include <stdlib.h>

#include "gestione.h"

#define DIM 10

int main() {
	Booking bookings[DIM];
	int bookingsDim = 0;
	int i;
	RitornoLeggi ritornoLeggi;
	Boolean stop = FALSE;

	while (bookingsDim <= DIM && !stop) {
		ritornoLeggi = leggi(&bookings[bookingsDim]);
		switch (ritornoLeggi) {
		case STAMPA_LEGGI:
			for (i = 0; i < bookingsDim; i++) {
				printf("\nNome cliente: %s\nNumero posto preferenza: %d\n---------------------------\n", bookings[i].nomeCliente, bookings[i].numeroPostoPrenotato);
			}
			break;
		case FINE_LEGGI:
			stop = TRUE;
			break;
		case OK_LEGGI:
			if (assegna(bookings, DIM, &bookingsDim, bookings[bookingsDim].nomeCliente, bookings[bookingsDim].numeroPostoPrenotato) == NON_ASSEGNATO)
				printf("\nPosto non selezionabile, si prega ri reinserire dei dati validi.\n");
			break;
		default:
			printf("Perche' sono finito qui?!");
		}
	}
	printf("\n\n");
	system("pause");
	return 0;
}
