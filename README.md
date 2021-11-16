# Prototype
Es un patr�n creacional. [Link descripci�n](https://sourcemaking.com/design_patterns/prototype)

## Diagrama de clases
![UML](prototype.jpg)

## SOLID

* Single responsibility

La responsabilidad del objeto prototype no est� atada a la implementaci�n de su m�todo de clonado.

* Open/Closed principle

Un objeto prototype puede ser extendido para ampliar o cambiar su funcionalidad sin problema.

* Liskov substitution

Este principio tampoco entra en conflicto con la implementaci�n de un prototype, cualquier hijo del objeto prototype deber�a comportarse como su padre dadas las circunstancia.

* Interface segregation

Un buen dise�o de interfaces no coliciona con el desarrollo de un prototype.

* Dependency inversion

Las dependencias del objeto prototype pueden estar referenciadas mediante interfaces de alto nivel si se modela con cuidado. Quizas utilizando factories o builders.