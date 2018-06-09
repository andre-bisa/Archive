#include <cstdlib>
#include <iostream>
#include <stdio.h>
#include <fstream>
#include <string.h>
#include <windows.h>

using namespace std;

char a[]={' ', 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9','$','<','>','(',')','[',']','{','}','$',',','.','%','&','"','!','?','=','?','è','+','-','_','@'};
int b=sizeof(a);
char m,n,o,p,q,r,s;
char w[9];

int main()
{
fstream z("dizionario.txt", ios::out|ios::trunc);
for(int c=0; c<b; c++) {//1
	m=a[c];
	for(int d=0; d<b; d++) { //2
		n=a[d];
		for(int e=0; e<b; e++) { //3
			o=a[e];
			for(int f=0; f<b; f++) { //4
				p=a[f];
				for(int g=0; g<b; g++) { //5
					q=a[g];
					for(int h=0; h<b; h++) { //6
						r=a[h];
						for(int i=0; i<b; i++) { //7
							s=a[i];
							for(int j=0; j<b; j++) { //8
								w[0]=m;
								w[1]=n;
								w[2]=o;
								w[3]=p;
								w[4]=q;
								w[5]=r;
								w[6]=s;
								w[7]=a[j];
                                //w=m+n+o+p+q+r+s+a[j];
								cout<<w<<endl;
								string stringa=w;
								//Sleep(1);
                                z<<stringa<<endl;
                                //w=m.n.o.p.a[j];
								//fwrite(u, w."n");
                                //f (md5(w)=="5a3d5e71b9c34ec5b6ba906e7d46ea7d") echo w;
								//echo w;
								//echo "<br>";
							}
						}
					}
				}
			}
		}
	}
}
	
    system("pause");
    return EXIT_SUCCESS;
}
