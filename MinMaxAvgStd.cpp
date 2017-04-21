#include <cstdlib>
#include <iostream>
#include<conio.h>
#include<cmath>
#define N 10


using namespace std;



void ortalamaBul(int arr[], int size) {
   int    i, sum = 0;       
             

   for (i = 0; i < size; ++i) {
      sum += arr[i];
   }

   double ort = double(sum) / size;
   cout << " ortalama:" << ort <<endl;
}

void minMaxBul(int arr[],int size)
{
    int min=arr[0];
    int max=0;
    for(int i=0;i<size;i++)
    {
        if(arr[i]>max) max=arr[i];
        if(arr[i]<min) min=arr[i];
    }
    cout << "min:" << min << endl << " max:" << max << endl;

}
void StandartSapma (int arr[],int size){
     
     float art,ss,toplam=0.0;
    for(int i=0;i<size;i++){
                     toplam+=arr[i];
    }
    art=toplam/size;
    cout<<"Toplam deger :"<<toplam<<endl;
    for(int i=0;i<size;i++)
            toplam+=pow((double)arr[i]-art,2.0);
            
    ss=sqrt(toplam/(size-1));
    cout<<"Standart sapma degeri:"<<ss<<endl;
    

}

                    
int main(int argc, char *argv[])
{
    int dizi[10]={5,1,6,4,12,9,2,8,15,10};
    ortalamaBul(dizi,10);
    minMaxBul(dizi,10);
    StandartSapma(dizi,10);
    
    
    system("PAUSE");
    return EXIT_SUCCESS;
}
