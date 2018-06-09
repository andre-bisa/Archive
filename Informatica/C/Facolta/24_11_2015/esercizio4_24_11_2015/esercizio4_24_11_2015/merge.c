#include "merge.h"


void merge(Element v[], int i1, int i2, int fine, Element vout[]) {
	int i=i1, j=i2, k=i1;
	while ( i <= i2-1 && j <= fine ) {
		if (compare(v[i], v[j]) < 0) {
			vout[k] = v[i];
			i++;
		}
		else {
			vout[k] = v[j];
			j++;
		}
		k++;
	}
	while (i<=i2-1) {
		vout[k]=v[i];
		i++; k++;
	}
	while (j<=fine) {
		vout[k]=v[j];
		j++; k++;
	}
	for (i=i1; i<=fine; i++) v[i] = vout[i];
}

void mergeSort(Element v[], int iniz, int fine, Element vout[]) {
	int mid;
	if ( iniz < fine ) {
		mid = (fine + iniz) / 2;
		mergeSort(v, iniz, mid, vout);
		mergeSort(v, mid+1, fine, vout);
		merge(v, iniz, mid+1, fine, vout);
	}
}

int compare(Element s1, Element s2) {
	if (s1.cmNeve) {

	}
	return s1.cmNeve - s2.cmNeve;
}