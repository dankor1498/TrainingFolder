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
  	
  	printf("������ ������� ������������: ");
  	
  	scanf("%d", &n);
  	pryam *mas; 
	mas  = (pryam*)calloc( n, sizeof(pryam) ); //������ mas[n]
  
  	double *mass;
	mass = (double*)calloc( n, sizeof(double) ); //������ mass[n]
	
  	n = enter_a_value(mas, mass, n);  
    define_rectangles(mas, n); 
 
  	printf("\n������� ����� �� ������ ������������:\n");
  	print_the_table(mas, mass, n);
  		
	sort_rectangles(mas, mass, n);
	printf("\n������� ����� �� ������ ������������ (�����������):\n");
	print_the_table(mas, mass, n);

	destructor(mas, mass);
	getchar();
	
  	return 0;
}




