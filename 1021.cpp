#include <iostream>

using namespace std;

int main() {
    double r;
    cin >> r;
    r += 0.001;

    double cem = 0;
    double cinquenta = 0;
    double vinte = 0;
    double dez = 0;
    double cinco = 0;
    double dois = 0;
    double um = 0;
    double ccents = 0;
    double vcents = 0;
    double dcents = 0;
    double cincents = 0;
    double umcents = 0;

    while(r > 0)
    {
      if(r >= 100)
      {
         cem++;
         r -= 100;
      }
      else if(r >= 50)
      {
        cinquenta++;
        r -= 50;
      }
      else if(r >= 20)
      {
        vinte++;
        r -= 20;
      }
      else if(r >= 10)
      {
        dez++;
        r -= 10;
      }
      else if(r >= 5)
      {
        cinco++;
        r -= 5;
      }
      else if(r >= 2)
      {
        dois++;
        r -= 2;
      }
      else if(r >= 1)
      {
        um++;
        r -= 1;
      }
      else if(r >= 0.5)
      {
        ccents++;
        r -= 0.5;
      }
      else if(r >= 0.25)
      {
        vcents++;
        r -= 0.25;
      }
      else if(r >= 0.1)
      {
        dcents++;
        r -= 0.1;
      }
      else if(r >= 0.05)
      {
        cincents++;
        r -= 0.05;
      }
      else if(r >= 0.01)
      {
        umcents++;
        r -= 0.01;
      }
    }
    cout << "NOTAS:" << endl;
    cout << cem << " nota(s) de R$ 100.00" << endl;
    cout << cinquenta << " nota(s) de R$ 50.00" << endl;
    cout << vinte << " nota(s) de R$ 20.00" << endl;
    cout << dez << " nota(s) de R$ 10.00" << endl;
    cout << cinco << " nota(s) de R$ 5.00" << endl;
    cout << dois << " nota(s) de R$ 2.00" << endl;

    cout << "MOEDAS:" << endl;
    cout << um << " moeda(s) de R$ 1.00"  << endl;
    cout << ccents << " moeda(s) de R$ 0.50" << endl;
    cout << vcents << " moeda(s) de R$ 0.25" << endl;
    cout << dcents << " moeda(s) de R$ 0.10" << endl;
    cout << cincents << " moeda(s) de R$ 0.05" << endl;
    cout << umcents << " moeda(s) de R$ 0.01" << endl;
 
  }     