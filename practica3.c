#include <math.h>
#include <sys/time.h>
#include <stdlib.h>
#include <stdio.h>
#define FALSE 0
#define TRUE 1

int dftc(double *, double *, double *, double *, double *, double *);
int matrizdft(double *,double *, int);
int imprime(double *, double *,int , int);

main(){

    int tam = 4;
    double *xr, *xi;
    double *matrizr, *matrizi;
    double *rr, *ri;
    //double prueba[3][3] = {{1,2,3},{4,5,6},{7,8,9}};
    //matrizr = prueba[0];
    matrizr = (double *)malloc(tam*tam*sizeof(double));
    matrizi = (double *)malloc(tam*tam*sizeof(double));
    rr = (double *)malloc(tam*sizeof(double));
    ri = (double *)malloc(tam*sizeof(double));
    matrizdft(matrizr, matrizi, tam);
    dft(xr, xi, matrizr, matrizi, rr, ri);
    imprime(matrizr, matrizr, tam, FALSE);
    free(matrizr);
    free(matrizi);
    free(rr);
    free(ri);
    return 0;
}

int dftc(double *xr, double *xi, double *matrizr, double *matrizi, double *rr, double *ri) {
//calcula la transformada discreta de fourier de un vector complejo

}

int matrizdft(double *matrizr,double *matrizi, int n){
//genera una matriz dft de tamanno n
    int i, j, indice;
    double pi2divn =-M_PI * 2 / n;
    for (i=0, indice = 0; i<n; i++) {
	for (j=0; j<n; j++){
	    *(matrizr+indice+j) = cos(pi2divn*i*j);
	    *(matrizi+indice+j) = sin(pi2divn*i*j);
	}
	indice += n ;
    }
}

int imprime(double *matrizr, double *matrizi, int n, int v){
//imprime matrices de tamanno n, si v true imprime vector
    int i, j, indice; 

    for (i=0, indice = 0; i<n; i++) {
	for (j=0; j<n; j++)
	    printf("% 2.2f % 2.2fi  ",*(matrizr+indice+j), *(matrizi+indice+j));
	printf("\n");
	indice += n ;
	if (v) break;
    }
}
