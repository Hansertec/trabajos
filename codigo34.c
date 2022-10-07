void main(void) {
  floatP, S, R;
  printf(“\nIngrese las ventas de los tres vendedores : “);
  scanf(“% f % f % f”, &P, &S, &R);
  if (P > S)
    if (P > R)
      if (S > R)
        printf(“\n\n El orden es P, S y R : % 8.2f % 8.2f % 8.2f”, P, S, R);
  elseprintf(“\n\n El orden es P, R y S : % 8.2f % 8.2f % 8.2f”, P, R, S);
  elseprintf(“\n\n El orden es R, P y S : % 8.2f % 8.2f % 8.2f”, R, P, S);
  elseif(S > R) if (P > R) printf(“\n\n El orden es S, P y R
                                  : % 8.2f % 8.2f % 8.2f”, S, P, R);
  elseprintf(“\n\n El orden es S, R y P : % 8.2f % 8.2f % 8.2f”, S, R, P);
  elseprintf(“\n\n El orden es R, S y P : % 8.2f % 8.2f % 8.2f”, R, S, P);
}
El programa, al recibir como datos la matrícula, la carrera,
    el semestre ➥y el promedio de un alumno de una universidad privada,
    determina si➥éste puede ser asistente de su carrera.MAT,
    CAR y SEM : variables de tipo entero.PRO : variable de tipo real.* /
        vvooiiddmain(vvooiidd) {
  iinnttMAT, CAR, SEM;
  ffllooaattPRO;
  printf(“Ingrese matrícula : “);
  scanf(“% d”, &MAT);
  printf(“Ingrese carrera(1 - Industrial 2 - Telemática 3 - Computación4 -
                          Mecánica)
         : “);
  scanf(“% d”, &CAR);
  printf(“Ingrese semestre : “);
  scanf(“% d”, &SEM);
  printf(“Ingrese promedio : “);
  scanf(“% f”, &PRO);
  sswwiittcchh(CAR) {
  ccaassee1:
    iiff(SEM >= 6 && PRO >= 8.5) printf(“\n % d % d % 5.2f”, MAT, CAR, PRO);
    bbrreeaakk;
  ccaassee2:
    iiff(SEM >= 5 && PRO >= 9.0) printf(“\n % d % d % 5.2f”, MAT, CAR, PRO);
    bbrreeaakk;
  ccaassee3:
    iiff(SEM >= 6 && PRO >= 8.8) printf(“\n % d % d % 5.2f”, MAT, CAR, PRO);
    bbrreeaakk;
  ccaassee4:
    iiff(SEM >= 7 && PRO >= 9.0) printf(“\n % d % d % 5.2f”, MAT, CAR, PRO);
    bbrreeaakk;
  ddeeffaauulltt:
    printf(“\n Error en la carrera”);
    bbrreeaakk;
  }
}