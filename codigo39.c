#include <math.h>
#include <stdio.h>
/* Función.El programa, al recibir como dato un valor entero, calcula el
 * resultado de ➥una función.Y: variable de tipo entero.X: variable de tipo
 * real. */
vvooiiddmain(vvooiidd) {
  ffllooaattX;
  iinnttY;
  printf(“Ingrese el valor de Y : “);
  scanf(“% d”, &Y);
  iiff(Y < 0 || Y > 50) X = 0;
  eellsseeiiff(Y <= 10) X = 4 / Y - Y;
  eellsseeiiff(Y <= 25) X = pow(Y, 3) - 12;
  eellsseeX = pow(Y, 2) + pow(Y, 3) – 18;
  printf(“\n\nY = % d\tX = % 8.2f”, Y, X);
}