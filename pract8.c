#include <stdio.h>
#include <math.h>
#include <stdlib.h>

main ()
{
    double x, y;

    printf("Introduzca un numero en punto flotante\n");
    if (scanf("%lf",&x) != 1) {
	fprintf(stderr, "No se ha leido correctamente el numero\n");
	exit(-1);
    }
    y = expo(x);
    printf("10^%.6g = %.15g\n", x, y);
}
