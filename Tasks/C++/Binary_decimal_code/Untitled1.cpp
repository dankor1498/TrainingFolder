#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include <math.h>
#include <Windows.h>

const char * code [10]{
	"0000", //0
	"0001", //1
	"0010", //2
	"0011", //3
	"0100", //4
	"0101", //5
	"0110", //6
	"0111", //7
	"1000", //8
	"1001"  //9
};

void generate_code(const unsigned[], int);

int main(void){
	
	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
  	
	printf("Введіть кількість чисел: ");
  	int n;
  	scanf("%d", &n);
  	unsigned *mas; 
	mas  = (unsigned*)calloc( n, sizeof(unsigned) );
	
  	printf("Введіть числа:\n");
	for(int i = 0; i<n ; i++){
		scanf("%d", (mas+i));
	}
	printf("\nЧисла та їх двійковo-десяткові коди:\n\n");
	generate_code(mas, n) ; 	
  	free(mas);
  	
  	return 0;
}

void generate_code(const unsigned pm[], int N){
	int k = 0;
	for(int i = 0; i<N ; i++){
		printf("%d  -  ", *(pm+i));
		unsigned n = *(pm+i);
		unsigned n_1 = *(pm+i);
		while(n != 0){
  			n/=10;
  			k++;
	  	}
	  	
		int *str;
	  	str = (int*)calloc( k, sizeof(int) );
	  	for(int j = 0; j < k; j++){
	  		*(str+j) = n_1%10;
	  		n_1/=10;
	  	}
	  	
	  	for(int *pm = str, *pe = (str + k - 1), n; pm < pe; pm++, pe--){
	  		n = *pm;
	  		*pm = *pe;
	  		*pe = n;
	  	}
	  	
	  	for(int j = 0; j < k; j++){
	  		printf("%s ", code[str[j]]);
	  	}
	  	
	  	printf("\n");
	  	free(str);
	  	k=0;
	}	
		
	
}
