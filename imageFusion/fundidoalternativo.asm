
segment .text
global fundido

fundido:
    enter 8,0
    pusha
    mov edx, [ebp+20]
    mov [ebp-2], dx
    mov [ebp-4], dx
    mov [ebp-6], dx
    mov [ebp-8], dx
    movq mm2, [ebp-8]
    neg edx
    add edx, 255
    mov [ebp-2], dx
    mov [ebp-4], dx
    mov [ebp-6], dx
    mov [ebp-8], dx
    movq mm3, [ebp-8]
    mov ecx, [ebp+8]
    mov eax, [ebp+12]
    mov ebx, [ebp+16]
    mov esi, 0
    movd mm4, esi
bucle:
    movd mm0, [eax+4*esi]
    movd mm1, [ebx+4*esi]
    punpcklbw  mm0, mm4
    punpcklbw  mm1, mm4
    pmullw mm0, mm2
    pmullw mm1, mm3
    psrlw mm0, 8
    psrlw mm1, 8
    paddw mm0, mm1
    packuswb mm0, mm4
    movd dword [eax+4*esi], mm0
    inc esi
    loop bucle

    popa
    mov eax, [ebp+12]
    leave
    ret
