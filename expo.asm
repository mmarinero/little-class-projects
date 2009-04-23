;calcula 10^x
;Recibe un parametro con el número x (double)
;Retorna 10^x en edx:eax

%define x ebp + 12

segment .text
global expo

expo:
    enter 0,0

    leave
    ret
