
#ifndef REGISTRATORE_H
#define REGISTRATORE_H

#include <stdio.h>

typedef struct {
	float importo;
	int numeroOggettiAcquistati;
} Scontrino;

int leggi(FILE * fp, Scontrino * dest);

int scrivi(FILE * fp, Scontrino src);



#endif