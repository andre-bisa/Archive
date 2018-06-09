#include <stdio.h>
#include <stdlib.h>

#define DIM 10

int trovaPos(int vett[], int dim_vett, int cosa_cercare);
int leggi(int vet[], int dim);

int main(void)
{
	int vett[DIM];
	int dim_vett;
	int i;
	dim_vett = leggi(vett, DIM);
	for (i=0; i<dim_vett; i++)
		if ( trovaPos(&vett[i+1], dim_vett-i-1, vett[i]) >= 0 )
			if ( trovaPos(vett, i, vett[i]) < 0)
				printf("%d ", vett[i]);
	system("pause");
	return (0);
}

int trovaPos(int vett[], int dim_vett, int cosa_cercare) {
	int i;
	int ritorno = -1;
	for (i=0; i<dim_vett && ritorno<0; i++) {
		if (vett[i] == cosa_cercare)
			ritorno++;
	}
	return ritorno;
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