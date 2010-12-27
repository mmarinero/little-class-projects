
#include <stdio.h>
#include <errno.h>


//tamaño matrices a multiplicar
#define TAMANNO 512

//matrices 

float m2 [TAMANNO][TAMANNO];
float m1 [TAMANNO][TAMANNO]; 

int multimatriz(char *nombref, int finicio, int ffin, FILE *resultado);
int cargam1(char *nombref,FILE *fmatriz);
int cargam2(char *nombref,FILE *fmatriz);

main(int argc, char *argv[]) {
//multiplicador de matrices desde dos ficheros binarios
char nombre1[256], nombre2 [256], nombre3 [256];
int finicio,ffin; //filas a multiplicar

//ficheros de matrices
FILE *fp1, *fp2, *fp3;

//tratamiento errores en argumentos
if (argc != 4) {
  fprintf(stderr, "Usar: subproducto fichero fila1 fila2\n");
  exit(-1);
}

//conversion de argumentos 
finicio = atoi(argv[2]);
ffin = atoi(argv[3]);

//validación de argumentos
if (finicio > ffin || finicio < 0 || ffin >= TAMANNO) {
 fprintf(stderr, "fila 1 y fila2 deben corresponder \
 con numeros de lineas existentes en la matriz\
 y fila 1 ser inferior o igual a fila 2\n");
  exit(-1);
}

//asignar nombres
sprintf(nombre1, "%s1.flt", argv[1]);
sprintf(nombre2, "%s2.flt", argv[1]);
sprintf(nombre3, "%s-%d-%d.flt",argv[1],finicio,ffin);

//cargar matrices en memoria
cargam1(nombre1,fp1);
cargam2(nombre2,fp2);

//multiplicar y escribir matriz resultado
multimatriz(nombre3,finicio,ffin,fp3);

}//main


int cargam2(char *nombref,FILE *fmatriz) {
//carga una matriz desde ficherousando una variable externa para almacenarla

register int i;

fmatriz = fopen(nombref, "r");
if (fmatriz == NULL) {
  perror("Fichero 2 para leer");
    exit(-1);
}

for (i=0;i<TAMANNO;i++)
  fread(m2[i], sizeof(float), TAMANNO, fmatriz);
fclose(fmatriz);
}//cargam2

int cargam1(char *nombref,FILE *fmatriz) {
//carga una matriz desde ficherousando una variable externa para almacenarla

register int i;

fmatriz = fopen(nombref, "r");
if (fmatriz == NULL) {
  perror("Fichero 1 para leer");
    exit(-1);
}

for (i=0;i<TAMANNO;i++)
  fread(m1[i], sizeof(float), TAMANNO, fmatriz);
fclose(fmatriz);
}//cargam1

int multimatriz(char *nombref, int finicio, int ffin, FILE *resultado) {
//multiplica dos matrices cargadas en memoria y escribe un fichero resultado

float temp;
register int i,j,k;

resultado = fopen(nombref, "w");
if (resultado == NULL) {
  perror("Fichero 3 para escribir");
  exit(-1);
}

for (i = 0;i <= (ffin - finicio);i++){
  for (j = 0;j<TAMANNO; j++){
    for (k = 0;k<TAMANNO; k++)
      temp += m1[finicio+i][k] * m2[k][j]; 
    fwrite(&temp, sizeof(float), 1, resultado);
    temp = 0.0;
  }
}
fclose(resultado);
}//multimatriz
