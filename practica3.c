#include <math.h>
#include <sys/time.h>
#include <stdlib.h>
#include <stdio.h>
#define FALSE 0
#define PI  3.1415926535897932384626433832795029L
#define TRUE 1

int dftc(double *, double *, double *, double *, double *, double *, int);
int dft(double *, double *, double *, double *, double *, double *, int) __attribute__((cdecl));
int matrizdft(double *,double *, int);
int imprime(double *, double *,int , int);

main(){

    int tam = 4;
    //double *xr, *xi;
    double xr[] = {1.0, 2.0, 3.0, 4.0};
    double xi[] = {0.0, 0.0, 0.0, 0.0};
    double *matrizr, *matrizi;
    double *rr, *ri;
    matrizr = (double *)malloc(tam*tam*sizeof(double));
    matrizi = (double *)malloc(tam*tam*sizeof(double));
    //xr = (double *)malloc(tam*sizeof(double));
    //xi = (double *)malloc(tam*sizeof(double));
    rr = (double *)malloc(tam*sizeof(double));
    ri = (double *)malloc(tam*sizeof(double));
    matrizdft(matrizr, matrizi, tam);
    //dftc(xr, xi, matrizr, matrizi, rr, ri, tam);
    printf("muere dentro\n"); fflush(stdout);
    dft(xr, xi, matrizr, matrizi, rr, ri,0); //tam/2);
    imprime(rr, ri, tam, TRUE);
    free(matrizr);
    free(matrizi);
    //free(xr);
    //free(xi);
    free(rr);
    free(ri);
    return 0;
}

int dftc(double *xr, double *xi, double *matrizr, double *matrizi, double *rr, double *ri, int n) {
//calcula la transformada discreta de fourier de un vector complejo
    int i, j;
    double tempr, tempi;
    for (i=0; i < n; i++, matrizr+=n, matrizi+=n) {
	for (j=0, tempr=0.0, tempi=0.0; j < n; j++){
	    tempr += *(matrizr+j) * xr[j] - *(matrizi+j) * xi[j];
	    tempi += *(matrizi+j) * xr[j] + *(matrizr+j) * xi[j];
	}
	rr[i] = tempr;
	ri[i] = tempi;
    }
}

int matrizdft(double *matrizr,double *matrizi, int n){
//genera una matriz dft de tamanno n
    int i, j;
    double pi2divn =-PI * 2 / n;
    for (i=0; i<n; i++, matrizr+=n, matrizi+=n) {
	for (j=0; j<n; j++){
	    *(matrizr+j) = cos(pi2divn*i*j);
	    *(matrizi+j) = sin(pi2divn*i*j);
	}
    }
}

int imprime(double *matrizr, double *matrizi, int n, int v){
//imprime matrices de tamanno n, si v true imprime vector
    int i, j; 
    for (i=0; i<n; i++, matrizr+=n, matrizi+=n) {
	for (j=0; j<n; j++)
	    printf("% 2.2e % 2.2ei  ",*(matrizr+j), *(matrizi+j));
	printf("\n");
	if (v) break;
    }
}
