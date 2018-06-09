#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>
#include <math.h>

int leggi_int();

void main() {
	int prova = leggi_int();
	printf("%d", prova);
	system("pause");
}

int leggi_int() {
#define MAXBUFFER 10
	int ritorno = 0;
	char buffer[MAXBUFFER];
	for (int i = 0; i < MAXBUFFER; i++) buffer[i] = 0;
	int i = 0;
	char tmp;
	short int segno = 0;
	while (tmp = getchar(), tmp != 10) {
		// REMMATO PERCHE' IL TASTO BACKSPACE NON VIENE PASSATO NELLA getchar()
		// LA getchar() LASCIA ESEGUIRE IL PROGRAMMA SOLO QUANDO SI PREME INVIO
		/*if (tmp == 8) {
		buffer[i - 1] = 0;
		i--;
		}*/
		if ((tmp == '-') && (i == 0)) segno = 1;
		if (tmp >= '0' && tmp <= '9') {
			if (i < MAXBUFFER) {
				buffer[i] = tmp;
				i++;
			}
		}
	}
	i--;
	for (int j = 0; j <= i; j++) {
		ritorno += (buffer[i - j] - '0') * pow(10, j);
	}
	if (segno) ritorno = -ritorno;
	return ritorno;
}