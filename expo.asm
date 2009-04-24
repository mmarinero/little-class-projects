;calcula 10^x
;Recibe un parametro con el número x (double)
;Retorna 10^x en st0 (double)

%define x ebp + 8

segment .text
global expo

expo:
    enter 4,0 ;No se necesita guardar los registros

    finit
    fstcw [ebp-4]
    or word [ebp-4], 0x0C00 ;redondear hacia 0
    fldcw [ebp-4]

    fld qword [x]
    fldl2t ;st0 = log2(10)
    fmul st1 ;st0 = log2(resultado)
    fld st0 ;st1 = st0
    frndint
    fsubr st1 ;st0 = p decimal expo
    f2xm1 ;st0 = 2^p decimal expo - 1
    fld1
    faddp st1 ;st0 = 2^p decimal expo
    fscale ;st0 = 2^p decimal expo*2^st1
	   ;fscale usa st1 redondeando hacia 0
    leave
    ret
