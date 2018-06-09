#include <stdio.h>
#include <stdlib.h>

#define DIM 10

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

int conta_ripetizioni(int v[], int dim, int cosa_cercare) {
	int conta = 0;
	int i=0;
	do {
		if (trovaPos(&v[i+1], dim-i, cosa_cercare) >= 0) 
			conta++;
		i++;
	} while (i<dim && conta>0);
	return conta;
}

int main(void) {
	int v[DIM], dim, i, count, temp_dim, temp_pos, offset;
	dim = leggi(v, DIM);
	for (i=0; i<dim; i++) {
		count = 0;
		temp_dim = dim;
		offset = 0;
		do {
			temp_pos = trovaPos(&v[offset], temp_dim, v[i]);
			if (temp_pos >= 0) {
				count++;
				temp_dim = temp_dim - temp_pos - 1;
				offset = offset + temp_pos + 1;
			}
		} while (temp_pos>=0 && count<2);
		if (count == 2)
			printf("L'elemento %d compare 2 volte\n", v[i]);
	}
	system("pause");
	return (0);
}