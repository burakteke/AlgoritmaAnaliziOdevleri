#include <cstdlib>
#include <iostream>

using namespace std;
int m=0;
long pow(long x,long n)
{
     m++;
     if(n==0) return 1;
     if(n==1) return x;
     if(n%2==0){
         return pow(x*x,n/2);
     }
     else{
         return pow(x*x,n/2) * x;
     }
}
int main(int argc, char *argv[])
{
    cout <<"taban";
    long t;
    cin >> t;
    cout <<"us";
    long u;
    cin >> u;
    long s;
    s=pow(t,u);
    cout << s << endl;
    cout << "adim sayisi:" << m <<endl;
    system("PAUSE");
    return EXIT_SUCCESS;
}
