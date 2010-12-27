;calcula 10^x
;Recibe un parametro con el número x (double)
;Retorna 10^x en st0 (double)
;si hay overflow o underflow retorna -1

%define x ebp + 8

segment .text
global expo

expo:
    enter 8,0 ;No se necesita guardar los registros

    finit
    fstcw [ebp-4]
    or word [ebp-4], 0x0C00 ;redondear hacia 0
    fldcw [ebp-4]

    fld qword [x]
    fldl2t ;st0 = log2(10)
    fmul st1 ;st0 = log2(resultado)
    fld st0 ;st1 = st0
    frndint
    fsubr st1 ;st0 = expo-decimal
    f2xm1 ;st0 = 2^expo-decimal - 1
    fld1
    faddp st1 ;st0 = 2^p expo-decimal
    fscale ;st0 = 2^expo-decimal * 2^st1
	   ;fscale usa st1 redondeando hacia 0 que es expo-entero
    fst qword [ebp-8] ;comprobar que se puede representar en un double
		      ;es suficiente porque si fscale hubiera causado
		      ;overflow o underflow hubiera almacenado
		      ;un numero no representable en un double
    fstsw [ebp-4]
    and word [ebp-4], 0x18 ;dejar solo overflow-underflow bits
    cmp word [ebp-4], 0
    je salir
    mov word [ebp-4], -1
    fild word [ebp-4]

salir:
    leave
    ret
