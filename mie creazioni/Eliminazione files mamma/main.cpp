#include <windows.h>
#include <tchar.h>
#include <stdio.h>
#include <time.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <string.h>
#include <sstream>
#include <iostream>
#include <windows.h>
#include <stdio.h>
#include <time.h>
#include <iostream>
#include <fstream>
#include <string.h>
#include <sstream>

int g,giorno;

using namespace std;

int dir(const char *szDir, bool bCountHidden /*= false*/)
{
  
	char path[MAX_PATH];
	WIN32_FIND_DATA fd;
	DWORD dwAttr = FILE_ATTRIBUTE_DIRECTORY;
	if( !bCountHidden) dwAttr |= FILE_ATTRIBUTE_HIDDEN;
	sprintf( path, "%s\\*", szDir);
	HANDLE hFind = FindFirstFile( path, &fd);
	if(hFind != INVALID_HANDLE_VALUE)
	{
		int count = 0;
		int conta=0;
		do
		{
            g=0;
            //puts( fd.cFileName);
            conta++;
            string a=fd.cFileName;
            if (a=="ok.txt") continue;
            if (a=="desktop.ini") continue;
            if (conta<=2) continue;
            cout<<fd.cFileName<<endl;
            if (conta>2){
                         string b="\\\\PC-ANDREA\\File_mamma\\"+a+"\\data.txt";
                         string c="RD /S /Q \"\\\\PC-ANDREA\\File_mamma\\"+a+"\"";
                         fstream f1(b.c_str(), ios::in);
                         f1>>g;
                         f1.close();
                         giorno-=28;
                         if (g==0) { system(c.c_str()); MessageBox(NULL,fd.cFileName,"Eliminato Data=0",MB_OK);  }
                         else if (g<=giorno) { system(c.c_str()); MessageBox(NULL,fd.cFileName,"Eliminato",MB_OK);}
                         }
            
			//if( !(fd.dwFileAttributes & dwAttr))
				 //puts( fd.cFileName);
		}while( FindNextFile( hFind, &fd));
		FindClose( hFind);
		return count;
	}
	return -1;
}

int main(){
    HWND hWnd = FindWindow("ConsoleWindowClass" , NULL);
    ShowWindow(hWnd, SW_HIDE);
    Sleep(300000);
    ShowWindow(hWnd, SW_HIDE);
    time_t t = time(NULL);
         tm *time;
         time = localtime(&t);
         giorno = time->tm_mday;
         int mese = time->tm_mon;
         int anno = time->tm_year;
         anno=anno+1900;
         mese=mese+1;
         giorno+=(mese*30)+(anno*365);
    dir("\\\\PC-ANDREA\\File_mamma",true);

}
