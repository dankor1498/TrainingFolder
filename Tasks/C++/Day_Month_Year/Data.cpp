// Data.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <fstream> 
#include <cstdlib>
#include <sstream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "Rus");  
	ifstream finn, fin;
	fin.open("Text.txt");    //файл с датами в формате 00.00.0000
	finn.open("Text.txt");   //файл с датами в формате 00.00.0000, другой обьект для считывания информации
	ofstream fout;           // обьект для вывода в файл
	fout.open("Vychid.txt"); //файл вывода
	if (!fin.is_open())      // не удалось открыть файл
	{
		cout << "Не удалось открыть файл " << "Text.txt" << endl;
		cout << "Программа прервана. \n";
		exit(EXIT_FAILURE);
	}
	string data; int N = 0, i = 0; //рабочая строка, счётчик дат
	const string mas[12] = {
		"Январь",
		"Февраль",
		"Март",
		"Апрель",
		"Май",
		"Июнь",
		"Июль",
		"Август",
		"Сентябрь",
		"Октябрь",
		"Ноябрь",
		"Декабрь"
	}; //массив месяцев

	while (finn >> data) {
		N++;
	}                                 //подсчет дат для создания динамических массивов

	string *mas_1 = new string[N];    // два массива в которые будет записываться новый формат дат
	string *mas_copy = new string[N];
	int *mas_2 = new int[N];          //массив с числами месяцев

	while (fin >> data) {
		char st[3];
		st[0] = data[3];
		st[1] = data[4];
		st[2] = '\0';
		int mes = atoi(st);          //преобразовываем номер месяца с строки в число
		mas_1[i] = (mas[--mes] + " " + data[6] + data[7] + data[8] + data[9] + ":"); //собираем строку, внизу вывод результата
				
		char std[3];
		std[0] = data[0];
		std[1] = data[1];
		std[2] = '\0';
		mas_copy[i] = mas_1[i]+ " " + to_string(atoi(std)); //собираем строку + изначальное число, внизу вывод результата
		mas_2[i++] = atoi(std);
		
	}
	
	cout << "\t\tmas_2 \n";
	for (int i = 0; i < N; i++) {  //вывод результатов (для ясности)
		cout << mas_2[i] << " ";
	}
	cout << endl << endl; 

	cout << "\t\tmas_1 \n";
	for (int i = 0; i < N; i++) {
		cout << mas_1[i] << endl;
	}
	cout << endl << endl;

	cout << "\t\tmas_copy \n";
	for (int i = 0; i < N; i++) {
		cout << mas_copy[i] << endl;
	}
	
	for (int i = 0; i < N; i++) {      //Важно, цикл сравнивания, если сходятся добавляем к строке числа и заменяем на пробел 
		for (int j = i + 1; j < N; j++) {
			if (mas_1[i] == mas_1[j] && mas_1[i] != "") {
				mas_copy[i] += (", " + to_string(mas_2[j]));
				mas_1[j] = "";
				mas_copy[j] = "";
			}
		}
	}

	cout << endl << "\t\tPезультат" << endl;
	for (int i = 0; i < N; i++) { //вывод результата на консоль и в файл
		if (mas_copy[i] == "")
			continue;
		cout << mas_copy[i] << endl;
		fout << mas_copy[i] << endl;
	}

	cout << endl << N << "\n";

	delete [] mas_1;
	delete [] mas_copy;
	delete [] mas_2;
	
	return 0;
}

