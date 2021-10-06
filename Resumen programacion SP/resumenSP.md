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
