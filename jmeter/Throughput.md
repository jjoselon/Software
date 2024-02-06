Existe una diferencia entre usuarios concurrentes y solicitudes por segundo...

Supongamos que encargamos a un curso con N cantidad de estudiantes por ejemplo 10, cada uno con su laptop a probar nuestra aplicación de carrito de compras (puede ser cualquier otra). Los vamos a denominar como usuarios en lugar de estudiantes.

Cuando damos la indicación empiezan a probar a su conveniencia, esto quiere decir que no hay regla alguna de seguir, algunos usuarios prueban revisando los productos que venden, otros navegan por la app, otros compran el carrito, otros en cambio solo la abren y no hacen nada si no detallar la maravilla de un producto, otros la abren pero ni interactuan con ella por pereza. Todos son usuarios concurrentes, pero a decir verdad no podriamos sentar que nuestra app esta complemente funcional en rendimiento frente a esos 10 usuarios, porque no todos envian la misma cantidad de solicitudes al servidor y mucho menos al mismo tiempo unos con otros

## El Throughput (rendimiento) en las pruebas y en Jmeter

Un calculo matematico simple, por ejemplo si nuestro servidor recibe 60 peticiones por minuto. Quiere decir que nuestro servidor tiene un throughput de una (1) petición por segundo **60 peticiones / 60 segundos = 1**. Otro ejemplo, si ahora recibe 120 peticiones por minuto, su throughput es de 2 peticiones por segundo ya que **120 peticiones / 60 segundos = 2**

Todo esto teniendo en cuenta el ejemplo de arriba, son usuarios concurrentes... si ... pudo haber sido un mismo usuario el que envío esa cantidad de solicitudes, como pudo haber sido mas de uno, dos, etc...

### Promedio del throughput

Un dato interesante es el promedio, por ejemplo si se enviaron 90 peticiones en el transcurso de 2 minutos, el promedio fue de 45 peticiones por minuto **90 peticiones / 2 minutos** o tambien **90 peticiones / 120 segundos** el promedio fue de 0.75 peticiones por segundo.

## ¿ Que información necesitamos para empezar a hacer nuestras pruebas ?

- **Cantidad de usuarios**: Es la cantidad de usuarios promedio (no peticiones) que esperamos visiten nuestro sitio o utilizen nuestra aplicación. Este dato comunmente lo obtenemos de datos estadisticos que nos ofrecen herramientas como Google Analytics para un ambiente productivo. Este dato es necesario para diseñar nuestra prueba de carga. Es más facil hablar de usuarios que esperamos usen nuestra aplicación y no de cuantas solicitudes GET o POST podrian llegar por segundo
- **Que esperamos que hagan los usuarios**: En el flujo de pasos para realizar una acción en particular en nuestro sitio, de nuestro stack de funcionalidades debemos crear una secuencia de pasos que regularme seguirian los usuarios potenciales al usuario nuestra aplicación, como por ejemplo buscar un producto, agregarlo al carrito, confirmar compra, etc... Actuando asi el script de Jmeter como una "copia virtual" de los usuarios reales "Podemos esperar tener 500 usuarios en el sitio en un momento dado y queremos probar el comportamiento del sitio cuando 500 usuarios estén haciendo cosas más o menos al mismo tiempo. Pero los humanos que visitan nuestro sitio no actúan de forma sincronizada, por supuesto. En cualquier momento dado, algunas personas estarán buscando, otras leerán la descripción de un artículo, otras actualizarán su foto de perfil y tal vez algunas se detendrán por un minuto para revisar su correo electrónico y regresarán al sitio después de esa pausa.

Diríamos que son 500 usuarios simultáneos, pero no realizan 500 solicitudes simultáneas. Las visitas por segundo que generen esos usuarios simultáneos solo se basarán en sus interacciones reales con la aplicación, cuando hagan clic en un botón o un enlace o envíen un formulario."





