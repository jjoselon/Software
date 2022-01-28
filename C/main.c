#include <stdio.h>
#include "public/calculate_age.h"
#include "public/matrices.h"

/*
argc is an integer number that contains the number of parameters that were provided in the command line.

argv is an array of strings.
*/
int main(int argc, char *argv[]) {
    for (int i = 0; i < argc; i++) {
        printf("%s\n", argv[i]);
    }
    int age;
    printf("Que año nacistee ?\n");
    scanf("%d", &age);
    printf("Tienes %u años! \n", calculateAge(age));

    printf("%u", decimales[0] );
    return 0;
}