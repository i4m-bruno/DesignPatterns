
# Design Patterns
Estou fazendo esse projeto com inten��o de treinar o uso de padr�es de projeto e de quebra compartilhar o conhecimneto.


## Pattern 1 - Strategy
Objetivo / Inten��o Definir uma fam�lia de algoritmos, encapsular cada um, e faz�-los intercambi�veis, ele permite que algoritmos variem independentemente entre clientes que os utilizam.

Tamb�m conhecido como: Policy

Motiva��o: Quando se necessita de um algoritmo que trata de modos diferentes os dados submetidos a ele.

## Pattern 2 - Chain of Responsability
Chain of Responsibility � um padr�o de design comportamental que permite passar solicita��es ao longo de uma cadeia de manipuladores. Ao receber uma solicita��o, cada manipulador decide processar a solicita��o ou pass�-la para o pr�ximo manipulador da cadeia.

Voc� pode ver um exemplo neste projeto, busque a interface IDesconto e veja que as classes que implementam essa interface devem ter uma propriedade
tamb�m implementa a interface IDesconto, gerando assim a corrente de responsabilidade.

## Pattern 3 - Template Method
Basicamente o Template Method � um padr�o de design comportamental que define o esqueleto de um algoritmo na superclasse, mas permite que as subclasses substituam etapas espec�ficas do algoritmo sem alterar sua estrutura.
O Template Method utiliza uma classe abstrata base, que vai encapsular o template do algoritmo em um m�todo, para que as classes concretas possam herdar desta classe e realizar a implementa��o de determinados passos deste algoritmo.