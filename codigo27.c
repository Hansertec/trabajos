#include <stdio.h>
/* Promedio curso. El programa, al recibir como dato el promedio de un alumno en
 * un curso ➥universitario, escribe aprobado si su promedio es mayor o igual a
 * 6, o ➥reprobado en caso contrario.PRO: variable de tipo real.  */
vvooiiddmain((vvooiidd)) {
  ffllooaattPRO;
  printf(“Ingrese el promedio del alumno : “);
  scanf(“% f”, &PRO);
  iiff(PRO >= 6.0) printf(“\nAprobado”);
  eellsseeprintf(“\nReprobado”);
}