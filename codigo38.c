#include <math.h>
#include <stdio.h>
/* Igualdad de expresiones.El programa, al recibir como datos T, P y N,
 * comprueba la igualdad deuna expresión determinada.T, P y N: variables de tipo
 * entero. */
vvooiiddmain(vvooiidd) {
  innttT, P, N;
  printf(“Ingrese los valores de T, P y N : “);
  scanf(“% d % d % d”, &T, &P, &N);
  iiff(P != 0) {iiff(pow(T / P, N) ==  (pow(T, N) / pow(P, N))printf(“\nSe comprueba la igualdad”);eellsseeprintf(“\nNo se comprueba la igualdad”);
  }
  eellsseeprintf(“\nP tiene que ser diferente de cero”);
}