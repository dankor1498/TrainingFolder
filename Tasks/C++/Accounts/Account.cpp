#include "pch.h"
#include "Account.h"

void AccountGas::Print(ostream & os)
{
	Account::Print(os);
	os << " Прописаных: " << GetPersons() << endl;
}

void AccountWater::Print(ostream & os)
{
	Account::Print(os);
	os << " Последний показ: " << GetImpressions() << " Объем: " << GetVolume() << endl;
}

Account::~Account()
{
}

void Account::Print(ostream & os)
{
	os << "Фамилия: " << GetSurname() << " Сумма: " << GetSum();
}
