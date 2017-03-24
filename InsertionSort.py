import random 
import time

alist = []
for i in range(10000):
        alist.append(randint(0,100))
        
def insertionSort(alist):
   for index in range(1,len(alist)):

     currentvalue = alist[index]
     position = index

     while position>0 and alist[position-1]>currentvalue:
         alist[position]=alist[position-1]
         position = position-1

     alist[position]=currentvalue


baslama = time.time()
insertionSort(alist)
bitis = time.time()
print(alist) 
print "Toplam zaman  "  (bitis-baslama)
