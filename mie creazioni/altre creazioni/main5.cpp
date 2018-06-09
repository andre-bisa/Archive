#include "stdio.h" 
#include "conio.h" 
#include <iostream>
#include <windows.h>
using namespace std;
int main() { 
MessageBox(NULL,"Text here","Text here",MB_OK|MB_ICONQUESTION);
/*cout<<"MB_OK "<<MB_OK<<endl;
cout<<"MB_YESNO "<<MB_YESNO<<endl;
cout<<"MB_OKCANCEL "<<MB_OKCANCEL<<endl;
cout<<"MB_RETRYCANCEL "<<MB_RETRYCANCEL<<endl;
cout<<"MB_YESNOCANCEL "<<MB_YESNOCANCEL<<endl;
cout<<"MB_ICONQUESTION "<<MB_ICONQUESTION<<endl;
cout<<"MB_TASKMODAL "<<MB_TASKMODAL<<endl;
cout<<"MB_SERVICE_NOTIFICATION "<<MB_SERVICE_NOTIFICATION<<endl;
cout<<"MB_DEFBUTTON1 "<<MB_DEFBUTTON1<<endl;
cout<<"MB_DEFBUTTON2 "<<MB_DEFBUTTON2<<endl;
cout<<"MB_DEFBUTTON3 "<<MB_DEFBUTTON3<<endl;
cout<<"MB_DEFBUTTON4 "<<MB_DEFBUTTON4<<endl;
cout<<"MB_SETFOREGROUND "<<MB_SETFOREGROUND<<endl;*/

int key = 0; 
printf("Press a key to continue, press Esc to quit\n"); 
while (key != 27) { 
key = getch(); 
if (key == 224) { 
key = getch(); 
switch (key) { 
case 72: printf("up arrow\n"); 
break; 
case 75: printf("left arrow\n"); 
break; 
case 77: printf("right arrow\n"); 
break; 
case 80: printf("down arrow\n"); 
break; 
} 
} 
else if (key == 0) { 
key = getch(); 
switch (key) { 
case 59: printf("F1\n"); 
break; 
case 60: printf("F2\n"); 
break; 
case 61: printf("F3\n"); 
break; 
case 62: printf("F4\n"); 
break; 
case 63: printf("F5\n"); 
break; 
case 64: printf("F6\n"); 
break; 
case 65: printf("F7\n"); 
break; 
case 66: printf("F8\n"); 
break; 
case 67: printf("F9\n"); 
break; 
case 68: printf("F10\n"); 
break; 
} 
} 
else { 
printf("%c: %d\n", key, key); 
} 
} 
printf("Esc\n");
} 
