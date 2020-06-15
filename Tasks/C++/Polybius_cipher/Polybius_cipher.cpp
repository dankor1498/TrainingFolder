// Polybius_cipher.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include "Header.h"

int main()
{
	ifstream fin;
	fin.open("Text.txt");

	if (!fin.is_open()) {
		cout << "File not found\n";
		return 0;
	}
	char c;
	string buf;
	while (fin.get(c)) {
		buf += c;
	}
	cout << buf << endl << endl;
	
	multimap<char, xy> code;
	unordered_map<xy, char, KeyHasher> dcode;
	for (int i = 0, j = 0; i < 52; i++, j += 2) {
		xy itr;
		itr.x = alphabet_code[j];
		itr.y = alphabet_code[j + 1];
		dcode.insert(pair<xy, char>(itr, alphabet[i]));
	}

	for (int i = 0, j = 0; i < 52; i++, j += 2) {
		xy itr;
		itr.x = alphabet_code[j];
		itr.y = alphabet_code[j + 1];
		code.insert(pair<char, xy>(alphabet[i], itr));
	}

	int i = 0;
	ofstream fout;
	fout.open("Text_encoded.txt");
	if (!fout.is_open()) {
		cout << "File not found\n";
		return 0;
	}

	while (buf[i] != '\0') {
		if (isalpha(buf[i]) == 0){
			fout << buf[i];
			cout << buf[i];
			i++;
			continue;
		}
		fout << setw(3) << setfill('0') << code.find(buf[i])->second.x 
			<< setw(3) << setfill('0') << code.find(buf[i])->second.y;
		cout << setw(3) << setfill('0') << code.find(buf[i])->second.x 
			<< setw(3) << setfill('0') << code.find(buf[i])->second.y;
		i++;
	}
	fout.close();
	cout << endl << endl;

	ifstream fin_0;
	fin_0.open("Text_encoded.txt");

	if (!fin_0.is_open()) {
		cout << "File not found\n";
		return 0;
	}

	buf.clear();
	while (fin_0.get(c)) {
		buf += c;
	}

	fout.open("Text_decoded.txt");
	if (!fout.is_open()) {
		cout << "File not found\n";
		return 0;
	}

	i = 0;
	string x, y;
	xy dc;
	while (buf[i] != '\0') {
		if (!isdigit(buf[i])) {
			fout << buf[i];
			cout << buf[i];
			i++;
			continue;
		}

		x += buf[i++];
		x += buf[i++];
		x += buf[i++];
		y += buf[i++];
		y += buf[i++];
		y += buf[i];

		dc.x = stoi(x);
		dc.y = stoi(y);

		fout << dcode.find(dc)->second;
		cout << dcode.find(dc)->second;

		i++;
		x.clear();
		y.clear();
	}

	fout.close();
}



