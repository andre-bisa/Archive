// Bisacchi Andrea 0000753177

#ifndef FILE_H
#define FILE_H 

#include <stdio.h>

#include "Element.h"
#include "MyStruct.h"
#include "File.h"
#include "List.h"
#include "Ricerca.h"
#include "Sorting.h"
#include "Stringhe.h"
#include "Varie.h"

/*
* apre un file con controllo dell'errore
* OUTPUT: Puntatore del file aperto
*/
FILE* openFile(char percorso[], char come[]);

/*
* Legge dal file e mette in buffer finchè non trova il carattere separatore (sep) passato
* OUTPUT: restituisce int dell'ultimo carattere letto
*         in buffer mettere la stringa letta (ben formattata)
*/
int readField(char buffer[], char sep, FILE *f);








#endif