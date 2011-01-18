import matplotlib.pyplot as plt
from random import random
import timeit
import cProfile

def bubble(unordered):
    """Bubble sort
    
    Takes an iterable and returns a list"""
    #compar = 0
    sorting=list(unordered)
    for i in range(len(sorting)):
        swapped=False
        for j in range(len(sorting)-1-i):
            if sorting[j]>sorting[j+1]:
                sorting[j],sorting[j+1]=sorting[j+1],sorting[j] 
                swapped=True
            #compar+=1
        if (not swapped):break
    #print("bubble= ",#compar)
    return sorting

def insertion(unordered):
    """insertion sort
    Takes an iterable and returns a list"""
    #compar = 0
    sorting=list(unordered)
    for i in range(len(sorting)):
        temp = sorting[i]
        j = i-1
        while (j >= 0 and sorting[j]>temp):
            sorting[j+1]=sorting[j]
            j -= 1
            #compar += 1
        sorting[j+1]=temp
    #print("insertion= {} #comparaciones",compar)
    return sorting

def selection(unordered):
    """selection sort
    Takes an iterable and returns a list"""
    #compar = 0
    sorting=list(unordered)
    for i in range(len(sorting)):
        temp = sorting[i]
        pos = i
        for j in range(i,len(sorting)):
            if (temp > sorting[j]):
                temp = sorting[j]
                pos = j
            #compar +=1
        sorting[pos] = sorting[i]
        sorting[i] = temp
    #print("selection= {} #comparaciones",compar)
    return sorting

def mergesort(sorting):
    """merge sort"""
    def merge(list1, list2) :
        size1, size2 = len(list1), len(list2)
        psorting=[]
        j, k=0, 0
        for i in range(size1*2):
            if (list1[j] > list2[k]):
                psorting.append(list2[k])
                k += 1
                if (k==size2):
                    psorting.extend(list1[j:])
                    j = -1
                    break
            else:
                psorting.append(list1[j])
                j += 1
                if (j==size1):
                    psorting.extend(list2[k:])
                    k = -1
                    break
        if(j == size1-1):psorting.append(list1[j])
        if(k == size2-1):psorting.append(list2[k])
        return psorting
    size =len(sorting)
    if (size >1):
        return merge(mergesort(sorting[:size//2]),mergesort(sorting[size//2:]))
    else:
        return sorting

def quicksort(unordered):
    def qsort(sorting, left, right):
        if (right - left < 1): return 
        pivot = (sorting[left] + sorting[right])/2
        i, j=left, right
        while(True):
            while(sorting[i] <= pivot): i += 1
            while(sorting[j] > pivot): j -= 1
            if (i<j):
                sorting[i], sorting[j] = sorting[j], sorting[i]
            else:
                qsort(sorting, left, j)
                qsort(sorting, i, right)
                break

    sorting = list(unordered)
    left, right = 0, len(sorting)-1
    qsort(sorting, left, right)
    return sorting


def performance(functions,valueslist,plot=True):
    times = [[] for function in functions]
    timers = [timeit.Timer(lambda : functions[i](test)) for i,val in enumerate(functions)]
    for j in valueslist:
        test = [random() for val in  range(j)]
        #test = sorted(test)
        for i, val in enumerate(functions):
            times[i].append(min(timers[i].repeat(3,1)))
    print("longest list\nfunction items secs")
    for i,function in enumerate(functions):
        print(function.__name__,valueslist[-1],times[i][-1])
    style = ['r*-','b*-','g*-','y*-','c*-','m*-','k*-']
    lines=[plt.loglog(valueslist,times[i],style[i % 8]) for i,val in enumerate(functions)]
    plt.plot([0,0],[0,times[0][-1]],[0,valueslist[-1]],[0,0]) #axis
    plt.figlegend(lines,[function.__name__ for function in functions],'upper right')
    if (plot): plt.show()
    #cProfile.run('sorted(test)')

def ftest(test,testprint=False):
    #print(bubble(test) == sorted(test))
    #print(insertion(test) == sorted(test))
    #print(selection(test) == sorted(test))
    #print(mergesort(test) == sorted(test))
    print(quicksort(test) == sorted(test))
    if (testprint) : print(quicksort(test));print(sorted(test))
    
test = [random() for val in  range(1000)]
test = sorted( test)
ftest([3,5,2,1,7])
ftest([5])
ftest(test)
performance([quicksort, mergesort, sorted],[2**x for x in range(5,17)])
