#include <stdio.h>
#include <stdlib.h>

double expo(double) __attribute__((cdecl));

main ()
{
    double x, y;

    printf("Introduzca un numero en punto flotante\n");
    if (scanf("%lf",&x) != 1) {
	fprintf(stderr, "No se ha leido correctamente el numero\n");
	exit(-1);
    }
    y = expo(x);
    if (y == -1) {
	fprintf(stderr, "Se ha producido overflow o underflow\n");
	exit(-1);
    }
    printf("10^%.6g = %.15g\n", x, y);
}
