#!/usr/bin/env python
flag = [1, 0]
sse, c = (0.0, 0.0)
file = open(".tiempos.txt","r")
for line in file.readlines():
    c = c + float(line)*flag[0]
    sse = sse + float(line)*flag[1]
    flag.reverse()
print "t.m C:\t%f s\nt.m SSE\t%f s\nC/SSE\t%f" % (c/20, sse/20, c/sse)
