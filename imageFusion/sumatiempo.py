#!/usr/bin/env python
flag = [1, 0]
mmx, c = (0.0, 0.0)
file = open(".tiempos.txt","r")
for line in file.readlines():
    c = c + int(line)*flag[0]
    mmx = mmx + int(line)*flag[1]
    flag.reverse()
print "t.m C:\t%f us\nt.m MMX\t%f us\nC/MMX\t%f" % (c/256, mmx/256, c/mmx)
