practica3 : practica3.c dft.o
	gcc $(FLAGS) -lm practica3.c dft.o -o practica3
dft.o: dft.asm
	nasm $(FLAGS) -f elf dft.asm
clean :
	-rm -f dft.o practica3
