#include <iostream>

using namespace std;

int main()
{
  int a = 4 ;
int b = 12 ;

while (a != b){
    if (a > b) {
        a = a - b;
    }
    else{
        b = b - a;
    }
}

cout<<a;
    return 0;
}
