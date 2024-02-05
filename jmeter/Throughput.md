Existe una diferencia entre usuarios concurrentes y solicitudes por segundo...

Supongamos que encargamos a un curso con N cantidad de estudiantes por ejemplo 10, cada uno con su laptop a probar nuestra aplicación de carrito de compras (puede ser cualquier otra). Los vamos a denominar como usuarios en lugar de estudiantes.

Cuando damos la indicación empiezan a probar a su conveniencia, esto quiere decir que no hay regla alguna de seguir, algunos usuarios prueban revisando los productos que venden, otros navegan por la app, otros compran el carrito, otros en cambio solo la abren y no hacen nada si no detallar la maravilla de un producto, otros la abren pero ni interactuan con ella por pereza. Todos son usuarios concurrentes, pero a decir verdad no podriamos sentar que nuestra app esta complemente funcional en rendimiento frente a esos 10 usuarios, porque no todos envian la misma cantidad de solicitudes al servidor y mucho menos al mismo tiempo unos con otros

## El Throughput (rendimiento) en las pruebas y en Jmeter

Un calculo matematico simple, por ejemplo si nuestro servidor recibe 60 peticiones por minuto. Quiere decir que nuestro servidor tiene un throughput de una (1) petición por segundo **60 peticiones / 60 segundos = 1**. Otro ejemplo, si ahora recibe 120 peticiones por minuto, su throughput es de 2 peticiones por segundo ya que **120 peticiones / 60 segundos = 2**

Todo esto teniendo en cuenta el ejemplo de arriba, son usuarios concurrentes... si ... pudo haber sido un mismo usuario el que envío esa cantidad de solicitudes, como pudo haber sido mas de uno, dos, etc...

### Promedio del throughput

Un dato interesante es el promedio ....

## ¿ Que información necesitamos para empezar a hacer nuestras pruebas ?





