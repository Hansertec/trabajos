#include <math.h>
#include <stdio.h>
/* Función matemática.El programa obtiene el resultado de una función.OP y T:
 * variables de tipo entero.RES: variable de tipo real. */
vvooiiddmain(vvooiidd) {
  iinnttOP, T;
  ffllooaattRES;
  printf(“Ingrese la opción del cálculo y el valor entero : “);
  scanf(“% d % d”, &OP, &T);
  sswwiittcchh(OP) {
  ccaassee1:
    RES = T / 5;
    bbrreeaakk;
  ccaassee2:
    RES = pow(
        T, T); /* La función ppoowwestá definida en la biblioteca mmaatthh..hh*/
    bbrreeaakk;
  ccaassee3:
  ccaassee4:
    RES = 6 * T / 2;
    bbrreeaakk;
  ddeeffaauulltt:
    RES = 1;
    bbrreeaakk;
  }
  printf(“\nResultado : % 7.2f”, RES);
}