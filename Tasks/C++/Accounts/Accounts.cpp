// Accounts.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include "Account.h"
#include <Windows.h>

bool ReadFile(list<unique_ptr<Account>> &a);

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	
	list<unique_ptr<Account> > ac;

	if(ReadFile(ac)) return 0;
}

bool ReadFile(list<unique_ptr<Account>> &a) {
	ifstream fin;
	fin.open("Text.txt");

	if (!fin.is_open()) {
		cout << "Ошибка открытия файла." << endl;
		return true;
	}

	vector<AccountGas> acg;
	vector<AccountWater> acw;

	int gaz = 0;
	int water = 0;
	string str;
	cout << "Список счетов за газ и воду: " << endl;
	while (getline(fin, str)) {
		vector<string> VecStr;
		istringstream ss(str);
		string String;
		while (ss >> String)
			VecStr.push_back(String);
		if (VecStr.size() == 3) {
			a.emplace_back(new AccountGas(VecStr[0], stod(VecStr[2]), stoi(VecStr[1])));
			acg.push_back(AccountGas(VecStr[0], stod(VecStr[2]), stoi(VecStr[1])));
			if(stod(VecStr[2]) != 0.0)
				gaz++;
		}
		else {
			a.emplace_back(new AccountWater(VecStr[0], stod(VecStr[1]), stod(VecStr[2]), stod(VecStr[3])));
			acw.push_back(AccountWater(VecStr[0], stod(VecStr[1]), stod(VecStr[2]), stod(VecStr[3])));
			if (stod(VecStr[1]) != 0.0)
				water++;
		}
		(a.back())->Print(cout);
	}

	cout << endl;

	cout << "Список счетов за газ (по алфавиту): " << endl;
	ofstream fout;
	fout.open("AccountGas.txt");
	sort(acg.begin(), acg.end(), [](AccountGas &a, AccountGas &b) {return a.GetSurname() < b.GetSurname(); });
	for (auto a : acg) {
		a.Print(cout);
		a.Print(fout);
	}
	fout.close();

	cout << endl;

	cout << "Список счетов за воду (в порядке убывания сумм): " << endl;
	fout.open("AccountWater.txt");
	sort(acw.begin(), acw.end(), [](AccountWater &a, AccountWater &b) {return a.GetSum() > b.GetSum(); });
	for (auto a : acw) {
		a.Print(cout);
		a.Print(fout);
	}

	if (gaz - water >= 0)
		cout << endl << "Заплатили за газ, не заплатили за воду: " << gaz - water << endl;
	   
	fout.close();
	fin.close();
	return false;
}
