#include <stdio.h>
#include <stdlib.h>

#define DIM 10

int leggi(int vet[], int dim);
void print(int list[], int length);


int main() {
	int vett[DIM];
	int dim;

	dim = leggi(vett, DIM);

	print(vett, dim);

	system("pause");
	return 0;
}


void print(int list[], int length) {
	if (length > 0) {
		print(list, length-1);
		printf("%d\n", list[length-1]);
	}
}

int leggi(int vet[], int dim) {
	int size = 0, num;
	do {
		printf("Inserisci un numero: ");
		scanf("%d", &num);
		if (num!=0 && size<dim) {
			vet[size] = num;
			size++;
		}
	} while (num!=0 && size<dim);
	return size;
}