#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <Windows.h>

int find_words(const char * str);
int find_warehouses(const char * str);
int k_kr = 0;

int main(int argc, char* argv[]){
	
	SetConsoleOutputCP(1251);
  	SetConsoleCP(1251);
		
	if(argc != 2){
		printf("Помилка! Введіть коректну кількість параметрів.\n");
		return 0;
	}
	  	
  	FILE *fp;
  	FILE *fd;
  	FILE *fw;
  	int c;
  	
  	fp = fopen(argv[1], "r+");
  	int s = 0;
  	
  	while((c = getc(fp)) != EOF){
  		s++;
  	}
  	
  	char *mas; 
	mas  = (char*)calloc( s+1, sizeof(char) ); 
	
	int i = 0;
	fd = fopen("D:\\Documents\\Предмети\\Програмування\\Лаби_2\\№7\\Text.txt, "r");
	while((c = getc(fd)) != EOF){
  			mas[i++]=c;
  	}
  	mas[s]= '\0';
  	
  	printf("Текст який зчитано з файлу:\n\n%s", mas);
  	printf("\n\nСимволів = %d", s);
  	int sliv = find_words(mas), skladiv = find_warehouses(mas);
	double sskl = double(skladiv)/double(sliv) ;
  	printf("\nСлів = %d\nСкладів = %d\nСередня кількість складів на слово = %f", sliv, skladiv, sskl );
  	printf("\nРечень = %d", k_kr);
  	
  	fw = fopen("D:\\Documents\\Предмети\\Програмування\\Лаби_2\\№7\\Text.txt", "w");
  	int k = 0;
  	i=0;
  	while(mas[i] != '\0'){
  			if(mas[i] == '.'){
  				k++;
  			}
  			if(k == (k_kr-2)){
  				mas[i+1] = '\0';
  				break;
  			}
  			i++;
  	}
  	printf("\n\nТекст без останніх двох речень:\n\n%s", mas);
  	fprintf(fw, "%s", mas);
    	
  	fclose(fp);
}

int find_words(const char * str){
	int i = 0, k = 0;
    bool flag = true, f = true;
    while(str[i] != '\0'){
        if(isalpha(*(str + i)) && flag == true){
            k++;
            i++;
            flag = false;
            continue;
    	}
        while(ispunct(*(str + i)) || isspace(*(str + i))){
            i++;
            flag = true;
            f=false;
        }
        if(f==false){i--; f=true;}        
        i++;
    }
	return k;
}

int find_warehouses(const char * str){
	int i = 0, k = 0;
    while(str[i] != '\0'){
        switch(*(str + i)){
        	case 'A':
        	case 'a': k++; i++; break;
        	case 'E':
        	case 'e': k++; i++; break;
        	case 'I':
        	case 'i': k++; i++; break;
        	case 'O':
        	case 'o': k++; i++; break;
        	case 'U':
        	case 'u': k++; i++; break;
        	case '.': k_kr++; i++; break;
			default: i++;	
        }
    }
	return k;
}
