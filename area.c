#include <math.h>
#include <stdio.h>


main ()
{
    double a, b, c, s, area;
    int x, y, z;

    /*x = scanf("%lf",&a);
    y = scanf("%lf",&b);
    z = scanf("%lf",&c);*/
    x=scanf("%lf%lf%lf", &a, &b, &c);

    s = (a+b+c)/2;
    area = sqrt(s*(s-a)*(s-b)*(s-c));
    /*printf("ret scanf: %d, %d, %d\n",x, y, z);*/
    printf("ret scanf: %d\n",x);
    printf("Area: %lf\nSemiperimetro: %lf\n", area, s);
}
