package quienquiereserpobre;

import co.core.gamesmall.*;
import java.util.ArrayList;
import java.util.Scanner;


public class QuienQuiereSerPobre {

    public static void main(String[] args) {
        
        /* PRIMERA PREGUNTA CON SUS OPCIONES Y RESPUESTA CORRECTA */
        PreguntaOpcion pregunta1_Opciones = new PreguntaOpcion();
        pregunta1_Opciones.addCuerpoPreguntaOpcion("IDE");
        pregunta1_Opciones.addCuerpoPreguntaOpcion("Motor de busqueda");
        pregunta1_Opciones.addCuerpoPreguntaOpcion("Navegador");
        pregunta1_Opciones.addCuerpoPreguntaOpcion("Todas las anteriores");
        
        Pregunta pregunta1 = new Pregunta(); 
        pregunta1.setEnunciadoPregunta("¿Google Chrome es?");
        pregunta1.setPreguntaOpciones(pregunta1_Opciones);
        pregunta1.setPreguntaOpcionCorrecta(pregunta1.getPreguntaOpciones().getCuerpoPreguntaOpcion().get(2));
        pregunta1.setValor(500);

        /* SEGUNDA PREGUNTA CON SUS OPCIONES Y RESPUESTA CORRECTA */
        PreguntaOpcion pregunta2_Opciones = new PreguntaOpcion();
        pregunta2_Opciones.addCuerpoPreguntaOpcion("Un conjunto de instrucciones o reglas bien definidas, ordenadas y finitas que permiten realizar una actividad mediante pasos sucesivos que no generen dudas a quien deba realizar dicha actividad");
        pregunta2_Opciones.addCuerpoPreguntaOpcion("Es una igualdad entre dos expresiones algebraicas, denominadas miembros, en las que aparecen valores conocidos o datos, y desconocidos o incógnitas, relacionados mediante operaciones");
        pregunta2_Opciones.addCuerpoPreguntaOpcion("Es una relación de variables que pueden ser cuantificadas para calcular el valor de otras de muy difícil o imposible cálculo y que suministra una solución para un problema");
        pregunta2_Opciones.addCuerpoPreguntaOpcion("Las anteriores respuestas no son correctas");
        
        Pregunta pregunta2 = new Pregunta(); 
        pregunta2.setEnunciadoPregunta("¿Qué es un algoritmo?");
        pregunta2.setPreguntaOpciones(pregunta2_Opciones);
        pregunta2.setPreguntaOpcionCorrecta(pregunta2.getPreguntaOpciones().getCuerpoPreguntaOpcion().get(0));
        pregunta2.setValor(1000f);

        /* SEGUNDA PREGUNTA CON SUS OPCIONES Y RESPUESTA CORRECTA */
        PreguntaOpcion pregunta3_Opciones = new PreguntaOpcion();
        pregunta3_Opciones.addCuerpoPreguntaOpcion("32");
        pregunta3_Opciones.addCuerpoPreguntaOpcion("65");
        pregunta3_Opciones.addCuerpoPreguntaOpcion("97");
        pregunta3_Opciones.addCuerpoPreguntaOpcion("126");
        
        Pregunta pregunta3 = new Pregunta(); 
        pregunta3.setEnunciadoPregunta("¿Cuál es el código ASCII decimal de la letra A mayúscula?");
        pregunta3.setPreguntaOpciones(pregunta3_Opciones);
        pregunta3.setPreguntaOpcionCorrecta(pregunta3.getPreguntaOpciones().getCuerpoPreguntaOpcion().get(0));
        pregunta3.setValor(4000f);
        
        /* Almacenamos en el array preguntas todas las preguntas*/
        Pregunta[] preguntas = {pregunta1, pregunta2, pregunta3};
        
        float dineroTotalGanado = 0;
        int numeroDeLaPregunta = 1;
        for (Pregunta pregunta : preguntas) {
            // limpiamos
            System.out.println("Pregunta #" + numeroDeLaPregunta + " por $ " + pregunta.getValor());
            System.out.println(pregunta.getEnunciadoPregunta());
            ArrayList<String> opcionesDeLaPregunta = pregunta.getPreguntaOpciones().getCuerpoPreguntaOpcion(); 
            for (String cuerpoPreguntaOpcion : opcionesDeLaPregunta) { 		      
                System.out.println(opcionesDeLaPregunta.indexOf(cuerpoPreguntaOpcion) + ". " + cuerpoPreguntaOpcion); 		
            }
            System.out.println("_______________________________");
            Scanner s = new Scanner(System.in);
            System.out.print("Respuesta: ");
            if (s.nextInt() == pregunta.getPreguntaOpcionCorrecta()) {
                System.out.println("RESPUESTA CORRECTA");
                dineroTotalGanado += pregunta.getValor();
                System.out.println("__ Dinero acumulado: $ " + dineroTotalGanado + " __");
            } else {
                System.out.println("RESPUESTA INCORRECTA");
                break;
            }
            numeroDeLaPregunta++;
        }
        System.out.println("__ Total dinero ganado: $ " + dineroTotalGanado + " __");

    }
}
