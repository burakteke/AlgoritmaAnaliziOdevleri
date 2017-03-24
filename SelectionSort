import time
import random 

alist = []
for i in range(10000):
        alist.append(randint(0,100))

def selectionSort(alist):
   for fillslot in range(len(alist)-1,0,-1):
       positionOfMax=0
       for location in range(1,fillslot+1):
           if alist[location]>alist[positionOfMax]:
               positionOfMax = location

       temp = alist[fillslot]
       alist[fillslot] = alist[positionOfMax]
       alist[positionOfMax] = temp



baslama = time.time()
selectionSort(alist)
bitis = time.time()
print(alist) 
print "Toplam zaman  "  (bitis-baslama)
