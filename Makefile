FLAGS =
fundido: practica2.c fundido.o
	gcc $(FLAGS) practica2.c fundido.o -o practica2
fundido.o: fundido.asm
	nasm $(FLAGS) -f elf fundido.asm
clean :
	-rm -f fundido.o practica2 fundido.bmp fundidoc.bmp
