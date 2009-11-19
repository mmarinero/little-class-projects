#!/bin/bash
for vfundido in `seq 0 255`
do
    ./fundido <<<`echo $vfundido` | egrep -o "[0-9]+$" >>tiempos.txt 
    if ! diff fundido.bmp fundidoc.bmp;
	then echo "error con vfundido: $vfundido";
    fi
done
./sumatiempo.py
rm tiempos.txt
