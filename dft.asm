%define xr [ebp + 8] 
%define xi [ebp + 12] 
%define matrizr [ebp + 16] 
%define matrizi [ebp + 20] 
%define rr [ebp + 24] 
%define ri [ebp + 28] 
%define n [ebp + 32] 
%define n2 [ebp - 4] ;contador del bucle externo
%define i [ebp -8] ;contador rr[i], ri[i], usar n2 como contador ascendente complica la lógica y no mejora el rendimiento


segment .text
global dft

dft:
    enter 8, 0
    pusha
    mov ecx, n
    mov dword i, 0
    mov dword n2, ecx
    shr dword n, 1 ;n/2
    mov eax, xr
    mov ebx, xi
    mov edx, matrizr
    mov esi, matrizi
bucle1:
    xor edi, edi
    xorpd xmm0, xmm0
    xorpd xmm1, xmm1
    mov ecx, n
bucle2:
    movapd xmm2, [eax+edi] ;xr
    movapd xmm3, [ebx+edi] ;xi
    movapd xmm4, [edx+edi] ;matrizr
    movapd xmm5, [esi+edi] ;matrizi
    mulpd xmm2, [edx+edi] ;xr * matrizr
    mulpd xmm3, [esi+edi] ;xi * matrizi
    subpd xmm2, xmm3 ;(xr * matrizr) - (xi * matrizi)
    addpd xmm0, xmm2 ;acumulador rr
    mulpd xmm5, [eax+edi] ;matrizi * xr
    mulpd xmm4, [ebx+edi] ;matrizr * xi
    addpd xmm4, xmm5 ;(matrizi * xr) + (matrizr * xi)
    addpd xmm1, xmm4 ;acmulador ri
    add edi, 16
    loop bucle2

    shl dword n, 4 ;n * 16 = tam * 8 = tam *sizeof(double) 
    add edx, n ;incrementar fila
    add esi, n ;incrementar fila
    shr dword n, 4 ;restaurar n
    mov edi, i
    mov ecx, rr
    haddpd xmm0, xmm1 ;sumar horizontalmente resultados parciales
    movlpd [ecx+edi*8], xmm0 ;guardar parte real
    mov ecx, ri
    movhpd [ecx+edi*8], xmm0 ;guardar parte imaginaria
    inc dword i
    dec dword n2
    jnz bucle1

    popa
    mov eax, 0
    leave
    ret
