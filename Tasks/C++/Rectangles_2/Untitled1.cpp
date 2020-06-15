#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include <math.h>
#include <ctype.h>
#include <Windows.h>

typedef struct Pryamokutnyk {
	float lw_x;
	float lw_y;
	float pn_x;
	float pn_y;
} pryam ;

int enter_a_value(pryam*, double[], int);
bool identify_errors(double, double, double, double);
int equalizeint(const void *a, const void *b) { return *(double*)a - *(double*)b; };
inline bool define_empty ()  { if(getchar() == 'q') return true;};
double tocalculate_square(double, double, double, double);
void define_rectangles(const pryam *, int);
void sort_rectangles(pryam *, double[], int);
void print_the_table(const pryam*, const double[], int);
void destructor(pryam*, double*);


int main(void){
	
  	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
  	
  	printf("Введіть кількість прямокутників: ");
  	int n;
  	scanf("%d", &n);
  	pryam *mas; 
	mas  = (pryam*)calloc( n, sizeof(pryam) ); //аналог mas[n]
  
  	double *mass;
	mass = (double*)calloc( n, sizeof(double) ); //аналог mass[n]
	
  	n = enter_a_value(mas, mass, n);  
    define_rectangles(mas, n); 
 
  	printf("\nТаблиця площі та вершин прямокутників:\n");
  	print_the_table(mas, mass, n);
  		
	sort_rectangles(mas, mass, n);
	printf("\nТаблиця площі та вершин прямокутників (відсортована):\n");
	print_the_table(mas, mass, n);

	destructor(mas, mass);
 	
  	return 0;
}



bool identify_errors(double x, double y, double x1, double y1){
	return !(x < x1 && y > y1);
}

void print_the_table(const pryam * pr, const double pm[], int N){
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
  		printf("Площа: %f", *(pm + i));
   		printf("\n");
  	}
}

double tocalculate_square(double lx, double ly, double px, double py){
	double str_1 = sqrt((pow((lx-lx),2))+(pow((ly-py),2)));
	double str_2 = sqrt((pow((px-lx),2))+(pow((py-py),2)));
	return str_1 * str_2;
}

int enter_a_value(pryam* mas, double ms[], int N){
	printf("\nВведіть координати двох протилежних \n(лівої верхньої і правої нижньої) вершин прямокутника (q - для виходу):\n\n");
  	int i;
	for(i = 0; i<N; i++){
  		printf("¹%d:\n", i + 1);
  		printf("L x: ");
  		scanf("%f", &mas[i].lw_x);
  		if(define_empty ()) return i;
		printf("L y: ");
		scanf("%f", &mas[i].lw_y);
		if(define_empty ()) return i;
		printf("P x: ");
		scanf("%f", &mas[i].pn_x);
		if(define_empty ()) return i;
		printf("P y: ");
		scanf("%f", &mas[i].pn_y);
		if(define_empty ()) return i;
		if(identify_errors(mas[i].lw_x, mas[i].lw_y, mas[i].pn_x,  mas[i].pn_y)){
			i--;
			printf("Помилка!!! Має бути: Lx < Px i Ly > Py. Повторіть введення.\n");
			continue;
		}
		printf("\n");
		*(ms + i) = tocalculate_square(mas[i].lw_x, mas[i].lw_y, mas[i].pn_x, mas[i].pn_y);
  	}
  	return i;
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
    	printf("\nТаких прямокутників немає.");
	}
	printf("\n");
}

void sort_rectangles(pryam * pr, double pd[], int N){
	qsort(pd, N, sizeof(double), equalizeint );
	pryam kk;
	for(int i = 0; i<N; i++){
  		for(int j = i; j<N; j++){
  			if(tocalculate_square(pr[i].lw_x, pr[i].lw_y, pr[i].pn_x, pr[i].pn_y) > 
			  tocalculate_square(pr[j].lw_x, pr[j].lw_y, pr[j].pn_x, pr[j].pn_y)){
  			  	kk = pr[i];
  			  	pr[i] = pr[j];
  			  	pr[j] = kk;
			}
  		}
 	}
}

void destructor(pryam* pm, double* pd){
	free(pm);
  	free(pd);
}
