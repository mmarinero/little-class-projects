#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>
#include <errno.h>
#include <sys/time.h>

#define TAMANNO 512

int reconstruir (int nprocesos, char *prefijo);
int reparto (int *finicio, int *ffin,int nprocesos, int proceso);

main(int argc, char *argv[]) {
//multiplica matrices de forma concurrente usando subproducto
char prefijo[256];
int nprocesos; //numero de procesos concurrentes subproducto
int resto; //filas sobrantes en el reparto de procesos
register int i; //contador crear procesos 
int finicio,ffin; //filas de subproducto
char str_finicio [256],str_ffin [256]; //argumetnos fila de subproducto
pid_t  pid; //diferenciar procesos hijos de proceso padre

//variables medir tiempo
struct timeval tiempo;
struct timezone tz;
unsigned long inicio, fin;

//tratamiento errores en argumentos
if (argc != 3) {
  fprintf(stderr, "Usar: producto fichero numero_de_procesos\n");
  exit(-1);
}
//conversion y validacion de argumento
nprocesos = atoi(argv[2]);
if (nprocesos < 1 || nprocesos > TAMANNO) {
  fprintf(stderr, "numero de procesos erroneo\n");
  exit(-1);
}

// medir tiempo: instante inicial
gettimeofday(&tiempo, &tz);
inicio = tiempo.tv_sec * 1000000 + tiempo.tv_usec;

//creación de procesos subproducto
for (i=1; i<=nprocesos; i++) {
  if ((pid = fork ()) == -1 )
    fprintf(stderr, "error crear proceso %ld, con padre %ld",
          (long)getpid(), (long)getppid());
  if (pid == 0) {
    //procesos hijo
    //repartir filas
    reparto (&finicio, &ffin, nprocesos, i);

    //convertir argumentos en cadenas
    sprintf(str_finicio, "%d",finicio);
    sprintf(str_ffin,"%d",ffin);
    
    //mensaje lanzamiento subproducto
    printf("subproducto %s %d %d\n", argv[1], finicio, ffin);
    if (execl("subproducto","subproducto", argv[1],
       str_finicio, str_ffin, NULL ) < 0) {
      perror("Fallo en la ejecución de execl.");
      exit(-1);
    }
  }
}
printf("procesos  subproducto lanzados %d\n",i - 1);

//i = nprocesos+1 debido a la ultima iteración del bucle anterior
for (i--;i >= 0;i--) 
wait(0);
reconstruir(nprocesos, argv[1]);

// Medir tiempo: instante final
gettimeofday(&tiempo, &tz);
fin = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
printf("Segundos empleados para el calculo: %f\n",
      (float) (fin-inicio)/1000000.0);
}//main

int reparto (int *finicio, int *ffin,int nprocesos, int proceso) {
// devuelve ffinicio y ffin para el proceso del argumento 4

//calculo con numero de procesos no divisibles
if (TAMANNO % nprocesos >= proceso) {
  //se suma 1 por el resto y se resta 1 por el bucle quedando ffin = 1+i-1
  *ffin = proceso;
  *finicio = proceso - 1;
}
else {
  *ffin = TAMANNO % nprocesos;
  *finicio = TAMANNO % nprocesos;
}

//calculo de filas
*finicio += ((proceso-1)*(TAMANNO/nprocesos));
*ffin += ((proceso)*(TAMANNO/nprocesos))-1;
}//reparto

int reconstruir (int nprocesos, char *prefijo) {
//escribe fichero resultado a partir de los creados por subproducto
//y elimina los estos ficheros
int i,j;
int finicio, ffin; //para obtener nombres de ficheros
float temp[TAMANNO]; //temporal para leer-escribir
char str_subp[256]; //nombre fichero subproceso
char str_prod[256]; //nombre fichero resultado
FILE *lector; //fichero para leer subproductos
FILE *escritor; //fichero resultado
pid_t  pid;

//abrir fichero resultado
sprintf(str_prod,"%sProd.flt",prefijo);
escritor = fopen(str_prod, "w");
if (escritor == NULL) {
  perror("Fichero resultado para escribir");
    exit(-1);
}

for (i = 1;i <= nprocesos; i++) {
  //construccion de nombres
  reparto (&finicio, &ffin, nprocesos, i);
  sprintf (str_subp,"%s-%d-%d.flt", prefijo, finicio, ffin);
  
  //abrir fichero lectura
  lector = fopen(str_subp, "r");
  if (lector == NULL) {
    perror("Fichero creado por subproducto para leer");
     exit(-1);
  }
  
  //escribir datos en fichero final
  printf("Fichero fuente: %s\n", str_subp);
  for (j=0;j< (ffin - finicio + 1) ;j++) {
    fread(&temp, sizeof(float), TAMANNO, lector);
    fwrite(&temp, sizeof(float), TAMANNO, escritor);
  }
  fclose(lector);

  //borrar archivo fuente
  if ((pid = fork ()) == -1 )
    fprintf(stderr, "error crear proceso %ld, con padre %ld",
	  (long)getpid(), (long)getppid());
  if (pid == 0)
    if (execl("/bin/rm", "rm" ,str_subp ,NULL) < 0) {
      perror("Fallo en la ejecución de execl.");
      exit(-1);
    }
}
fclose (escritor);
}//reconstruir
