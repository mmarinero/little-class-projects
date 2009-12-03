#!/bin/bash
for tamano in `seq 0 20`
do
    ./practica3  | egrep -o "([0-9]|\.)+$" >>.tiempos.txt 
done
./sumatiempo.py
rm .tiempos.txt
