#include <math.h>
#include <sys/time.h>
#include <stdlib.h>
#include <stdio.h>
#define FALSE 0
#define PI  3.1415926535897932384626433832795029L
#define TRUE 1

int dftc(double *, double *, double *, double *, double *, double *, int);
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
    dftc(xr, xi, matrizr, matrizi, rr, ri, tam);
    imprime(matrizr, matrizi, tam, FALSE);
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
    int i, j, ind;
    double tempr, tempi;
    for (i=0, ind=0; i < n; i++, ind+=n) {
	for (j=0, tempr=0.0, tempi=0.0; j < n; j++){
	    tempr += *(matrizr+ind+j) * xr[j] - *(matrizi+ind+j) * xi[j];
	    tempi += *(matrizi+ind+j) * xr[j] + *(matrizr+ind+j) * xi[j];
	}
	rr[i] = tempr;
	ri[i] = tempi;
    }
}

int matrizdft(double *matrizr,double *matrizi, int n){
//genera una matriz dft de tamanno n
    int i, j, ind;
    double pi2divn =-PI * 2 / n;
    for (i=0, ind = 0; i<n; i++) {
	for (j=0; j<n; j++){
	    *(matrizr+ind+j) = cos(pi2divn*i*j);
	    *(matrizi+ind+j) = sin(pi2divn*i*j);
	}
	ind += n ;
    }
}

int imprime(double *matrizr, double *matrizi, int n, int v){
//imprime matrices de tamanno n, si v true imprime vector
    int i, j, ind; 

    for (i=0, ind = 0; i<n; i++) {
	for (j=0; j<n; j++)
	    printf("% 2.2e % 2.2ei  ",*(matrizr+ind+j), *(matrizi+ind+j));
	printf("\n");
	ind += n ;
	if (v) break;
    }
}
