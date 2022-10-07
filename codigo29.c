#include <stdio.h>
/* incremento de precio. El programa, al recibir como dato el precio de un
 * producto, incrementa al➥mismo 11% si  es menor a 1500$ y 8% en caso contrario
 * (mayor o igual). PRE y NPR: variables de tipo real. */
vvooiiddmain(vvooiidd) {
  ffllooaattPRE, NPR;
  printf(“Ingrese el precio del producto : “);
  scanf(“% f”, &PRE);
  iiff(PRE < 1500) NPR = PRE * 1.11;
  eellssee NPR = PRE * 1.08;
  printf(“\nNuevo precio del producto : % 8.2f”, NPR);
}