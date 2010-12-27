
#include <stdio.h>
#include <errno.h>


//tamaño matrices a multiplicar
#define TAMANNO 3

//matrices 

float m2 [TAMANNO][TAMANNO];
float m1 [TAMANNO][TAMANNO]; 

int multimatriz(char *nombref, int finicio, int ffin, FILE *resultado);
int imprimeresultado (char *nombre3, FILE *resultado);
int cargam(char *nombref,FILE *fmatriz);
int imprimematriz ();

main(int argc, char *argv[])
{
char nombre1[256], nombre2 [256], nombre3 [256];
int finicio,ffin; //filas a multiplicar

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

//ficheros de matrices
FILE *fp1, *fp2, *fp3;

//leer y cargar matrices

//cargar matrices en memoria

cargam1(nombre1,fp1);
cargam2(nombre2,fp2);

//multiplicar y escribir matriz resultado

multimatriz(nombre3,finicio,ffin,fp3);

//imprime un fichero con una matriz (pruebas) 
imprimeresultado(nombre3,fp3);
//imprime una matriz cargada en memoria
imprimematriz ();

}//main


int cargam2(char *nombref,FILE *fmatriz)
{

fmatriz = fopen(nombref, "r");
if (fmatriz == NULL) {
  perror("Fichero 2 para leer");
    exit(-1);
}

register int i;

for (i=0;i<TAMANNO;i++)
  fread(m2[i], sizeof(float), TAMANNO, fmatriz);
fclose(fmatriz);
}//cargam2

int cargam1(char *nombref,FILE *fmatriz)
{

fmatriz = fopen(nombref, "r");
if (fmatriz == NULL) {
  perror("Fichero 1 para leer");
    exit(-1);
}

register int i;

for (i=0;i<TAMANNO;i++)
  fread(m1[i], sizeof(float), TAMANNO, fmatriz);
fclose(fmatriz);
}//cargam1


/*int cargamdin(char *nombref,FILE *fmatriz,int finicio, int ffin)
{
int i;
float temp;
fmatriz = fopen(nombref, "r");
if (fmatriz == NULL) {
  perror("Fichero 2 para leer");
  exit(-1);
}
m1 = malloc((ffin-finicio)*TAMANNO * sizeof (float));
for (i = 0;i<=(ffin-finicio);++i)
  fread(&m1[i][0],sizeof (float), TAMANNO, fmatriz);

}//cargamdin
*/


int multimatriz(char *nombref, int finicio, int ffin, FILE *resultado)
{
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

int imprimeresultado (char *nombre3, FILE *resultado)
{
float valor;
register int i,j;

resultado = fopen(nombre3, "r");
if (resultado == NULL) {
  perror("Fichero resultado no es accesible");
  exit(-1);
}
printf("matriz resultado \n");
for (i=0; i<TAMANNO; i++) {
  for (j=0; j<TAMANNO; j++) {
    fread(&valor, sizeof(valor), 1, resultado);
    printf("%.4f ", valor);
  }
  printf("\n");
}
fclose(resultado);
}
//prueba carga matriz
int imprimematriz ()
{
register int i,j;
printf("matrices en memoria \n");fflush(stdout);
for (i=0; i<TAMANNO; i++) {
  for (j=0; j<TAMANNO; j++) {
    printf("%.4f ",m1[i][j]);
    printf("%.4f    ",m2[i][j]);
  }
  printf("\n");
}
}//imprimematriz*/

