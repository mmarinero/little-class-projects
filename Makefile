fundido: main.c fundido.o
	gcc -g main.c fundido.o -o fundido
fundido.o: fundido.asm
	nasm -g -f elf fundido.asm


clean :
	rm fundido.o fundido
