#include <math.h>
#include <sys/time.h>
#include <stdlib.h>
#include <stdio.h>
#define FALSE 0
#define PI  3.1415926535897932384626433832795029L
#define TRUE 1
#define TAMANO 1024
#define RANDOM 1

int dftc(double *, double *, double *, double *, double *, double *, int);
int dft(double *xr, double *xi, double *matrizr, double *matrizi, double *rr, double *ri, int tam) __attribute__((cdecl));
int matrizdft(double *,double *, int);
int imprime(double *, double *,int , int);

main(int argc, char *argv[]){
//calcula la transformada discreta de fourier
//con instrucciones en c y sse
//el tamano debe ser un numero par
//se permite pasar tamano como primer parametro o ser la constante
    int tam = TAMANO;
    if (argc > 1) tam = atoi(argv[1]);
    double *xr, *xi;
    double *matrizr, *matrizi;
    double *rr, *ri;
    double *rrc, *ric;
    //variables medir tiempo
    struct timeval tiempo;
    struct timezone tz;
    unsigned long inicio, fin;
    //reservar memoria alineada
    posix_memalign((void **)&matrizr, 16, tam*tam*sizeof(double));
    posix_memalign((void **)&matrizi, 16, tam*tam*sizeof(double));
    posix_memalign((void **)&xr, 16, tam*sizeof(double));
    posix_memalign((void **)&xi, 16, tam*sizeof(double));
    posix_memalign((void **)&rr, 16, tam*sizeof(double));
    posix_memalign((void **)&ri, 16, tam*sizeof(double));
    posix_memalign((void **)&rrc, 16, tam*sizeof(double));
    posix_memalign((void **)&ric, 16, tam*sizeof(double));

    //generar vectores si RANDOM = 1 aleatorios
    int i;
    gettimeofday(&tiempo, &tz);
    srand(tiempo.tv_usec);
    for (i = 0; i<tam; i++) {
	xr[i] = RANDOM ? rand(): i+1;
	xi[i] = RANDOM ? rand(): i+1;
    }
    //imprime(xr, xi, tam, TRUE); //imprime vector de entrada

    matrizdft(matrizr, matrizi, tam);
    //imprime(matrizr, matrizi, tam, FALSE); //imprime matriz dft

    //medir tiempo inicial
    gettimeofday(&tiempo, &tz);
    inicio = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    dftc(xr, xi, matrizr, matrizi, rrc, ric, tam);
    //medir tiempo final
    gettimeofday(&tiempo, &tz);
    fin = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    printf("Segundos para el calculo en C:     %f\n",
          (float) (fin-inicio)/1000000.0);
    //imprime(rrc, ric, tam, TRUE); //imprime vector resultado c

    //medir tiempo inicial
    gettimeofday(&tiempo, &tz);
    inicio = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    dft(xr, xi, matrizr, matrizi, rr, ri,tam);
    //medir tiempo final
    gettimeofday(&tiempo, &tz);
    fin = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    printf("Segundos para el calculo con SSE:  %f\n",
          (float) (fin-inicio)/1000000.0);
    //imprime(rr, ri, tam, TRUE); //imprime resultado vector sse

    //comprobar diferencia entre c y sse
    double errorAbsoluto = 0;
    for (i = 0; i<tam; i++) {
	rr[i] = fabs(rrc[i]-rr[i]);
	ri[i] = fabs(ric[i]-ri[i]);
	errorAbsoluto += rr[i] + ri[i];
    }
    //imprime(rr, ri, tam, TRUE); //imprime vector de diferencias
    //printf("\nDiferencia total resultados:\nabs(resultadoC-resultadoSSE) = %e\n", errorAbsoluto);

    free(matrizr);
    free(matrizi);
    free(xr);
    free(xi);
    free(rr);
    free(ri);
    free(rrc);
    free(ric);
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
    printf("\n");
}
