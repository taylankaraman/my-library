#include <stdio.h>
#include <stdlib.h>

char* reverse(char* p_array)
{
    int length = 0;
     
    while(p_array[length] != '\0')
    {
        length++;
    }
     
    char *reversed = (char*) malloc(length);
     
    for(int i=0; i<length; i++)
         reversed[i] = p_array[length - i - 1];
     reversed[length] = '\0';
     
    return reversed;        
}

int main(int argc, char**argv) 
{

    char c_str[] = "taylan";
    char* return_p = reverse(c_str);
    
    printf("Reversed c string: %s", return_p);
    
    free(return_p);
    
    return 0;
}
