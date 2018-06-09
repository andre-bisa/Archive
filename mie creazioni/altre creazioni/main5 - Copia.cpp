#include "stdio.h" 
#include "conio.h" 
#include <iostream>
#include <windows.h>
using namespace std;
int main() {    
int key = 0; 
char a;
printf("Press a key to continue, press Esc to quit\n"); 
while (key != 27) { 
key = getch(); 
if (key==72) cout<<"Su"<<endl;
if (key==75) cout<<"Sinistra"<<endl;
if (key==77) cout<<"Destra"<<endl;
if (key==80) cout<<"Giu'"<<endl;
if (key==9) cout<<"[TAB]"<<endl;
if (key==15) cout<<"CTRL + O"<<endl;
if (key==31) cout<<"CTRL + -"<<endl;
a=key;
cout<<a<<":"<<key<<endl;
}
printf("Esc\n");
} 
