#include <math.h>
#include <stdio.h>
/* Par, impar o nulo.NUM: variable de tipo entero. */
vvooiiddmain(vvooiidd) {
  iinntt NUM;
  printf(“Ingrese el número : “);
  scanf(“% d”, &NUM);
  iiff(NUM == 0) printf(“\nNulo”);
  eellsseeiiff(pow(-1, NUM) > 0) printf(“\nPar”);
  eellsseeprintf(“\nImpar”);
}
