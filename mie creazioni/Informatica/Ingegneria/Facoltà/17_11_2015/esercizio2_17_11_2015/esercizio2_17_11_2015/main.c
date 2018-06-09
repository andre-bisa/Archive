#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int conc(char A[],char B[],char C[]);

int main() {
	char a[] = "Hello ";
	char b[] = "World!";
	char c[20];

	conc(a,b,c);

	printf("%s\n", c);

	system("pause");
	return 0;
}

int conc(char A[],char B[],char C[]) {
	//strcpy(C, A);
	//strcpy(C + strlen(C), B);
	//return strlen(C);
	return strlen(strcpy(strcpy(C, A) + strlen(C), B));
}