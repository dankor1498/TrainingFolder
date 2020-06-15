#pragma once
#include <iostream>
#include <algorithm>
#include <map>
#include <fstream>
#include <cctype>
#include <string>
#include <unordered_map>
#include <iomanip>

using namespace std;

typedef struct Ñoordinates
{
	int x;
	int y;
} xy;

const int alphabet_code[104] =
{
	86, 11, 12, 99, 24, 3, 10, 35, 1, 14, 25,
	48, 44, 75, 53, 78, 81, 5, 2, 55, 27, 66,
	101, 69, 8, 96, 23, 56, 89, 67, 41, 50,
	32, 91, 47, 38, 22, 73, 45, 4, 57, 37, 51,
	97, 65, 33, 72, 74, 77, 64, 62, 83, 95, 29,
	93, 85, 30, 68, 16, 102, 52, 17, 63, 87, 98,
	43, 58, 104, 21, 19, 40, 36, 103, 60, 88, 92,
	70, 61, 94, 100, 42, 79, 18, 90, 9, 6, 34,
	80, 59, 31, 7, 49, 84, 26, 20, 15, 28, 71,
	46, 13, 54, 39, 82, 76
};

const string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

struct KeyHasher {
	size_t operator()(const xy & c) const
	{
		return hash<int>()(c.x) + hash<int>()(c.y);
	}
};

bool operator==(const xy &n1, const xy &n2)
{
	return n1.x == n2.x && n1.y == n2.y;
}

bool operator<(const xy &n1, const xy &n2)
{
	return n1.x < n2.x && n1.y < n2.y;
}
