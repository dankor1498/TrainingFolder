#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include <math.h>
#include <Windows.h>

typedef struct Pryamokutnyk {
	float lw_x;
	float lw_y;
	float pn_x;
	float pn_y;
} pryam ;

double tocalculate_square(double, double, double, double);
void define_rectangles(const pryam *, int);
void sort_rectangles(pryam *, double*, int);

int main(void){
	
  	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
  	
  	printf("Введіть кількість прямокутників: ");
  	int n;
  	scanf("%d", &n);
  	pryam *mas; 
	mas  = (pryam*)calloc( n, sizeof(pryam) );
  	
  	double *mass;
	mass = (double*)calloc( n, sizeof(double) );
	
  	printf("\nВведіть координати двох протилежних \n(Лівої верхньої і правої нижньої) вершин прямокутника:\n\n");
  	for(int i = 0; i<n; i++){
  		printf("¹%d:\n", i + 1);
  		printf("L x: ");
		scanf("%f", &mas[i].lw_x);
		printf("L y: ");
		scanf("%f", &mas[i].lw_y);
		printf("P x: ");
		scanf("%f", &mas[i].pn_x);
		printf("P y: ");
		scanf("%f", &mas[i].pn_y);
		if(!(mas[i].lw_x < mas[i].pn_x && mas[i].lw_y > mas[i].pn_y)){
			i--;
			printf("Помилка!!! Має бути: Lx < Px i Ly > Py. Повторіть введення.\n");
			continue;
		}
		printf("\n");
		*(mass + i) = tocalculate_square(mas[i].lw_x, mas[i].lw_y, mas[i].pn_x, mas[i].pn_y);
  	}
  
define_rectangles(mas, n); 
 
  	printf("\nТаблиця площі і вершин прямокутника:\n");
  	for(int i = 0; i<n; i++){
  		printf("------------ ¹%d ------------\n", i + 1);
  		printf("X: %f", (mas + i)->lw_x); 
  		printf("\t");
  		printf("Y: %f", (mas + i)->lw_y);
    	printf("\n");
  		printf("X: %f", (mas + i)->pn_x);
  		printf("\t");
  		printf("Y: %f", (mas + i)->pn_y);
  		printf("\t");
  		printf("Площа: %f", *(mass + i));
   		printf("\n");
  	}
  	
sort_rectangles(mas, mass, n);

	free(mas);
  	free(mass);
 	
  	return 0;
}

double tocalculate_square(double lx, double ly, double px, double py){
	double str_1 = sqrt((pow((lx-lx),2))+(pow((ly-py),2)));
	double str_2 = sqrt((pow((px-lx),2))+(pow((py-py),2)));
	return str_1 * str_2;
}

void define_rectangles(const pryam * pr, int N){
	printf("Номери прямокутників, розташованих усередині першого прямокутника: ");
	bool flag = false;
	for(int i = 1; i<N; i++){
		if(((pr+i)->lw_x >= pr->lw_x && (pr+i)->lw_y <= pr->lw_y) && 
			((pr+i)->pn_x <= pr->pn_x && (pr+i)->pn_y >= pr->pn_y)){
				printf("%d ", i+1);
				flag = true;
		}
	}
    if (flag == false) {
    	printf("\nТаких прямокутників не існує.");
	}
	printf("\n");
}

void sort_rectangles(pryam * pr, double * pd, int N){
	double k;
	pryam kk;
	for(int i = 0; i<N; i++){
  		for(int j = i; j<N; j++){
  			if(pd[i] > pd[j]){
  			  	k = pd[i];
  			  	pd[i] = pd[j];
  			  	pd[j] = k;
  			  	kk = pr[i];
  			  	pr[i] = pr[j];
  			  	pr[j] = kk;
			}
  		}
 	}
 	printf("\nТаблиця площі і вершин прямокутника (відсортована):\n");
  	for(int i = 0; i<N; i++){
  		printf("------------ ¹%d ------------\n", i + 1);
  		printf("X: %f", (pr + i)->lw_x); 
  		printf("\t");
  		printf("Y: %f", (pr + i)->lw_y);
    	printf("\n");
  		printf("X: %f", (pr + i)->pn_x);
  		printf("\t");
  		printf("Y: %f", (pr + i)->pn_y);
  		printf("\t");
  		printf("Площа: %f", *(pd + i));
   		printf("\n");
  	}
}


