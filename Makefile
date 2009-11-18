FLAGS = -g
fundido: main.c fundido.o
	gcc $(FLAGS) main.c fundido.o -o fundido
fundido.o: fundido.asm
	nasm $(FLAGS) -f elf fundido.asm
clean :
	-rm -f fundido.o fundido fundido.bmp fundidoc.bmp
