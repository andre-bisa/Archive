#include "registratore.h"

#include <stdio.h>

int leggi(FILE * fp, Scontrino * dest) {
	return fread(dest, 1, sizeof(Scontrino), fp);
}

int scrivi(FILE * fp, Scontrino src) {
	return fread(&src, 1, sizeof(Scontrino), fp);
}