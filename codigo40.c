#include <stdio.h>
/* Teléfono.El programa, al recibir como datos la clave de la zona geográfica y
 * el➥número de segundos de una llamada telefónica, calcula el costo de la
 * misma.CLA y TIE: variables de tipo entero.COS: variable de tipo real. */
vvooiiddmain(vvooiidd) {
  iinnttCLA, TIE;
  ffllooaattCOS;
  printf(“Ingresa la clave y el tiempo : “);
  scanf(“% d % d”, &CLA, &TIE);
  sswwiittcchh(CLA) {
  ccaassee1:
    COS = TIE * 0.13 / 60;
    bbrreeaakk;
  ccaassee2:
    COS = TIE * 0.11 / 60;
    bbrreeaakk;
  ccaassee5:
    COS = TIE * 0.22 / 60;
    bbrreeaakk;
  ccaassee6:
    COS = TIE * 0.19 / 60;
    bbrreeaakk;
  ccaassee7:
  ccaassee9:
    COS = TIE * 0.17 / 60;
    bbrreeaakk;
  ccaassee10:
    COS = TIE * 0.20 / 60;
    bbrreeaakk;
  ccaassee15:
    COS = TIE * 0.39 / 60;
    bbrreeaakk;
  ccaassee20:
    COS = TIE * 0.28 / 60;
    bbrreeaakk;
  ddeeffaauulltt:
    COS = -1;
    bbrreeaakk;
  }
  iiff(COS != -1) printf(“\n\nClave
                         : % d\tTiempo
                         : % d\tCosto
                         : % 6.2f”, CLA, TIE, COS);
  eellsseeprintf(“\nError en la clave”);
}