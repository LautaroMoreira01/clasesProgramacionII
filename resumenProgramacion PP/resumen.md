# Programacion
## Resumen programacion 
### Primer Parcial
####  Temas
1. [Introduccion a .Net y C#.](#clase01)
2. [Clases y metodos estaticos](#clase02)
3. [Programacion orientada a objetos.](#clase03)
4. [Sobrecargas.](#clase04)
5. [Windows forms. ](#clase05)
6. [Colecciones.](#clase06)
7. [Encapsulamiento.](#clase07)
8. [Herencia.](#clase08)
9. [Polimorfismo y clases abstractas.](#clase09)

 <a name ="clase01" href=""></a>
 #### 1. Introduccion a .Net y C# 
 ##### .NET
 
 Que es?

 Es una plataforma gratuita de codigo abierto que nos provee herramietas y programas para construir software, asi como tambien el entorno para ejecutarlo.

 Existen 4 implementaciones distintas

- NET Framewoerk
- NET Core
- Xamarin
- NET 5

######CLR (Common Language Runtime) 

Es el encargado de administrar la ejecucion del programa. Todos los programas creados en .NET se ejecutan en un runtime.

######Tareas 
- Administrar uso, asignacion y liberacion de memoria.
- Genera y compila codigo para que el programa pueda ejecutarse
- Manejo de errores en tiempo de ejecucion
- Provee funcionalidades para lenguajes orientados a objetos.
- Soporte para programacion multi-thread.
- Cuestiones de seguridad y rendimiento.
  
######BCL (Base class library)

- Serie de bibliotecas con funcionalidades de uso general que forma parte de los espacios (namespaces) de nombre Microsoft y System.
  
###### Diferencia entre Librerias y Frameworks.

| Librerias | Frameworks |
| -- | -- |
| - Serie de funcionalidades para realizar operaciones especificas, bien definidas. | - Define una forma de trabajo y nos brinda un conjunto de herramientas de alto nivel que nos permite desarrollar ciertas funcionalidades. |
| -Se componen de una coleccion de funciones y objetos auxiliares.  | - Se componen de multiples bibliotecas y otras herramientas. |
| - Nosotros invocamos las funciones de la biblioteca a necesidad.| - El framework invoca al codigo y maneja el flujo de ejecucion. |
| - Nosotros tenemos libertad y control para usar la biblioteca deseada. | - Tiene un comportamiento por defecto y define un estandar para el desarrollador.|

######Proceso de compilacion en .NET

- Todos los lenguajes de .NET siguen el mismo proceso de compilacion.

- El proceso de compilacion pasa por 3 estados y se divide en dos etapas.
  
![Proceso de compilacion C#](/ProcesoDeCompilacionC-Sharp.png)
1. Primera etapa (Static Compilation):
El codigo fuente (Sourse code) de los programas de .NET pueden estar escritos con cualquiera de los lenguajes que seoporta la plataforma ( C#, F#, VB .NET ). Cada uno tiene su propio compilador (el de c# se conoce como **Roslyn** ).
El compilador se encarga de traducir el codigo fuente a ensamblador.

2. Segunda parte (Just in time.):
    Luego el CLR compila el lenguaje intermedio a lenguaje nativo (maquina) en un proceso llamado compilacion just in time.
    Este tipo de compilación tiene como beneficio que abstrae al código fuente de la máquina y el sistema operativo sobre el que se terminará ejecutando el programa, el dependiente es el compilador JIT y el entorno de ejecución. Como desventaja, la compilación JIT realentiza la ejecución del programa ya que se debe esperar a que se compile el lenguaje intermedio.

###### Tiempo de ejecucion y tiempo de compilacion.

- Tiempo de compilacion
  : Es el intervalo de tiempo en el que un compilador compila codigo escrito en un lenguaje de programacionn a una forma de codigo ejecutable por una maquina.
  (Normalmente realiza un checkeo de sintaxis y optimiza el codigo.)
- Tiempo de ejecucion
    : Es el intervalo de tiempo en el que un programa se ejecuta, inicia cuando el programa se pone en memoria y finaliza cuando se envia una señal de terminacion.

##### C# 
###### Caracteristicas de C#.
 *En c# el entry point o punto de entrada es el metodo main.*
 - Compilacion hibrida.
   : C# se compila primero a un lenguaje intermedio y luego al ejecutarse es recompilado a lenguaje nativo/maquina.

 - Orientado a objetos.
    : El lenguaje ofrece caracteristicas orientadas a objetos  como soporte de herencia, encapsulamiento y polimorfismo.
  
 - Orientado a componentes.
    : Tambien presenta caracteristicas que permiten el desarrollo basado en componentes.

 - Seguridad de tipos.
     : Es un lenguaje principalmente de tipado estatico.
 - Garbarage colector.
    : Tiene un programa que se encarga de la liberacion de memoria no utilizada en el heap.

 - Sistema  de tipos unificados.
      : **TODOS** los tipos de datos heredan del tipo object. 

 - Case sensitive.
    : C# es un lenguaje que distingue mayusculas de minusculas.
###### Gramatica de C#.

- Sintaxis: 
  : Serie de reglas que define las combinacoines correctas de simbolos y orden para formar sentencias.
- Vocabulario:
    : Serie de palabras reservadas y operadores que sirven para construir sentencias y expreciones siguiendo reglas de sintaxis.
- Semantica:
   : Es el significado de surge de la combinacoin de esas sentencias y expreciones con una sintaxis valida.
 
##### Common type sistem (CTS)
 El CTS define un conjunto de tipos de datos comun a todos los lenguajes por .NET.
- Establece un marco de herramientas que habilita la ejecucion de los distintos lenguajes de la plataforma.
- Provee el modelo orientado a objetos.
- Define el conjunto de reglas que todos los lenguajes deben seguir en lo que refiere a tipos.
- Provee una biblioteca que contiene los datos primitivos.
- Define tipos de datos en dos categorias: 
    - Valor: 
        :   (value type) Tipos de datos representados por su valor real. (*TODOS los tipos de valor se almacenan en el stack*)
    - Referencia:
        : (Reference types) Son tipos de datos representados por una referencia que apunta a un sector de memoria donde se encuentra el valor real.(*TODOS los tipos de referencia se almacenan en el monton*) 
        
######Categoria de tipos.
|Categoria|Palabra clave|Valor/Referencia|
|--|--|--|
|Clases|class|Referencia|
|Estructura|struct|Valor|
|Enumerado|enum|Valor|
|Interfaces|interface|Referencia|
|Delegado|delegate|Referencia|

######Conversiones de tipos de datos.
- Implicitas
    : No requiere casteo, NO deberia implicar perdida de datos.
- Explicitas
    : se requiere casteo , PODRIAN implicar perdida de datos.
 ___
<a name ="clase02"></a>
###Clase 02.
####Principio DRY (Dont repeat yourself).
> "Toda **pieza de conocimiento** debe tener una representación **única**, **inequívoca** y **fidedigna** dentro de un sistema."

- Pieza de conocimiento:
    : Refiere a una funcionalidad precisa dentro del contexto de negocio o un algoritmo concreto.
- unica: 
    : Que no debe existir otra representacion de la misma pieza.
- Inequivoca:
    : Que no admite de una interpretacion.
- Fidedigna: 
    : Debemos poder confiar que es correcta.

La idea principal es que cuando ocurra un cambio no deberiamos necesitar actualizar multiples cosas en paralelo.

#### Clases y metodos estaticos
##### Metodos estaticos.
*Pequeñas piezas de codigo que se encargan de realizar una tarea concreta.* 
###### Firma.

~~~
(Modificador de acceso) (Otros modificadores) (Tipo de retorno) (Nmbre identificador) (Parametros de entrada)
~~~

~~~ c#
Private static string Mostrar(primerParametro , segundo parametro)
{

}
~~~
#####Clases estaticas.
Son agrupadores de atributos y metodos estaticos.
*Para declarar una clase se debe indicar*
**Agrupan datos y comportamietos que no estan asociados a un objeto.**
~~~
(Modificador de visibilidad (puede ser internal o public)) static class (Nombre de la clase)
~~~
######Caracteristicas
- NO pueden ser clase base.
- NO pueden ser clase derivada.
- NO se pueden instanciar. 
- TODOS los miembros son estaticos.
  
#### Namespaces.

*Agrupacion logica de clases y otros elementos de codigo fuente.
Su funcion principal es organizar el codigo, permitiendo la reduccion de los conflictos por nombres duplicados y la posibilidad de trabajar en un mismo programa con componentes de distinta procedencia.*

##### Using
Permite la especificacion de una llamada a un metodo sin el uso obligatorio del nombre completo.

#####Alias
Permite utilizar un nombre distinto para un espacio de nombre. (Se suele utilizar para abreviar nombre largos).
___
<a name ="clase03"></a>
###Clase 03.
####Paradigma.

*Un paradigma es una teoria o conjunto de teorias cuyo nucleo central se acepta sin cuestionar y que suministra la base y modelo para resolver problemas y avanzar en el conocimiento.*

#####Paradigma de programacion.
*Define la forma, metodologia o estilo con el que se resolvera un problema utilizando un lenguaje de programacion*

- **Paradigma imperativo**: En el cual el programador instruye a la maquina como cambiar su estado.
  - **Pardigma procedural**: Separa las instrucciones en    procedimientos.
  - **Paradigma orientado a objetos**: Agrupa estas instrucciones junto al resultado sobre el que esperan.
-  **Paradigma declarativo**: En el que el programador solamente declara propiedades de un resultado deseado, pero no indica como calcularlo.
    - **Paradigma funcional** donde el resultado deseado es declarado como el valor de una serie de aplicaciones de función.
    - **Paradigma lógico** donde el resultado deseado se declara como la respuesta a una pregunta sobre un sistema de hechos y reglas.
    - **Paradigma matemático** donde el resultado deseado se declara como la solución de un problema de optimización.
    - **Paradigma reactivo** donde el resultado deseado se declara con flujos de datos y la propagación del cambio.

####Programacion orientada a objetos.

*La programacion orientada a objetos es un paradigma que propone resolver problemas a traves de identificar objetos de la vida real, sus atributos, sus comportamientos y las relaciones de colaboracion entre ellos.*

#####Pilares de la programacion orientada a objetos.
- **Abstraccion**
    : Se trata de Capturar la idea principal de un objeto dentro de un determinado contexto, ignorando detalles o especificaciones que no sean relevantes.
    : Ejemplo: en una persona podemos fijarnos solamente en una parte que nos importe por ejemplo podemos mirar la cabeza ignorando el resto del cuerpo.
- **Encapsulamiento**
    : Agrupa datos y acciones relacionados a un objeto ocultando los detalles y protegiendo el acceso a los datsos.
    : Ejemplo: Un telefono celular puede hacer distintas cosas como hacer llamadas, tomar fotos, reproducir musica pero no nos importa como hace esas cosas.
- **Herencia**
    : Se trata de reutilizar codigo partiendo de una clase mas general (padre o base) que compartira su estructura y funcionalidad a las clases mas especificas.
    : Ejemplo en una empresa Todos son personas pero tienen distintas cualidades o hacen distintas cosas por ejemplo un jefe no tiene las mismas actividades que una persona de limpieza. 
- **Polirmorfismo**
    : Se trata de que una clase hija o derivada pueda redefinir una determinada accion heredada de una clase padre o base.
    : Ejemplo: Una mujer puede ser distintas cosas como madre, escritora, estudiante, etc. Una persona puede tener distintos roles.
#### Clases.
*Es una descripcion de un conjunto de objetos que comparten los mismos metodos, atributos, relaciones y semantica en un determinado contexto.*
##### Como se compone una clase?
-  Atributos
    : Representacion de caracteristicas que son compartidas por todos los objetos de una clase.
- Metodos
    : Es la implementacion de una operacion qye es una abstraccion de algo que puede hacer un objeto.
- Constructores
    : Metodo especial cuya funcion es darle valor inicial a los atributos de un objeto.
  - Constructor estatico:
        : Son invocados por el entorno de ejecucion (CLR) una sola vez.
    - No pueden ser invocados.
    - No tienen modificadores de acceso.
    - No tienen parametros de entrada.
    - No pueden ser sobrecargados.
    - Solamente permiten trabajar con miembros que tambien son estaticos.

#### Objeto.

*Son instancias de una clase.*

Instancia 
    : manifestacion concreta de algo. 

Para instanciar un objeto se utiliza el operador **new**.

#####Caracteristicas.

- Viven en memoria (sector heap).
- Tienen identidad. 
   : propiedad que permite diferenciarlos entre si.

##### Destruccion de un objeto.
- No esta vinculado a su ambito.
- Tiene un tiempo de vida mas largo.
- Destruccion no determinista.

##### Ciclo de vida de un objeto.
![Ciclo de vida de un objeto](CicloDeVidaDeUnObjeto.png) 

<a name ="clase04"> </a>
###Sobrecargas.
La sobrecarga es una tecnica para mejorar la usabilidad, productividad y la legibilidad de nuestro codigo.
Permite declarar miembros con el mismo nombre en la misma clase siempre que tengan distinto orden, cantidad o tipo de parametros.

*Se revisan en tiempo de compilacion.*

####Sobrecarga de metodos.

Se utiliza para crear varios metodos con el mismo nombre 
que realicen la misma accion o similares pero con distintos argumentos.

####Sobrecarga de constructores.

Para sobrecargar a los constructores, sólo hay que proporcionar varias declaraciones del constructor con distintas firmas.
El encabezado del constructor seguido de un signo de dos puntos( : ) y de la palabra clave this, se utiliza para invocar a otro constructor.

####Sobrecarga de operadores.
Una clase puede tener su propia sobrecarga de operadores.

#####Operadores unitarios sobrecargables.
---

\+   \-   !   ~   ++   --   true   false 

---

##### Operadores binarios sobrecargables.

---

 \+    \-   *   /   %   &   |   ^   <<   >>   ==   !=   >   <    >=   <=

---
##### Operadores NO sobrecargables.

---

=, &&, ||, ??, ?:, =>, checked, unchecked, new, typeof, default, as, is
 
---

####Sobrecarga de operadores de convercion.

Se puede definir una convercion explicita o implicita personalizada desde o hacia otro tipo.

- Conversion implicita
    : no requieren intervencion del programador, no hay perdida de datos.
- Conversion explicita
    : Requieren intervencion del programador,puede haber perdida de datos.

<a name ="clase05"> </a>
### Clase 05.

### Windows forms.
*Es una libreria de clases que provee una GUI por el mismo sistema de .NET*
***TODOS** los formularios heredan de la clase FORM*
*Para abrir un form en tipo modal se usa .ShowDialg(), para abirlo normal se usa .Show()*
#### Clases Parciales.
Una clase parcial es una clase que esta dividida en dos archivos.
*En forms permite separar el codigo autogenerado por el diseñador de la logica de nuestra aplicacion.*

####Ciclo de vida de un form.

![Ciclo de vida de un form](CicloDeVidaForm.png)

1. new: se crea la instancia del form.
2. Load: El form se encuentra en memoria pero invisible.
3. Paint: Se dibuja el form y sus controles.
4. Activated: El form recibe foco.
5. FormClosing: Comienza el cierre del from, se puede cancelar.
6. FormClosed: el formulario se cierra.
7. Disposed: El objeto esta siendo destruido.
   
####Propiedades.

Nos permite modificar valores de nuestros atributos o acceder a ellos.

####Controles.
Componentes reutilizables que encapsulan funcionalidad de una interfaz grafica.

<a name ="clase06"> </a>
###Clase 06
###Colecciones

####Matrices

Las matrices, arrays, arreglos o vectores, son estructuras de datos que nos permiten almacenar multiples variables del mismo tipo;

#####Caracteristicas
- Dimencionalidad
    : Las matrices pueden ser unidimencionales, bidimiencionales o multidimecionales.
- Tamaño fijo
    : La cantidad y el tamaño de las dimeciones son establecidos al momento de instanciar la matriz y no pueden ser cambiados.
- Indexador base 0
    : Se dice que tienen indexacion base cero porque sus elementos pueden ser accedidos a travez de un indice numerico que comienza en 0. 
#####Matrices unidimencionales
Objetos cuya instancia que debe ser creada. Para crearla se usa new especificando el tipo de elemento de la matriz y el numero de elementos.

####Inicializacion de matrices.
~~~
string[] arrayString = new string[6];
~~~
*Se puede inicializar los elementos cuando se declara*
~~~
int[] a = new int[] { 1, 3, 5, 7, 9 };
~~~
*Se puede omitir el operador new y el tipo cuando se inicializa una matriz luego de la declaracion.*
~~~
int[] array2 = { 1, 3, 5, 7, 9 };
~~~

#####Matrices multidimecionales
Matrices que pueden tener mas de una dimencion.

####Inicializacion de matrices multidimencionales.
~~~
int[,] array = new int[3, 2];
~~~
*Se puede inicializar los elementos cuando se declara*
~~~
int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
~~~

#####Matrices escalonadas *(o jagged array)*.
Matriz de matrices posiblemente de distinto tamaños.

####Colecciones
Objetos especializados en almacenar, organizar, y administrar gran cantidad de datos.

#####Caracteristicas
- Tamaño dinamico
  : El tamaño no es fijo sino que se incrementa y disminuye dinamicamente.
- Capacidad para enumerar la coleccion
  : Las colecciones implementan la interfaz IEnumerable, permite recorrerlas con un bucle foreach
- Capacidad para copiar el contenido de la coleccion a una matriz
  : Todas las colecciones pueden copiarse a una matriz por el metodo CopyTo
- indexacion base 0.
  : Todas las colecciones indexadas tienen un indice base 0

#####Tipos de colecciones.
- Genericas 
  : Contenidas en el name space `System.Collection.Generic`. En este tipo de colecciones todos los elementos tienen el mismo tipo de dato.

Tipos de listas genericas.  
|Clase|Descripcion|
|--|--|
|Dictionary\<Tkey , TValue>|Representa coleccion de pares clave/Valor que se organizan en funcion de la clave|
|List\<T>|Representa una lista de objetos a los que se puede acceder por un indice numerico. Propociona metodos para buscar, ordenar y modificar la lista |
|Queue\<T>|Representa coleccion de objetos que se procesa en orden **FIFO**|
|Stack\<T>|Representa coleccion de objetos que se procesa en orden **LIFO**|
|SortedList\<TKey , TValue>|Representa coleccion de pares clave / valor que se ordenan  por clave |


- NO genericas
  : Contenidas en el name space `System.Collection`. Este tipo de colecciones no cuenta con seguridad de tipos. Sino que almacenan datos de tipo **Object**. 

Tipos de listas no genericas.  
|Clase|Descripcion|
|--|--|
|ArrayList|Representa una matriz de objetos cuyo tamaño aumenta dinamicamente segun sea necesario|
|HashTable|Representa una coleccion de pares clave/valor que se organizan en funcion del codigo hash de la clave |
|Queue|Representa coleccion de objetos que se procesa en orden **FIFO**|
|Stack | Representa coleccion de objetos que se procesa en orden **LIFO**|

<a name ="clase07"> </a>
###Clase07
###Encapsulamiento
Es agrupar datos y operaciones en una clase aislandolas del exterior ocultando su informacion y protegiendola.

Para aplicar la encapusulacion se utilizan los modificadores de acceso en metodos o atributos de la clase.
Algunos modificadores de acceso son.
|Nombre|Caracteristicas|
|--|--|
|Public|Se puede acceder desde cualquier clase en el mismo proyecto u otro proyecto que haga referencia a el|
|Private|Solo accesible desde su misma clase|
|Protected|Accesible solamente desde su clase o su derivada|
|Internal|Accesible solamente desde cualquier parte de codigo dentro del mismo proyecto|
|Protected internal|Se puede acceder a una clase o miembro protected internal desde cualquier código en el proyecto en el que está declarado, o desde una clase derivada en otro proyecto.|
|Private Protected|Se puede acceder a una clase o miembro private protected sólo en la clase que lo declaró o sus derivadas siempre dentor del mismo proyecto.|


#### Propiedades
Miembro que proporciona mecanismo para leer escribir o calcular el valor de un campo.

Las propiedades permiten que una clase exponga una forma pública de obtener y establecer valores, mientras oculta el código de implementación o validación.

####Indexadores 
#####Que es indexar?
Es ordenar una serie de datos o informacion de acuerdo a un criterio comun a todos ellos, para facilitar su consulta y analisis a traves de un indice.

Caracteristicas.
- Pueden trabajar con mas de un indice.
- Se pueden indexar por cualquier tipo
- Se pueden sobrecargar
- NO se pueden declarar indexadores estaticos

####Enumerado 
Tipo de dato que representa un conjunto de constantes numericas.
Sirven para definir y limitar el conjunto de valores que pueden ser asignados a una variable o parametro de entrada. 
Sus valores son numeros enteros y son base 0.

<a name ="clase08"></a>
####Clase 08
####Herencia 
Se conoce como **herencia** a la relacion entre una o mas clases en 
la que se ccomparten los atributos y metodos definidos en otra clase.

La idea y el objetivo principal es crear una clase base que defina un comportamiento y caracteristicas que luego seran usadas en otra clase.

**IMPORTANTE**
- **Las clases derivadas heredan todos los miembros de la clase base menos los constructores.**
- **La accesibilidad de una clase derivada no puede ser mayoy a la de su clase base.**
- **Los miembros de una clase base implicitamnet ese convierten en miembros publicos de la clase derivada**
- **Aunque una clase herede todos los miembros si estos son privados solo la clase base tiene accesos a ellos aunque la clase derivada tambien los hereda.**
  
#####Herencia simple
En la herencia simple una clase derivada hereda de una sola clase base, adquiriendo todos sus mienmbros *MENOS LOS CONSTRUCTORES*.

#####Herencia multinivel

Esta se da cuando una clase derivada hereda de otra clase derivada que a su vez hereda de otra clase.

Esto se conoce como transitividad: Si una clase `C` hereda de una clase `B` y, a su vez `B` hereda de `A`, entonces `C` tambien hereda de `A`. 

#####Herencia jerarquica
Es cuando una clase sirve de base de mas de un sub-tipo. 

#####Herencia hibrida
Es cuando se mezclan dos o mas tipos de herencias.

####S.O.L.I.D *(Principio de sustitucion de liskov)*
Barbara liskov propuso que cada clase que hereda de otra debe poder usarse como su padre sin necesidad de conocer las diferencias entre ellas. osea poder llamar al mismo metodo que exista en la clase padre sin importar que tipo son las hijas.

+ Si `S` hereda de `T`, entonces los objetos de tipo `T` podrán ser reemplazados por objetos del tipo `S`. 

######Beneficios de aplciar herencia.
- simplificar el codigo al definir una clase que especifica elementos comunes a dos o mas clases derivadas. Ayudandonos a eliminar la duplicacion de codigo y datos, reutilizando elementos comunes a objetos relacionados.
- nos permite organizar de manera mas optima las clases que componen la realizad de nuestro programa, agrupandolas por criterios que compartan.

######Riesgos de aplicar herencia.

La herencia es una herramienta muy fuerte pero a la vez puede ser complicada de implementar ya que agrega complejidad al codigo.

######composicion.
Es la idea de que un objeto contiene o esta compuesta de otros objetos.

######Clase sellada.
Son clases que no pueden ser clase base.

<a name ="clase09"></a>
####Clase 09
####Polimorfismo
Habilidad que tienen los objetos de responder al mismo mensaje de distintaso formas.
#####Polimorfismo basado en herencia.
Para implementar la herencia polimorfica se debe declarar el metodo a sobre escribir como abstract o virtual, y redefinirlo con override. Asi se sabra como distinguirlo en tiempo de ejecucicon el tipo real en memoria.
La palabra reservada `virtual` se usa para declarar un método que pueda ser sobrescrito por una clase derivada. La palabra reservada `override` se usa para sobrescribir un método virtual de la clase base.

####Clases abstractas.
Estas clases no se pueden instanciar, su propósito es proporcionar una definición común que modele una jerarquía de herencia.
####Metodos abstractos.
Los métodos abstractos no tienen implementación, por lo que la definición del método va seguida de un ; en lugar del cuerpo del método. Las clases derivadas de la clase abstracta deben dar una implementación a todos los métodos abstractos. 



 



