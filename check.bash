#!/bin/bash

for vfundido in `seq 0 255`
do
    ./fundido <<<`echo $vfundido` >/dev/null
    if ! diff fundido.bmp fundidoc.bmp; then echo "error con vfundido: $vfundido"; fi
done
