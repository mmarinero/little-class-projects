#include <stdio.h>
#include <string.h>
#define leenum(dest, bucle, salir) \
	__asm__ ("movl	$4,%%eax\n\t\
        movl     $3,%%eax\n\t\
        movl     $0,%%ebx\n\t\
        leal     (%1),%%ecx\n\t\
        movl     $20,%%edx #long maxima\n\t\
        int     $0x80\n\t\
\n\t\
        movl     %%eax,%%ecx #indice bucle +1 por el fin de linea\n\t\
        decl     %%ecx\n\t\
        xorl     %%edx,%%edx\n\t\
        xorl    %%eax,%%eax\n\t\
        lea     (%1),%%esi\n\t\
        cld #esi se utilizara para recorrer la cadena\n\t\
        cmpb     $'-',(%1)#comprobar negativo\n\t\
        jnz     " bucle"\n\t" \
        "incl     %%esi\n\t\
        decl     %%ecx\n\t"\
bucle":\n\t" \
        "imull    $10,%%edx #el resultado se almacena en edx:eax pero solo se devolvera eax\n\t\
        subb     $'0',(%%esi)    #transforma numero ascii en binario\n\t\
        lodsb #no hay que extender el signo a eax, siempre positivo\n\t\
        addl     %%eax,%%edx\n\t\
        loop    " bucle"\n\t" \
"\n\t\
        movl     %%edx,%%eax\n\t\
        cmp     $'-', (%1) #negar resultado si es negativo\n\t\
        jnz     " salir "\n\t"\
        "neg     %%eax\n\t"\
salir":\n\t" \
        "mov     %%eax, %0 #se guarda para que no se pierda con popa\n\t"\
	:"=m" (dest) : "mr"(cadena):"eax", "ecx", "edx", "ebx", "esi" )

#define icadena(origen, long) \
	__asm__("\
	movl     $4,%%eax\n\t\
        movl     $1,%%ebx\n\t\
        movl     %0,%%ecx\n\t\
        int     $0x80\n\t"\
	::"r" (origen), "d" (long):"eax", "ecx", "ebx")

#define pi 3.1415926535897932384626433832795029L

main() {
int a, b;
double resultado;

char cadena[]="Introduzca el numero a: ";
char cadena2[] = "Introduzca el numero b: ";
char cadena3[50];

icadena(cadena, strlen(cadena));
leenum(a, "bucle", "salir");
icadena(cadena2, strlen(cadena));
leenum(b,"bucle1", "salir1");

__asm__("\
	finit\n\t\
	fldpi\n\t\
	fild %1\n\t\
	fmulp %%st(1) #st0 = pi * a\n\t\
	fild %2\n\t\
	fsqrt #st0 = sqrt(b)\n\t\
	fdivrp #st0 = pi*a/sqrt(b)\n\t\
	fld %%st(0) #st0 = st1\n\t\
	faddp #st0 = 2* pi * a/sqrt(b)\n\t\
	"\
	:"=t" (resultado): "m" (a), "m" (b));

sprintf(cadena3,"Resultado: %f\n",resultado);
icadena(cadena3, strlen(cadena3));
}
