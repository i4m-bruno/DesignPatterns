
# Design Patterns
Estou fazendo esse projeto com intenção de treinar o uso de padrões de projeto e de quebra compartilhar o conhecimento.


## Pattern 1 - Strategy
Objetivo / Intenção Definir uma família de algoritmos, encapsular cada um, e fazê-los intercambiáveis, ele permite que algoritmos variem independentemente entre clientes que os utilizam.

Também conhecido como: Policy

Motivação: Quando se necessita de um algoritmo que trata de modos diferentes os dados submetidos a ele.

## Pattern 2 - Chain of Responsability
Chain of Responsibility é um padrão de design comportamental que permite passar solicitações ao longo de uma cadeia de manipuladores. Ao receber uma solicitação, cada manipulador decide processar a solicitação ou passá-la para o próximo manipulador da cadeia.

Você pode ver um exemplo neste projeto, busque a interface IDesconto e veja que as classes que implementam essa interface devem ter uma propriedade
também implementa a interface IDesconto, gerando assim a corrente de responsabilidade.

## Pattern 3 - Template Method
Basicamente o Template Method é um padrão de design comportamental que define o esqueleto de um algoritmo na superclasse, mas permite que as subclasses substituam etapas específicas do algoritmo sem alterar sua estrutura.
O Template Method utiliza uma classe abstrata base, que vai encapsular o template do algoritmo em um método, para que as classes concretas possam herdar desta classe e realizar a implementação de determinados passos deste algoritmo.

## Pattern 4 - Decorator
É um padrão que nos permite estender (decorar) dinamicamente as características de uma classe qualquer. Por características entendemos estado (state: campos e propriedades - propriedades somente em .Net) ou comportamento (behavior: métodos).

É uma alternativa à herança e tem uma diferença importante (e que torna o seu uso mais flexível) em relação àquela:

herança é definida em tempo de compilação;
uma classe decorada é definida em tempo de execução.
Quando usar:

Quando temos uma classe que não queremos herdar;
Quando temos uma classe que não pode ser herdada por ser final - em java -, sealed - em C# - ou NotInheritable - em VB.Net;
Quando temos uma classe que não pode ser herdada por estarmos herdando de uma outra classe qualquer.

## Pattern 5 - State
Este padrão é usado quando há muitos relacionamentos entre objetos, como se um objeto for modificado, seus objetos dependentes devem ser notificados automaticamente. State Design Pattern é usado para alterar o comportamento de um objeto quando seu estado interno muda. Nesse padrão,
um objeto é criado que representa vários estados e um objeto de contexto cujo comportamento varia à medida que seu objeto de estado muda.

Esse padrão parece uma versão dinâmica do padrão Strategy.

## Pattern 6 - Builder
Builder é um padrão de projeto criacional, que permite construir objetos complexos passo a passo.

Ao contrário de outros padrões de criação, o Builder não exige que os produtos tenham uma interface comum. Isso torna possível produzir diferentes produtos usando o mesmo processo de construção.