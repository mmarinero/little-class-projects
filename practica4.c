#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#define pi 3.1415926535897932384626433832795029L

main()
{

double resultado;

//printf("Introduzca el primer numero:");

char *pidea="Introduzca el primer numero: ";
	__asm__ __volatile__("	movl	$4,%%eax\n\
				movl	$0,%%ebx\n\
				movl	%0, %%ecx\n\
				movl	$29,%%edx\n\
				int	$0x80" : : "g"(pidea) );
//scanf("%d",&a);
//http://www.elrincondelc.com/nuevorincon/foros/viewtopic.php?t=15394&sid=b94b07cf59fa2cff3d936f93607c9032

int y, numa=0 ;
   __asm__("movl $3, %%eax\n\t"
          	 "movl $0, %%ebx\n\t"
          	 "leal %1, %%ecx\n\t"
          	 "movl $4, %%edx\n\t"
          	 "int $0x80\n\t"
          	 "movl %1, %%eax\n\t"
           	: "=r"(numa)
           	:"m"(y));

int a;
a=atoi((char*) &numa);

//printf("\nIntroduzca el segundo numero:");

char *pideb="\nIntroduzca el segundo numero: ";
	__asm__("	movl	$4,%%eax\n\
				movl	$0,%%ebx\n\
				movl	%0, %%ecx\n\
				movl	$31,%%edx\n\
				int	$0x80" : : "g"(pideb) );

//scanf("%d",&b);

int x, numb=0 ;
   __asm__ ("movl $3, %%eax\n\t"
          	 "movl $0, %%ebx\n\t"
          	 "leal %1, %%ecx\n\t"
          	 "movl $4, %%edx\n\t"
          	 "int $0x80\n\t"
          	 "movl %1, %%eax\n\t"
           	: "=r"(numb)
           	:"m"(x));

int b;
b=atoi((char*) &numb);





char *muestraResultado="\nEl resultado de la operacion es: ";
	__asm__("	movl	$4,%%eax\n\
				movl	$0,%%ebx\n\
				movl	%0, %%ecx\n\
				movl	$34,%%edx\n\
				int	$0x80" : : "g"(muestraResultado) );
printf("%d %d %f\n", a, b, sqrt(b));
resultado=((2*pi*a)/sqrt(b));

char res[100]="";
sprintf(res,"%.6f\n",resultado);
printf("%.6f\n",resultado);

	__asm__("	movl	$4,%%eax\n\
				movl	$0,%%ebx\n\
				movl	%0, %%ecx\n\
				movl	$100,%%edx\n\
				int	$0x80" : : "g"(res) );

}
