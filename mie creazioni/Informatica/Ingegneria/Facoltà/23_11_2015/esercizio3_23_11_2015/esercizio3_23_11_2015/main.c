#include <stdio.h>
#include <stdlib.h>



int main() {
	int temp[31][24];
	int i,j;

	for (i=0; i<31; i++)
		for (j=0; j<24; j++)
			srand(rand()), temp[i][j] = 18 + rand() % 3;



	system("pause");
	return 0;
}