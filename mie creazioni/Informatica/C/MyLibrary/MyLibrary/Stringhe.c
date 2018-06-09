// Bisacchi Andrea 0000753177

#include <string.h>
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

void invertiStringa(char* str) {
	int i;
	//char temp;
	for (i = 0; i < ((int)strlen(str) / 2); i++)
	{
		SWAP(char, &str[i], &str[strlen(str) - i - 1])
		//temp = str[i];
		//str[i] = str[strlen(str) - i - 1];
		//str[strlen(str) - i - 1] = temp;
	}
}

int occorrenze(char a[], char b[]) {
	int result = 0;
	int trovato = 0;
	int i = 0, j = 0, temp;
	while (b[j] != '\0') {
		if (b[j] == a[i]) {
			trovato = 1;
			temp = j;
			while (a[i] != '\0' && trovato) {
				if (a[i] == b[j]) {
					i++;
					j++;
				}
				else {
					trovato = 0;
				}
			}
			if (trovato)
				result++;
			j = temp;
			i = 0;
		}
		j++;
	}
	return result;
}

void  stampastringa(char stringa[]) {
	if (stringa[0] == '\0')
		return;
	else {
		printf("%c", stringa[0]);
		stampastringa(&(stringa[1]));
	}
}