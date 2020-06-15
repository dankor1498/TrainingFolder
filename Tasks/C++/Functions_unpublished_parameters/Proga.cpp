#include <stdio.h>
#include <stdarg.h>
#include <Windows.h>

/* 9.Розробити функцію зі змінною кількістю параметрів (x1, x2, x3, …), 
яка обчислює значення виразу (x1 + x3 + x5 + …)/(x2 + x4 + x6 + …). 
Відомо, що кількість пара-метрів функції парна.*/

double to_calculate(unsigned k, double x, ...);
double to_calculate_2(unsigned k, const char *types, double x, ...);
double to_calculate_3(unsigned k, const char *types, ...);

int main(void){
	
  	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
  	printf("Функція зі змінною кількістю параметрів повернула значення такого виразу:\n"
	  "(x1 + x3 + x5 + …)/(x2 + x4 + x6 + …).\nТест проводився з такими значеннями:\n\n" );
	printf("to_calculate (4, 1.5, 2.0, 4.0, 8.9): " );
  	printf("%f\n", to_calculate(4, 1.5, 2.0, 4.0, 8.9) );
  	printf("to_calculate_2 (4, \"dild\", 1.5, 2, 4, 8.9): " );
  	printf("%f\n", to_calculate_2(4, "dild", 1.5, 2, 4, 8.9) );
  	printf("to_calculate_3 (4, \"dild\", 1.5, 2, 4, 8.9): " );
  	printf("%f\n", to_calculate_3(4, "dild", 1.5, 2, 4, 8.9) );
  	  	
}

double to_calculate(unsigned k, double x, ...){
	if (k % 2 != 0) 
	 	printf("Помилка !!! Непарна кількість параметрів. Функція вернула: ");
	else{
		double *pd, numerator = 0.0, denominator = 0.0;
	for(pd = &x; k>0 ; k--, pd++ ){
		if(k % 2 == 0){
			numerator += *pd;
		}
		else
			denominator += *pd;
	}
	return numerator / denominator;
	}
}

double to_calculate_2(unsigned k, const char *types, double x, ...){
	if (k % 2 != 0) 
	 	printf("Помилка !!! Непарна кількість параметрів. Функція вернула: ");
	else{
		double *pd = &x, numerator = 0.0, denominator = 0.0;
		const char *pt = types;
		while(*pt != '\0'){
			switch (*pt){
				case 'i': 
					if(k % 2 == 0) { numerator += *(int*)pd; } 
					else denominator += *(int*)pd; 
					break;
				case 'l': 
					if(k % 2 == 0) { numerator += *(long*)pd; } 
					else denominator += *(long*)pd; 
					break;
				case 'd': 
					if(k % 2 == 0) { numerator += *(double*)pd; } 
					else denominator += *(double*)pd; 
					break;
			}
			pt++;
			pd++;
			k--;
		}
		return numerator / denominator;
	}
}

double to_calculate_3(unsigned k, const char *types, ...){
	if (k % 2 != 0) 
	 	printf("Помилка !!! Непарна кількість параметрів. Функція вернула: ");
	else{
		double numerator = 0.0, denominator = 0.0;
		const char *pt = types;
		va_list parg;
		va_start(parg, types);
		int in; long ln; double db;
		while(*pt != '\0'){
			switch (*pt){
				case 'i': in = va_arg(parg, int); 
					if(k % 2 == 0) { numerator += in; } 
					else denominator += in; 
					break;
				case 'l': ln = va_arg(parg, long); 
					if(k % 2 == 0) { numerator += ln; } 
					else denominator += ln; 
					break;
				case 'd': db = va_arg(parg, double); 
					if(k % 2 == 0) { numerator += db; } 
					else denominator += db; 
					break;
			}
			pt++;
			k--;
		}
		return numerator / denominator;
	}
}

