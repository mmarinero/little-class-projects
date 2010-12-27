#include <stdio.h>
#include <stdlib.h>
#include <sys/time.h>

#define LONGITUD ((header->bp/8)*header->width*header->height)
#define LONGITUD1 ((header1->bp/8)*header1->width*header1->height)
#define LONGITUD2 ((header2->bp/8)*header2->width*header2->height)

typedef unsigned char uchar;
typedef struct {
    int dataOffset;
    int width;
    int height;
    int bp;
} tHeader;

tHeader *leerHeader(FILE *image);
uchar *cargar(FILE *fm1, tHeader *header);
uchar *fundidoc(int longitud, uchar *m1, uchar *m2, int vFundido); 
uchar *fundido(int longDiv4, uchar *m1, uchar *m2, int vFundido) __attribute__((cdecl));
void escribirResultado(uchar *matriz, tHeader *header, FILE *image, char *nombre);

int main() {
//Programa para el fundido de dos imagenes de igual formato de 24 bits o 32 bits
//no soporta imagenes comprimidas

    char *image1 = "A.bmp";
    char *image2 = "B.bmp";
    char *resultado = "fundido.bmp";
    char *resultadoc = "fundidoc.bmp";
    FILE *fm1;
    FILE *fm2;
    int vFundido;
    tHeader *header1;
    tHeader *header2;
    //matrices
    uchar *m1;
    uchar *m2;
    uchar *mResultado;
    uchar *mResultadoc;
    //variables medir tiempo
    struct timeval tiempo;
    struct timezone tz;
    unsigned long inicio, fin;

    printf("Introduzca un valor de fundido [0-255]\n");
    scanf("%i", &vFundido);
    if(vFundido < 0 || vFundido > 0xFF) {
        fprintf(stderr, "Valor de fundido erroneo\n");
        exit(-1);
    }
    //leer imagen 1
    fm1 = fopen(image1, "rb");
    if (fm1 == NULL) {
	fprintf(stderr, "Error al abrir el fichero %s\n", image1);
	exit(-1);
    }
    header1 = leerHeader(fm1);
    m1 = cargar(fm1, header1);
    fclose(fm1);
    free(header1);

    //leer imagen 2
    fm2 = fopen(image2, "rb");
    if (fm2 == NULL) {
	fprintf(stderr, "Error al abrir el fichero %s\n", image2);
	exit(-1);
    }
    header2 = leerHeader(fm2);
    m2 = cargar(fm2, header2);

    //ejecutar c
    //medir tiempo inicial
    gettimeofday(&tiempo, &tz);
    inicio = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    //fundido
    mResultadoc = fundidoc(LONGITUD1, m1, m2, vFundido);
    //medir tiempo final
    gettimeofday(&tiempo, &tz);
    fin = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    printf("Microsegundos calculando en C:  %ld\n", (fin-inicio));
    escribirResultado(mResultadoc, header2, fm2, resultadoc);
    free(mResultadoc);

    //ejecutar asm mmx
    gettimeofday(&tiempo, &tz);
    inicio = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    //fundido
    mResultado = fundido((LONGITUD1/4)+1, m1, m2, vFundido);
    //medir tiempo final
    gettimeofday(&tiempo, &tz);
    fin = tiempo.tv_sec * 1000000 + tiempo.tv_usec;
    printf("Microsegundos calculando en MMX: %ld\n", (fin-inicio));
    escribirResultado(mResultado, header2, fm2, resultado);

    fclose(fm2);
    free(header2);
    free(m1);
    free(m2);
}

tHeader *leerHeader(FILE *image){
//lee los datos que nos interesan del header y retorna
//una estructura con ellos
    tHeader *tempHeader;

    tempHeader = (tHeader *) malloc(sizeof(tHeader));
    fseek(image, 0xA, SEEK_SET); //posicion offset  
    fread(&(tempHeader->dataOffset), 4, 1, image);
    fseek(image, 0x4, SEEK_CUR); //posicion width 
    fread(&(tempHeader->width), 4, 3, image); //height y b/p a continuación
    tempHeader->bp >>= 0x10; //descartar planos
    return tempHeader;
}

uchar *cargar(FILE *fm1, tHeader *header){
//lee los datos de la imagen con los datos del header leidos previamente 
    uchar *tempM;

    tempM = (uchar *) malloc(4+LONGITUD);
    //4 bits extra para no salirse del array en MMX 
    fseek(fm1, header->dataOffset, SEEK_SET); //comienzo de datos
    fread(tempM, header->bp / 8, header->width * header->height, fm1);
    return tempM;
}

void escribirResultado(uchar *matriz, tHeader *header, FILE *image, char *nombre){
//escribe una imagen a partir de una matriz con los datos y
//un header y otro fichero con el mismo formato que la nueva imagen
    FILE *resultado;
    char *datosHeader[header->dataOffset];

    fseek(image, 0, SEEK_SET); //posicion inicial
    fread(datosHeader, header->dataOffset, 1, image); //copiar header
    resultado = fopen(nombre, "wb");
    fwrite(datosHeader, header->dataOffset, 1, resultado); //escribir header
    fwrite(matriz, 1,LONGITUD, resultado);
    fclose(resultado);
}

uchar *fundidoc(int longitud, uchar *m1, uchar *m2, int vFundido){
//fusiona las matrices de dos imagenes
    uchar *temp, *retorno; 
    temp = (uchar *)malloc(longitud);
    retorno = temp;
    while(longitud--)
	*temp++ = (uchar)(((*(m1++) - *m2) * vFundido >> 0x8) + *(m2++));
    return retorno;
}
