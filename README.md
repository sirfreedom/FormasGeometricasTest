Requerimiento 
 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).

-----------------------------------------

Solucion 

- se determina que el proyecto data sirve para dibujar figuras, el mismo debe ser extensible a muchas figuras, y tener la posibilidad de devolver los resultados en distintos lenguajes.
  
+ Se utilizan dos interfaces
    - Una para las figuras determinando metodos como Perimetro y Area
    - La otra interfaz para inyectar el lenguaje deseado.
+ una clase abstracta
    - para todo lo comun a las demas clases.

Se usan patrones y conceptos de diseno
Conceptos SOLID, DRY
- S : Single responsabilization, responsabilidad unica para cada figura, solo el objeto sabe que hace de forma independiente.
- O : open close entensible, sin modificacion
- L : liskov toda clase es remplazable por su clase base, en este caso no aplica, porque no hay una clase COMMON que pueda determinar una forma base de utilizacion.
- I : Segregacion de interfaces : las interfaces unicamente hacen lo minimo indispensable, no hay metodos no implementados en las clases.
- D : Inyeccion de dependencias : se inyecta el lenguaje, pudiendo a futuro cambiar esto sin depender de clases concretas.

DRY = Dont repeat your self, no se copia y se paga codigo en ningun lado, todo es codigo hecho de cero para cada componente, en el unico lugar que se copia codigo es en el imprimir, que podria ir en el base,
sucede que para ello tendria que implementar un codigo comun en el base, y me permito aclarar que CADA componente debe saber como imprimirse 
tambien no hay una figura base, asi que por cuestiones del negocio ese metodo debe copiarse ya que sabe como devolver los otros metodos.

* Se usa el patron Strategy. 
- permite determinar estrategias de lenguajes y de figuras.
- se podria implementar tambien un Factory, pero como no se el fin concreto de este proyecto (hablando en terminos de implementacion real) no tiene sentido hacer un factory para devolver los objetos, hubiera sido util si
  tuvira IF (figura = "redondel") en ese caso usaria un factory para devolver el objeto desde una lista de objetos, ya instanciado.
  esto tambien mejora las pruebas, pero no queria agrandar tanto el Refactoring
* se usa el patron singleton para leer resource, tuve algunos problemas con esto, si lo necesitan puedo contar un poco mas cuales tuve.

hay muchas mas cosas para mejorar, pero al ser un proyecto pequeno no se puede ir muy alla, sino termina complejizando el tema en vez de mejorarlo.
saludos y espero que les guste mi trabajo.

  


