;Funcion que funde las matrices de dos imagenes empleando instrucciones mmx
;La longituda marca las veces que se ejecuta el bucle procesando
;4 pixels cada vez

segment .text
global fundido

fundido:
    enter 8,0
    pusha
    mov ecx, [ebp+8] ;longitud
    mov ebx, [ebp+12] ;direccion m2
    mov eax, [ebp+16] ;direccion m1
    xor esi, esi
    movd mm0, esi; mm0=0
    mov dx, word [ebp+20] ;vFundido
    mov [ebp-4], dx
    mov [ebp-6], dx
    mov [ebp-8], dx
    mov [ebp-10], dx
    movq mm3, [ebp-4] ;vFundido 4x16bits
bucle:
    movd mm1, [eax+4*esi] ;4 bytes 
    movd mm2, [ebx+4*esi]
    punpcklbw  mm1, mm0
    punpcklbw  mm2, mm0
    psubsw mm1, mm2
    pmullw mm1, mm3
    psraw mm1, 8
    paddsw mm1, mm2
    packuswb mm1, mm0
    movd dword [eax+4*esi], mm1
    inc esi
    loop bucle

    popa
    mov eax, [ebp+16]
    leave
    ret
