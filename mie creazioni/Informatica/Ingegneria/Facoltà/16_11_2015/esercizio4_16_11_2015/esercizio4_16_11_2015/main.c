#include <stdio.h>
#include <stdlib.h>


void somme2(int l1[], int length);

int main() {
	int l1[] = {5, 6, 4, 2, 1, 1, 3, 1};
	int dim = 8;

	somme2(l1, dim);

	system("pause>nul");
	return 0;
}

void somme2(int l1[], int length) {
	if (length > 2) {
		if (l1[length-2-1] == l1[length-1-1] + l1[length-1]) {
			printf("%d ", l1[length-2-1]);
		}
		somme2(l1, length-1);
	}
}