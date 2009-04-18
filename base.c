/*Unicamente llama a una función en ensamblador y termina*/

int pract6( void ) __attribute__((cdecl));

int main()
{
    int ret_status;
    ret_status = pract6();
    return ret_status;
}
