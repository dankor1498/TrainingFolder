#include <stdio.h>

/*9.� ��������� ������ ����������� ��������, ����� � ���� ���� ���������� ���� ����������� 
(��� ������� � ����� ������) ������ ������������, ������� ����� ��������� �� ���� ���������. 
������������ ������ ��� � ������ �������. 
������� ������ ������������, ������������ �������� ������� ������������, ��� ���������, �� ����� ����. 
���� ����������� ��� �� �������� ��������� ����� ������������ � ����������� ���� �������.*/

typedef struct Pryamokutnyk {
	float lw_x;
	float lw_y;
	float pn_x;
	float pn_y;
} pryam ;

int enter_a_value(pryam*, double[], int);
bool identify_errors(double, double, double, double);
int equalizeint(const void *a, const void *b);
inline bool define_empty ()  { if(getchar() == 'q') return true;};
double tocalculate_square(double, double, double, double);
void define_rectangles(const pryam *, int);
void sort_rectangles(pryam *, double[], int);
void print_the_table(const pryam*, const double[], int);
void destructor(pryam*, double*);

