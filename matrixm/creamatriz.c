
#include <stdio.h>
#include <errno.h>



// Tamaño por defecto de la matriz
#define TAMANNO 512

// Primer y último valor a almacenar en las dos matrices
// que se van a crear
#define INI 0.0
#define FIN 1.0

#define IMPRIMEMATRIZ 'N'


//
// usar: creamatriz fichero [tamanno]
//
// Crea los ficheros <fichero1.flt> y <fichero2.flt> con las dos
// matrices a multiplicar.
// Si se indica el tamanno, se usa en lugar de 1024x1024
//
main(int argc, char *argv[])
{

int tamanno = TAMANNO;
FILE *fp1, *fp2;
char nombre1[256], nombre2[256];
int i, j, k;
float valor = INI;
float paso;


if (argc < 2) {
  fprintf(stderr, "Usar: creamatriz fichero [tamanno]\n");
  exit(-1);
}

sprintf(nombre1, "%s1.flt", argv[1]);
sprintf(nombre2, "%s2.flt", argv[1]);

if (argc == 3) 
  tamanno =atoi(argv[2]);

paso = (FIN-INI)/(2.0*(float)tamanno*(float)tamanno);

printf("Se crearán los ficheros %s y %s con tamaño %dx%d\n", nombre1, nombre2, tamanno, tamanno);

fp1 = fopen(nombre1, "w");
if (fp1 == NULL) {
  perror("Fichero 1 para escribir");
  exit(-1);
}

fp2 = fopen(nombre2, "w");
if (fp2 == NULL) {
  perror("Fichero 2 para escribir");
  exit(-1);
}


for (i=0; i<tamanno; i++)
  for (j=0; j<tamanno; j++) {
    if (j == i) valor = 1.0; else valor = 0.0;
    fwrite(&valor, sizeof(valor), 1, fp1);
  }

valor = 0;

for (i=0; i<tamanno; i++)
  for (j=0; j<tamanno; j++) {
    fwrite(&valor, sizeof(valor), 1, fp2);
    valor = valor + paso;
  }


fclose(fp1);
fclose(fp2);

printf("Matrices creadas.");

if (IMPRIMEMATRIZ != 'S') {
  printf("\n");
  exit(0);
}


printf("Son estas:\n");

fp1 = fopen(nombre1, "r");
if (fp1 == NULL) {
  perror("Fichero 1 para leer");
  exit(-1);
}

for (i=0; i<tamanno; i++) {
  for (j=0; j<tamanno; j++) {
    fread(&valor, sizeof(valor), 1, fp1);
    printf("%.4f ", valor);
  }
  printf("\n");
}

printf("\n\n*\n\n");
fclose(fp1);

fp2 = fopen(nombre2, "r");
if (fp2 == NULL) {
  perror("Fichero 2 para leer");
  exit(-1);
}

for (i=0; i<tamanno; i++) {
  for (j=0; j<tamanno; j++) {
    fread(&valor, sizeof(valor), 1, fp2);
    printf("%.4f ", valor);
  }
  printf("\n");
}



}
