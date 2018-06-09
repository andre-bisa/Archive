#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int occorrenze(char A[], char B[]);

int main() {
	char a[] = "tre tigri contro tre tigri";
	char b[] = "tr";


	printf("%d\n", occorrenze(a,b));

	system("pause");
	return 0;
}

int occorrenze(char Caratteri[], char Cosa_cercare[]) {
	char* temp;
	int conta=0;
	temp = Caratteri;
	while (temp = strstr(temp, Cosa_cercare)) {
		temp++;
		conta++;
	}
	return conta;
}