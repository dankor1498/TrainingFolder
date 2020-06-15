// Gann_Diagram.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <vector>
#include <list>
#include <cstdlib>
#include <algorithm>
#include <ctime>
#include <typeinfo>


using namespace std;

int main()
{
	srand(time(0));

	list<int> li[3];
	for (int i = 0; i < 10000; i++) {
		li[0].push_back(0 + rand() % 100);
		li[1].push_back(0 + rand() % 100);
		li[2].push_back(0 + rand() % 100);
	}


	{
		cout << "First come - first served (FCFS):\n#0: 0 sec.\n";
		double result = 0.0;
		for (int i = 0; i < 3; i++) {
			clock_t start = clock();
			li[i].sort();
			clock_t end = clock();
			result += double(end - start) / CLOCKS_PER_SEC;
			cout << "#" << i + 1 << ": " << result << " sec." << endl;
		}
	}

	{
		cout << "\n\nSJF - Shortest Job First:\n";
		double mas[3];
		for (int i = 0; i < 3; i++) {
			clock_t start = clock();
			li[i].sort();
			clock_t end = clock();
			mas[i] = double(end - start) / CLOCKS_PER_SEC;
			cout << "#" << i + 1 << ": " << mas[i] << " sec." << endl;
		}
		cout << "Procedure for execution by algorithm: ";

		for (int i = 0; i < 3; i++) {
			double temp;
			for (int j = i; j < 3; j++) {
				if (mas[j] < mas[i]) {
					temp = mas[i];
					mas[i] = mas[j];
					mas[j] = temp;
				}
			}
		}

		for (auto i : mas)
			cout << i << " -> ";
		cout << "End.\n\n\n";
	}

	{
		cout << "Priority planning strategy:\n";
		int mas_p[3] = { 2, 0, 1 };
		double mas[3];
		cout << "Defined priority: ";
		for (auto i : mas_p) {
			cout << "#" << i + 1 << " -> ";
		}
		cout << "End.\n";
		for (int i = 0; i < 3; i++) {
			clock_t start = clock();
			li[i].sort();
			clock_t end = clock();
			mas[i] = double(end - start) / CLOCKS_PER_SEC;
			cout << "#" << i + 1 << ": " << mas[i] << " sec." << endl;
		}
		cout << "Procedure for execution by algorithm: ";
		for (int i = 0; i < 3; i++) {
			cout << mas[mas_p[i]] << " -> ";
		}
		cout << "End.\n\n\n";
	}
	
	{
		cout << "Round Robin - RR:\n";
		
		clock_t time = 0.3 * CLOCKS_PER_SEC;
		cout << "Time for one project: " << double(time) / CLOCKS_PER_SEC << endl;

		double t = 0.0;
		
		for (int i = 0; i < 3; i++) {
			clock_t start = clock();
			while (clock() - start < time) {
				clock_t s = clock();
				li[i].sort();
				clock_t end = clock();
				t = double(end - s) / CLOCKS_PER_SEC;
				cout << "#" << i + 1 << ": " << t << " sec." << endl;
			}
			if (t > 0.3)
				i--;
			t = 0.0;
		}
		cout << "\n\n\n";
	}

	{
		cout << "Multilevel queue scheduling\n";

		vector<int> vi[3];
		for (int i = 0; i < 100000; i++) {
			vi[0].push_back(0 + rand() % 100);
			vi[1].push_back(0 + rand() % 100);
			vi[2].push_back(0 + rand() % 100);
		}

		if (typeid(class vector<int, class allocator<int> >[3]) == typeid(vi)) {
			cout << "Priority 2: vector<int>\n";
			for (int i = 0; i < 3; i++) {
				clock_t start = clock();
				sort(vi[i].begin(), vi[i].end());
				clock_t end = clock();
				cout << "#" << i + 1 << ": " << double(end - start) / CLOCKS_PER_SEC << " sec." << endl;
			}
		}
		
		cout << endl;

		if (typeid(class list<int, class allocator<int> >[3]) == typeid(li)) {
			cout << "Priority 2: list<int>\n";
			for (int i = 0; i < 3; i++) {
				clock_t start = clock();
				li[i].sort();
				clock_t end = clock();
				cout << "#" << i + 1 << ": " << double(end - start) / CLOCKS_PER_SEC << " sec." << endl;
			}
		}
				
		cout << "\n\n\n";
	}

	{
		cout << "Multilevel feedback queue sheduling:\n";

		list<int> lim[5];
		for (int i = 0; i < 10000; i++) {
			lim[0].push_back(0 + rand() % 100);
			lim[1].push_back(0 + rand() % 100);
			lim[2].push_back(0 + rand() % 100);
			lim[3].push_back(0 + rand() % 100);
			lim[4].push_back(0 + rand() % 100);
		}

		clock_t time0 = 0.3 * CLOCKS_PER_SEC;
		clock_t time1 = 0.4 * CLOCKS_PER_SEC;
		clock_t time2 = 0.5 * CLOCKS_PER_SEC;
		cout << "Time for one project: \n#1: " << double(time0) / CLOCKS_PER_SEC << endl 
			<< "#2: " << double(time1) / CLOCKS_PER_SEC << endl 
			<< "#3: " << double(time2) / CLOCKS_PER_SEC << endl;

		vector<list<int> > q0;
		vector<list<int> > q1;
		vector<list<int> > q2;
			   
		double t = 0.0;

		for (int i = 0; i < 5; i++) {
			clock_t start = clock();
			while (clock() - start < time0) {
				clock_t s = clock();
				lim[i].sort();
				clock_t end = clock();
				t = double(end - s) / CLOCKS_PER_SEC;
			}

			if (t < 0.3) {
				q0.push_back(lim[i]);
				continue;
			}

			if (t > 0.3) {
				q1.push_back(lim[i]);
				continue;
			}
				
			if (t > 0.4) {
				q2.push_back(lim[i]);
				continue;
			}

			t = 0.0;
		}

		cout << "Time 1:";
		if (q0.size() == 0) cout << "null";
		cout << endl;
		for (int i = 0; i < q0.size(); i++) {
			clock_t s = clock();
			q0[i].sort();
			clock_t end = clock();
			t = double(end - s) / CLOCKS_PER_SEC;
			cout << "#" << i + 1 << ": " << t << " sec." << endl;
		}

		cout << "Time 2:";
		if (q1.size() == 0) cout << "null";
		cout << endl;
		for (int i = 0; i < q1.size(); i++) {
			clock_t s = clock();
			q1[i].sort();
			clock_t end = clock();
			t = double(end - s) / CLOCKS_PER_SEC;
			cout << "#" << i + 1 << ": " << t << " sec." << endl;
		}

		cout << "Time 3:";
		if (q2.size() == 0) cout << "null";
		cout << endl;
		for (int i = 0; i < q2.size(); i++) {
			clock_t s = clock();
			q2[i].sort();
			clock_t end = clock();
			t = double(end - s) / CLOCKS_PER_SEC;
			cout << "#" << i + 1 << ": " << t << " sec." << endl;
		}

		cout << "\n\n";
	}
}

