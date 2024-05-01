#include <iostream>

using namespace std;

int main() {
   int M, A, B;
   cin >> M >> A >> B;
   int X = M - (A + B);
    if(A > X)
    X = A;
    if(B > X)
    X = B;
   cout << X;
}