#Programacion 
##Temas segundo parcial.

 [1. Excepciones.](#clase10)
 [2. Tests Unitarios](#clase11)
   
<a href="#clase10"></a>
### Excepciones
- Son la manera que tienen algunos lenguajes de programacion para controlar la gestion de errores.

> ***Gestion de errores** es la tecnica que permite interceptar con exito errores esperados o inesperados.*

- *Las excepciones detienen el flujo actual del prograama y si no se hace nada, el programa dejará de funcionar.*

- **TODAS** las excepciones derivan de la clase Exception (que es parte del CLR).

- Los mensajes de error no estan representados por valores o enumeraciones, son significativos y descriptivos.
- Cada clase excepcion puede residir dentro de su propio archivo de origen y no esta vinculada a las demas.
  
####Bloques try-catch.
Es la solucion que nos ofrece la orientacion a objetos a los problemas de la gestion de errores.

~~~
    try
    {

    }
    catch(Exception e)
    {
        
    }
~~~
El bloque try es donde se pone la parte de codigo que podrian lanzar excepciones, mientras que el bloque catch es donde se dara el tratamiento de la excepcion.
Si se encuentra un bloque catch se puede capturar la excepcion y se reanudara la ejecucion normal de codigo desde el cuerpo del bloque catch.


###Generics
- que son?
    : Elementos que se adaptan para realizar la misma funcionalidad para una variedad de tipos de datos.
#### Clases genericas
*T es un objeto de tipo generico.*
~~~ C#
public class Lista<T>
{
    Private T[] lista; //array de elementos T que se llama lista

}

public void Add(T item)
{

}

public T GetElementByIndex(int index)
{

}
~~~

#### Beneficios
- Seguridad de tipos.
- Reutilizacion de codigo.
- genericas vs no genericas.
*Se pueden tener metodos genericos en clases no genericas*

### Restricciones
|||
|:--- |:--- |
|where T : struct | El argumento debe de ser un tipo de valor.|
|where T : class |El argumento debe de ser un tipo de referecia |
|where T : unmanaged |El argumento no debe de ser de un tipo de referencia y no debe contener ningun miembro de tipo de referencia en ningun nivel de anidamiento|
|where T : new() |el argumento debe de tener un ctos sin parametros publicos.|
|where T : \<nombre de la clase base> ||
|where T : \<nombre de la interfaz> ||
|where T : U ||
