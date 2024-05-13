#include <iostream>

using namespace std;

int main() {
  int N;
  int day = 0;
  int days = 0;
  int month = 0;
  int year = 0;
  cin >> N;
  
  for(int i = 0; i < N; i++)
  {
      day++;
      days++;
      if(day == 30)
      {
         month++;
         day = 0;
         if(month == 12)
            month = 0;
      }
      if(days == 365)
      {
      year++;
      days = 0;
      day = 0;
      }
  }
  cout << year << " ano(s)\n";
  cout << month << " mes(es)\n";
  cout << day << " dia(s)\n";
}