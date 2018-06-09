#pragma once

typedef enum {
	FALSE,
	TRUE
} Boolean;

typedef enum {
	STAMPA_LEGGI = -1,
	FINE_LEGGI = 0,
	OK_LEGGI = 1
} RitornoLeggi;

typedef enum {
	NON_ASSEGNATO = 0,
	OK_ASSEGNA = 1
} RitornoAssegna;

typedef struct {
	char nomeCliente[1024];
	int numeroPostoPrenotato;
} Booking;

RitornoLeggi leggi(Booking * dest);

RitornoAssegna assegna(Booking list[], int dim, int * lenghtList, char * name, int preferenza);

