#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <stdlib.h>
#include <Windows.h>

const int LEN_1 = 80;

typedef struct DatE {
	int year;
	int month;
	int day;
} DAT;

typedef struct history {
	char data[11];
	DAT dat;
	char podija[LEN_1];
} hist;

void sort(hist * ph, int N);
void fill_the_structure(hist * mass, int ss);
void print(const hist *ph, int N);
bool cmp_dates(DAT d1, DAT d2);
void scan(hist *);

int main(){
	
	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
 	printf("Оберіть тип вводу: 1 - з файлу, 2 - з клавіатури: ");
 	int type;
 	scanf("%d", &type);
 	while(type != 1 && type != 2){
 		printf("Оберіть тип вводу: 1 - з файлу, 2 - з клавіатури: ");
 		scanf("%d", &type);
 	}
 		
	hist *mas;
	int c, s = 0;
	FILE *fp;
  	FILE *fr;
  	bool flag = true;
  	
 	if(type == 1){
 		const char *fstr = "D:\\Documents\\Предмети\\Програмування\\Лаби_2\\№8\\Text.txt";
  		fp = fopen(fstr, "r");
  		fr = fopen(fstr, "r");
  		
   		while((c = getc(fp)) != EOF){
  			if(c == '\n'){
  			 	s++;
  			}
		}
		s/=2;
		
  		printf("\nКількість даних в файлі: %d\n\n", s);
  		mas  = (hist*)calloc( s, sizeof(hist) ); 
  		
		for(int i = 0; i<s; i++){
			fscanf(fr,"%s", (mas+i)->data ); fgetc(fr);
			fgets((mas+i)->podija, LEN_1, fr);
			(mas+i)->dat.year = (mas+i)->dat.month = (mas+i)->dat.day = 0;
		}
		
		fill_the_structure(mas, s);
		flag = false;
 	}
 	
 	else{
 		printf("Введіть кількість даних: ");
 		scanf("%d", &s);
 		mas  = (hist*)calloc( s, sizeof(hist) ); 
 		for(int i = 0; i<s; i++){
 			scan(&mas[i]);
 		}
 	}
	  
	printf("Зчитані дані: \n");
	print(mas, s);
	printf("\n\n");

	sort(mas, s);
	printf("Відсортовані дані: \n");
	print(mas, s);
	printf("\n\n");

	mas  = (hist*)realloc( mas, sizeof(hist)*(s+1) );
	hist n;
	scan(&n);
	mas[s] = n;
	printf("\nДані + додаткова структура: \n");
	sort(mas, s+1);
	print(mas, s+1);
	
	if(flag == false){
	    fclose(fp);
	 	fclose(fr);	
	}
	
}

void sort(hist * ph, int N){
	hist k;
	for(int i = 0; i<N; i++){
		for(int j = i; j<N; j++){
			if ( !cmp_dates((ph+i)->dat, (ph+j)->dat) ) {
        		k = *(ph+i);
        		*(ph+i) = *(ph+j);
        		*(ph+j) = k;
    		}
    	}
	}
}


void fill_the_structure(hist * mass, int ss){
	char dat_m[3];
	char dat_d[3];
	char dat_y[5];

	for(int i = 0; i<ss; i++){
		dat_d[0] = ((mass+i)->data)[0];
		dat_d[1] = ((mass+i)->data)[1];
		dat_d[2] = '\0';

		dat_m[0] = ((mass+i)->data)[3];
		dat_m[1] = ((mass+i)->data)[4];
		dat_m[2] = '\0';

		dat_y[0] = ((mass+i)->data)[6];
		dat_y[1] = ((mass+i)->data)[7];
		dat_y[2] = ((mass+i)->data)[8];
		dat_y[3] = ((mass+i)->data)[9];
		dat_y[4] = '\0';
	
		(mass+i)->dat.year = atoi(dat_y);
		(mass+i)->dat.month = atoi(dat_m);
		(mass+i)->dat.day = atoi(dat_d);
}

}

void print(const hist *ph, int N){
	for(int i = 0; i<N; i++){
		puts((ph+i)->data);
		puts((ph+i)->podija);
	}
}

bool cmp_dates(DAT d1, DAT d2) {
    return (d1.year < d2.year) ||
           (d1.year == d2.year && d1.month < d2.month) ||
           (d1.year == d2.year && d1.month == d2.month && d1.day < d2.day);
}

void scan(hist * h)
{
	printf("Введіть дату у форматі dd.mm.rrrr: "); 
	scanf("%s", h->data);
	printf("Введіть подію: "); getchar();
	gets(h->podija); 
	fill_the_structure(h, 1);
}
