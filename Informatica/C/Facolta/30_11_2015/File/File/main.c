#include <stdio.h>
#include <stdlib.h>
#include <string.h>


#include "registratore.h"

int main() {
	Scontrino scontrino;
	FILE* f;

	if ((f=fopen("reg.dat", "wb")) == NULL) {
		exit(1);
	}
	while ((scanf("%f %d", &scontrino.importo, &scontrino.numeroOggettiAcquistati) > 0) && (scontrino.importo != 0) && (scontrino.numeroOggettiAcquistati != 0)) {
		scrivi(f, scontrino);
	}
	fclose(f);

	if ((f=fopen("reg.dat", "rb")) == NULL) {
		exit(1);
	}
	while (leggi(f, &scontrino) > 0)
		printf("Importo: %f, Numero ogetti: %d", scontrino.importo, scontrino.numeroOggettiAcquistati);

	fclose(f);

	system("pause");
	return 0;
}