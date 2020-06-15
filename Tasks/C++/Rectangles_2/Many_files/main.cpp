#include "funck.h"
#include <stdio.h>
#include <malloc.h>
#include <ctype.h>
#include <Windows.h>

int kil = 0;
static int n;

int main(void){
	
  	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
  	
  	printf("¬вед≥ть к≥льк≥сть пр€мокутник≥в: ");
  	
  	scanf("%d", &n);
  	pryam *mas; 
	mas  = (pryam*)calloc( n, sizeof(pryam) ); //аналог mas[n]
  
  	double *mass;
	mass = (double*)calloc( n, sizeof(double) ); //аналог mass[n]
	
  	n = enter_a_value(mas, mass, n);  
    define_rectangles(mas, n); 
 
  	printf("\n“аблиц€ площ≥ та вершин пр€мокутник≥в:\n");
  	print_the_table(mas, mass, n);
  		
	sort_rectangles(mas, mass, n);
	printf("\n“аблиц€ площ≥ та вершин пр€мокутник≥в (в≥дсортована):\n");
	print_the_table(mas, mass, n);

	destructor(mas, mass);
	getchar();
	
  	return 0;
}




