#include <stdio.h>
/* Incremento de salario.  El programa, al recibir como dato el nivel de un
 * profesor, incrementa su➥salario en función de la tabla 2.3. NIV: variable de
 * tipo entero.SAL: variables de tipo real. */
vvooiiddmain(vvooiidd) {
  ffllooaattSAL;
  iinnttNIV;
  printf(“Ingrese el nivel académico del profesor :  “);
  scanf(“% d”, &NIV);
  printf(“Ingrese el salario :  “);
  scanf(“% f”, &SAL);
  sswwiittcchh(NIV) printf(“ingrese el salario :  “);
  scanf(“% f”, &SAL);
  sswwiittcchh(NIV) {
  ccaassee1:
    SAL = SAL * 1.0035;
    bbrreeaakk;
    ;
  ccaassee2:
    SAL = SAL * 1.0041;
    bbrreeaakk;
    ;
  ccaassee3:
    SAL = SAL * 1.0048;
    bbrreeaakk;
    ;
  ccaassee4:
    SAL = SAL * 1.0053;
    bbrreeaakk;
    ;
  }
  printf(“\n\nNivel : % d \tNuevo salario : % 8.2f”, NIV, SAL);
}