# PRUEBA TECNICA - POO CON C#

En el siguiente proyecto encontraréis un ejercicio de como trabajar el paradigma POO con C#, parecido a Java.

En este archivo README, dejo un pequeño resumen paso a paso que he seguido para hacer el proyecto, también para que se entienda.

#### CLASE PADRE
Clase padre _Disco_, tenemos lo siguiente:

- Tenemos unos atributos con las caracteristicas del objeto.

- Definimos el constructor pasándole parámetros para poder dar valor a los atributos.

- También definimos el constructor sin parámetros por si fuese necesario crear el objeto aun sin saber algunos datos.
> EJEMPLO: El proveedor de una tienda saca un nuevo producto (un prototipo), tenemos la referencia de él pero no todos los datos técnicos.

- Creamos los getters y setters de cada atributo controlando en el set que el valor no sea inferior a 0 (en caso de los números) y en caso de texto, le ponemos un texto por defectos siempre que esté vacío

- Definimos un método por defecto para todas las clases hijo y métodos que puede sobreescribir cada clase hijo, para poder imprimir toda la información por consola.


#### INTERFACES:
Se identifica que métodos de acción se necesitan para cada objeto, se crea una interfaz única para cada acción y se añade un único método vacío dentro de ella.


#### CLASES HIJO:
Clase hijo _CD_ y _DiscoDuro_, tenemos lo siguiente:

- Herencia de _Disco_, implementamos las interfaces necesarias para cada Clase, (alguna interfaz se comparte porque tienen el mismo comportamiento, aunque no el mismo dato).

- Creamos para cada clase un atributo especifico. También creamos su getter y setter controlando el valor.

- Definimos el constructor pasandole parámetros, también un constructor vacío, pero en ambos ya aplicamos el valor de Tipo de clase por defecto y éste no lo ponemos como parámetro en el constructor. 

- Creamos los métodos de las interfaces ya implementadas y añadimos información en ellas para mostrar.

- Para la clase DiscoDuro se crea un método especifico dentro de su clase.


#### MÁS CLASES HIJO:
Se crean también _BluRay_ y _LP_ siguiendo la misma dinámica que las otras dos clases.


#### CLASES EXTRAS:
Se crean clases extra, fuera de la clase _Disco_, simplemente para probar que podemos usar las mismas interfaces ya creadas.
- Para este caso la interfaz IGIrar, se ha usado también para la clase _Frisbees_ y _Rueda_.

---

**¡GRACIAS POR LA CONFIANZA!**

Por: JaimeOlucha





