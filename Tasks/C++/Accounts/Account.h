#pragma once
#include <iostream>
#include <sstream>
#include <list>
#include <vector>
#include <memory>
#include <algorithm>
#include <string>
#include <fstream>

using namespace std;

class Account
{
private:
	string surname;
	double sum;
public:
	Account() : surname('\0'), sum(0.0) {}
	Account(string _surname, double _sum) : surname(_surname), sum(_sum) {}
	string GetSurname()const { return surname; }
	double GetSum()const { return sum; }
	virtual ~Account() = 0;
	virtual void Print(ostream & os);
};

class AccountGas : public Account 
{
private:
	int persons;
public:
	AccountGas() : Account(), persons(0) {}
	AccountGas(string _surname, double _sum, int _persons) : Account(_surname, _sum), persons(_persons) {}
	int GetPersons()const { return persons; }
	~AccountGas() { }
	virtual void Print(ostream & os);
};

class AccountWater : public Account
{
private:
	double impressions;
	double volume;
public:
	AccountWater() : Account(), impressions(0.0), volume(0.0) {}
	AccountWater(string _surname, double _sum, double _impressions, double _volume) : 
		Account(_surname, _sum), impressions(_impressions), volume(_volume) {}
	double GetImpressions()const { return impressions; }
	double GetVolume()const { return volume; }
	~AccountWater() {}
	virtual void Print(ostream & os);
};