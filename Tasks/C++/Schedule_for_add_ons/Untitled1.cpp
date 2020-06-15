#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include <math.h>
#include <ctype.h>
#include <Windows.h>

/*9.Розробити функцію, яка визначає та виводить на екран всі можливі подання заданого
 натурального числа N (N <= 50000) у формі суми k (k <= 10) різних натуральних доданків. 
 З клавіатури ввести масив беззнакових цілих чисел. Використовуючи розроблену функцію, 
 подати розклад кожного з введених чисел на задану кількість доданків*/

int sum_the_amount(int, int);
void find_all_solutions(int, int[], int, int);
void print (int[], int, int);


int main(void){
	
  	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
  	
  	printf( "Введіть кількість чисел: " );
  	int N, *mass;
  	scanf( "%d", &N );
  	mass = (int*)calloc( N, sizeof(int) );
  	
  	for(int i = 0; i < N; i++){
  		int *mas, n, n_copy;
		printf( "Введіть натуральне число №%d: ", i+1 );
		scanf( "%d", &n );
 		n_copy = n;
 		printf("Існує %d розкладів даного числа.\n" , sum_the_amount(n_copy, n_copy));
 		mas = (int*)calloc( n, sizeof(int) );
		find_all_solutions(n, mas, 0, n_copy);
   		free(mas);
  	}
  	
   	free(mass);
}

int sum_the_amount(int N, int k){
	if (k == 0) {
        if (N == 0)
           return 1;
        return 0;
    }
    if (k <= N)
        return sum_the_amount(N, k-1) + sum_the_amount(N - k, k);
    return sum_the_amount(N, N);
}

void find_all_solutions(int R, int A[], int q, int S){
   	int i, last = R;
	if ( R == 0 ) print ( A, q, S );
	else {
    	if ( q > 0   &&  last > A[q-1] )
        	last = A[q-1];
    	for (i = 1; i <= last; i ++ ) {
        	A[q] = i;
        	find_all_solutions(R-i, A, q+1,  S);
    	}
  	}
}

void print(int mas[], int q, int s){
	for(int i = 0; i < q; i++){
		printf("%d + ", *(mas+i));	
	}
	printf("\b\b= %d \n", s);
}
