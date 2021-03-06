# Exercicios_Fundamentos_Em_CSharp

## Exercícios Pasta Conceito

<b> Exercício 1 </b> </br>
Escreva um programa que solicita que sejam digitadas três notas de um aluno e um peso para
cada nota. Calcule e imprima a média do aluno. 

[ir para o código](/1Conceitos/Exercicio_1/Program.cs) <br/>

<b> Exercício 2 </b> </br>
Escreva um programa semelhante ao do exercício 1, mas agora o número de notas e pesos
pode variar. O usuário deve digitar quantas notas ele desejar e, para parar, a nota -1 deve ser
digitada. Neste momento a média das notas e pesos digitados anteriormente deve ser
calculada e o resultado impresso na tela.

[ir para o código](/1Conceitos/Exercicio_2/Program.cs)</br>

<b> Exercício 3 </b> </br>
1. Imprima todos os números de 10 a 25. <br/>
2. Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.). <br/>
3. Começando em 0, imprima os números seguintes, enquanto a soma dos números já
impressos for menor que 100. <br/>
4. Imprima a tabuada do 9 (até o décimo valor).

[ir para o código](/1Conceitos/Exercicio_3/Program.cs) </br>

<b>Exercício 4</b> </br>
Escreva um programa que calcule o fatorial de 10. 

[ir para o código](/1Conceitos/Exercicio_4/Program.cs) </br>

<b>Exercício 5</b> </br>
Imprima os 15 primeiros números da série de Fibonacci. A série de Fibonacci possui a seguinte sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc. Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento
vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3). 

[ir para o código](/1Conceitos/Exercicio_5/Program.cs) </br>

<b>Exercício 6</b> </br>
Escreva um programa que imprime na saída os valores assumidos por x. Esta variável x deve
iniciar com algum valor inteiro, fornecido pelo usuário. Se x for par, x deve receber o valor dele mesmo somado com 5. Já se x for ímpar, x deve receber o valor dele multiplicado por 2. O programa termina assim que x for maior que 1000. Por exemplo, para x = 10, a saída deve ser: 15, 30, 35, 70, 75, 150, 155, 310, 315, 630, 635, 1270. Faça este exercício usando blocos if e depois usando blocos switch. 

[ir para o código](/1Conceitos/Exercicio_6/Program.cs) </br>

<b>Exercício 7</b> </br>
Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou
inválida. Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve
fornecer os valores para estas variáveis via console. Considerar que fevereiro pode ter
somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999. 

[ir para o código](/1Conceitos/Exercicio_7/Program.cs) </br>

## Exercícios Pasta ClasseEstruturas

<b>Exercício 1</b> </br>
Nesse exercício objetivei apenas praticar alguns coceitos de classe , métodos. </br>
Crie as classes Relogio e Ponteiro e escreva um método Main() para treinar a chamada aos
métodos e fields.
Fields da classe Relogio:
· ponteiroHora (tipo Ponteiro)
· ponteiroMinuto (tipo Ponteiro)
· ponteiroSegundo (tipo Ponteiro)
Métodos da classe Relogio:
· AcertarRelogio(int, int, int): Acerta o relógio, posicionando adequadamente cada
ponteiro do relógio. Os parâmetros passados são hora, minuto e segundo.
· LerHora(): retorna a hora atual do relógio.
· LerMinuto(): retorna o minuto atual do relógio.
· LerSegundo(): retorna o segundo atual do relógio.
Fields da classe Ponteiro:
· posicao(int): indica em qual posição está o ponteiro (1, 2, 3, 4, etc.).  

[ir para o código](/2ClasseEstrutura/Exercicio_1/Program.cs) </br>

<b>Exercício 2</b> </br>
Pratica básica de struct </br>
Crie a estrutura (struct) Fracao, que representa uma fração matemática. Esta estrutura deve ser capaz de armazenar o numerador e o denominador da fração. Ela ainda deve ter um método que recebe uma fração como parâmetro, multiplica ambas as frações, e retorna uma nova fração como resultado. Crie um programa simples que instancia duas frações, define seus valores, calcula o valor da multiplicação entre elas e mostra o resultado. 

[ir para o código](/2ClasseEstrutura/Exercicio_2/Program.cs) </br>

## Exercícios Pasta Objetos
<b>Exercício 6</b> </br>
Crie classes que representam as figuras geométricas: Triangulo, Quadrado, Circunferencia e Trapezio. Cada uma destas classes deve ter um método para calcular a sua área, com a seguinte assinatura: double CalcularArea().</br>
Perceba que o método CalcularArea() não recebe parâmetros. Portanto todos os dados necessários devem ser armazenados no objeto da classe em fields, para depois serem utilizados pelo método.

[ir para o código](/3Objetos/Exercicio_1/Program.cs ) </br>

<b>Exercício 4</b> </br>
Uma turma é composta por três alunos. Cada um dos alunos realizou duas provas, onde cada
prova possuía duas partes. Observe uma descrição sobre o que cada método faz:
Classe Método Descrição
Turma CalcularMedia() Calcula a média da turma. A média é calculada utilizando a
média de cada aluno da turma.
Aluno CalcularMedia() Calcula a média do aluno. A média é calculada utilizando a
nota total das duas provas realizadas por ele.
Prova CalcularNotaTotal() Calcula a nota total da prova. Esta nota é data pela soma
das notas das partes 1 e 2. A nota total não pode
ultrapassar 10.0.
Crie uma aplicação que instancia a turma, os três alunos e as duas provas para cada aluno.
Defina também notas para as provas. A aplicação deve mostrar mensagens informando a
média de cada aluno e a média geral da turma.
Para a definição das notas, utilize as seguintes informações:
Aluno 1
Prova 1
Nota Parte 1 4.0
Nota Parte 2 2.5
Prova 2
Nota Parte 1 1.0
Nota Parte 2 7.0
Aluno 2
Prova 1
Nota Parte 1 6.5
Nota Parte 2 3.5
Prova 2
Nota Parte 1 0.0
Nota Parte 2 3.0
Aluno 3
Prova 1
Nota Parte 1 5.0
Nota Parte 2 4.0
Prova 2
Nota Parte 1 6.0
Nota Parte 2 1.5

[ir para o código](/3Objetos/Exercicio_2/Program.cs ) </br>

## Exercício Pasta Encapsulamento
 <b>Exercício 1</b> </br>
Crie uma classe Lampada que possui um field ligada, que indica se a lâmpada está ligada ou desligada. Ao construir uma lâmpada, o estado dela (ligada ou desligada) deve ser fornecido. Para ligar e desligar a lâmpada, os métodos Ligar() e Desligar() devem ser chamados, respectivamente. Aliás, esta é a única forma de alterar o estado da lâmpada, já que o field ligada não pode ser acessado de fora da classe. A lâmpada também possui um método Imprimir(). Quando chamado, ele mostra as mensagens “Lâmpada ligada” ou “Lâmpada desligada”, dependendo do estado atual. Construa uma aplicação que cria uma lâmpada ligada, muda o estado dela e também imprime o estado atual após cada chamada a Ligar() e Desligar(). 

[ir para o código](/4Encapsulamento/Exercicio_1) </br>

 <b>Exercício 2</b> </br>
 Crie uma classe Data que possui dois construtores. O primeiro recebe um dia, mês e ano e o segundo, além destas informações, recebe também uma hora, minuto e segundo (a hora
fornecida deve estar entre 0 e 23). É importante que este segundo construtor invoque o
primeiro para evitar a duplicação de código. Os construtores devem armazenar os dados fornecidos como parâmetros em fields privados. Estes fields devem ter seus valores expostos para fora da classe usando read-only properties. A classe Data deve ter também um método Imprimir(), utilizado para imprimir a data e hora representados pelo objeto. Este método recebe como parâmetro o formato de hora que deve ser utilizado para imprimir as horas (12 ou 24h). Se o objeto for construído sem informação de horário, este parâmetro não afeta a impressão. Os formatos da hora são do tipo int, mas devem ser representados por duas constantes na classe Data: FORMATO_12H e FORMATO_24H.

[ir para o código](/4Encapsulamento/Exercicio_2) </br>

 ## Exercícios Pasta Herança

 <b>Exercício 1</b> </br>
Crie duas classes: Ponto2D e Ponto3D. Ponto2D possui como fields as coordenadas x e y,
enquanto Ponto3D, além delas, também possui a coordenada z. Utilize a relação de herança
para representar estas classes. A respeito dos construtores, Ponto2D deve ter apenas um construtor, que recebe os valores de x e y como parâmetros (tipo double). Já Ponto3D também deve ter apenas um construtor, que deve receber x, y e z como parâmetros (também do tipo double). Dica: Se a relação de herança e a declaração dos construtores foram feitas corretamente, você deverá, obrigatoriamente, chamar o construtor da superclasse explicitamente. Ambas as classes devem implementar o método Imprimir(), que exibe no console os valores das coordenadas do objeto.

[ir para o código](/5Heranca/Exercicio_1) </br>

  <b>Exercício 2</b> </br>
O C# possui uma interface chamada ICloneable, que pode ser implementada por classes que
são capazes de gerar cópias de objetos. Classes que implementam esta interface devem
implementar o método Clone(). Dentro deste método é implementada a lógica para criar um
novo objeto com base no objeto original. Com base nisto, crie uma classe Porta que suporta a criação de novos objetos (cópia). Ela deve ter os fields altura (double), largura (double) e aberta (boolean). Também deve possuir os métodos Abrir(), Fechar() e os valores dos fields devem ser expostos para fora da classe através de read-only properties. Como uma porta pode criar outras cópias dela mesma, você deve implementar o método Clone() na classe, o qual deve criar um novo objeto com os valores dos atributos copiados e retorná-lo.

[ir para o código](/5Heranca/Exercicio_2) </br>

# Voltar no Polimorfismo

## Exercícios Pasta Excessão

  <b>Exercício 1</b> </br>
Crie uma classe ContaBancaria que possui um saldo como field e os métodos Sacar(double),
Depositar(double) e Transferir(double, ContaBancaria). Crie também duas exceções:
ValorInvalidoException e SaldoInsuficienteException.
A exceção ValorInvalidoException deve ser lançada se o valor utilizado nas operações de
depósito, saque ou transferência for igual ou inferior a 0. Já a exceção
SaldoInsuficienteException deve ser lançada se o valor de um saque ou transferência for
superior ao saldo disponível. No construtor de ValorInvalidoException é necessário fornecer
uma mensagem de erro e o valor inválido utilizado. E no construtor de
SaldoInsuficienteException é necessário fornecer uma mensagem de erro e também o saldo
disponível.
Crie uma classe que instancia duas contas e tenta realizar operações de depósito, saque e
transferência. Faça transações corretas e também transações que geram exceção. Quando a
transação gerar exceção, faça um catch da mesma, imprima a mensagem de erro e o valor
inválido utilizado (para ValorInvalidoException) ou o saldo disponível (para
SaldoInsuficienteException).

[ir para o código](/7Excessao/Exercicio_1) </br>

   <b>Exercício 2</b> </br>
Imagine que a sua aplicação é composta pelo seguinte código:<br>
object o = null;<br>
o.toString();<br>
Se você executar este código irá perceber que uma exceção será lançada. Identifique que
exceção é esta e altere este mesmo código para que ele exiba uma mensagem amigável de
erro e termine normalmente.

[ir para o código](/7Excessao/Exercicio_2) </br>


## Exercícios Pasta String
   <b>Exercício 1</b> </br>
Implemente um método Processar(), que recebe uma string s como parâmetro e retorna
uma nova string. Ele deve funcionar da seguinte forma: Se s for null, o método retorna null.
Se o tamanho de s for menor ou igual a 3, a string s convertida para maiúscula é
retornada.
 Se s tiver tamanho maior do que 3, além da conversão para maiúsculo, os 3 primeiros
caracteres devem ser substituídos por ??? antes da string ser retornada.
Para exemplificar o funcionamento do algoritmo, observe a tabela abaixo. Ela mostra diversas
formas de chamar o método e o retorno esperado em cada caso:
Invocação Retorno
Processar(null) null
Processar("ab") AB
Processar("abcdefg") ???DEFG
Dica: Você pode usar o método Substring() presente na classe String para poder retornar
os caracteres a partir da quarta posição.

[ir para o código](/8String/Exercicio_1/Program.cs) </br>

   <b>Exercício 2</b> </br>
Crie um enum chamado Bebida que pode assumir as opções Refrigerante, Suco e Agua,
com os respectivos valores 1, 2 e 3 associados.
Mostre no console as opções de bebidas existentes no enum e solicite ao usuário a digitação,
via console, de uma bebida (1, 2 ou 3). Mostre então o nome da bebida associada à opção
digitada.
Dica: Se você desejar converter a string retornada por Console.ReadLine() em um int,
você pode usar o método int.Parse() e fornecer a string como parâmetro. Caso a
conversão não possa ser realizada, esta chamada vai lançar uma exceção do tipo
FormatException

[ir para o código](/8String/Exercicio_2/Program.cs) 

## Exercícios Pasta Datas

   <b>Exercício 1</b> </br>
Criar uma classe que representa produtos que possua fields nome, peso(double) , e data de vencimento.
 [ir para o código](/9Data/Exercicio_1/Program.cs) 

<b>Exercício 2</b> </br>
Pedir ao usuário 6 números. Simular um sorteio da mega-sena 1 a 60. e comparar quantos o usuário acertou nesse sorteio.
 [ir para o código](/9Data/Exercicio_2/Program.cs) 

## Exercícios Pasta Generics


   <b>Exercício 1</b> </br>
Criar uma classe chamada ServiceFactory<T> que possua um método chamado NewInstance().Quando este método é chamado , ele cria um objeto do tipo T (invocando o construtor padrão, sem parâmentros) e retorna este objeto.Um detalhe importante é que apenas classes que implementam a interface IService (que também deve ser definida por você) devem ser aceitos na parametrização do tipo. Esta interface possui o método void Execute(), que deve ser implementado pelas classes que implementam esta interface.

 [ir para o código](/10Generics/Exercicio_1) 

<b>Exercício 2</b> </br>
Um triângulo é uma figura geométrica que possui três pontos. Crie as estruturas Triangulo e Ponto para representar estes conceitos.A estrutura Ponto possui as properties X,Y, e Z , que correspondem às coordenadas dos pontos, e tipo de dado das coordenadas deve ser parametrizado através do uso de generics . Já a estrutura Triangulo possui as properties P1, P2 e P3 , que correspondem aos três pontos que compõem o triângulo. Trangulo deve ser parametrizado com o uso de generics , e o tipo parametrizado deve ser utilizado nos pontos do triângulo.No método Main() da aplicação, crie difderentes triângulos e pontos com diversos tipos de dados a fim de validar a implementação realizada.

 [ir para o código](/10Generics/Exercicio_2/Program.cs)

## Exercícios Pasta Array

<b>Exercício 1</b>
Escreva um programa que solicite a entrada de 5 números inteiros via console, os quais deverão ser armazenados em um array.Depois itere sobre os elementos do array e imprima as seguintes indormações na tela: <br>
1) Média entre os elementos do array. <br/>
2)Maior valor presente no array <br/>
3)Menor valor presente no array <br/>
Para finalizar, ordene os elementos do array em ordem decrescente e imprima os elementos.

[ir para o código](/11Arrays/Exercicio_1/Program.cs)

<b>Exercício 2</b> <br>
Crie uma classe Carta que contenha o valor e o naipe (o naipe pode ser um enumeration).Crie também uma classe Baralho , que contém um array de cartas. A classe Baralho deve ter os seguintes métodos:<br/>
Carta[] Distribuir(int qtde): Distribui cartas do baralho . Aquantidade de cartasdistribuidas épassada como parâmetro, e o retorno do método é um array de cartas distribuídas. As cartas que são distribuídas deixam de fazer parte do baralho, pelo menos conceitumente.<br/>
void Embaralhar(): Embaralha as cartas do baralho . Cartas já distribuídas não fazem partedo processo de embaralhamento. <br/>
void MostrarCartas(): Imprime as cartas do baralho. Cartas já distribuídas não devem ser mostradas, pois não fazem mais parte do baralho.<br/>
Algumas considerações:
Aquantidade a ser distribuída no processo de distribuição deve ser maior que zero e menor ou igual ao número de cartas existentes no baralho.Caso a quantidade seja inválida, o método deve lançar uma exceção do tipo ArgumentOutRangeException.<br>
O processo de embaralhamento pode ser feito utilizando outro array , que recebe os elementos do array original de forma randomizada.<br/>
Durante a randomização no proesso de embaralhamento, é possível que a mesma carta seja sorteada mais de uma vez. Portanto é preciso controlar quais cartas já foram sorteadas e fazer esta checagem, para evitar situações deste tipo, uma dica é utilizarr um array para armazenar os índixes de elementos já sorteados.<br/>
Crie um método Main() na aplicação que instancia as cartas e  o baralho e faça chamadas aos métodos Distribuir(), Embaralhar() e MostrarCartas() para validar a implementação realizada.

[ir para o código](/11Arrays/Exercicio_2)

<b>Exercício 3</b><br>
Faça um programa que cria uma matriz de inteiros de duas dimensões e atribui valores a cada uma das posições desta matriz. O númerode linhas, de colunas e os valores a serem atribuídos para cada posição devem ser lidos via console.<br/>
Na sequência , imprima a matriz e calcule a soma dos elementos de cada coluna. Esta somadeve ser armazenada em um array. Por exemplo, se a matriz tem tamanho 3x4, você deverá criar um array de 4 posições, onde cada posição armazenará a soma dos 3 valores da coluna. Os valores das somas também deverão ser mostrados.

[ir para o código](/11Arrays/Exercicio_3/Program.cs)

## Exercício Pasta Coleções

<b>Exercício 1<b> <br/>

Crie uma classe Produto com dois fields: nome (string) e valor (double). Implemente a interface IComparable<T> de forma que os produtos possam ser em ordem crescente de valor quando necessário. Sobresreva os métodos Equals() e GetHashCode() e implemente a interface IEquatable<T>, considerando que produtos iguais são produtos que possuem o mesmo nome. E por último sobreescreva também o método ToString(), para mostrar uma representação amigável do produto quando ele for impresso no console <br/>
Na sequência crie uma classe Produtos, responsável por armazenar os produtos, criados . Esta classe tem um field produtos, do tipo ICollection<Produto>, e os métodos Adicionar(), que adiciona um produto à coleção, e ImprimirProdutos(), que imprime todos os produtos. <br/>

Crie uma aplicação que cria os seguintes produtos:<br/>
----------------------- <br/>
| Nome        | Valor | <br/>
| Laranja     | 2,50  | <br/>
| Laranja     | 2,70  | <br/>
| Maçã        | 1,45  | <br/>
| Mamão       | 4,95  | <br/>
| Limão       | 2,30  | <br/>
----------------------- <br/>

Experimente adicionar os produtos acima a coleção de diversos tipo, como List<T>, HashSet<T> e SortedSet<T>, e imprima os resultados. Lembre-se todos estes tipos podem ser atribuídos ao field produtos, pois todos são do tipo ICollection<T>. Procure perceber o que acontece com os elementos quando você muda o tipo de coleção na qual o produto está inserido, com relação à duplicidade de elementos e ordenação.

[ir para o código](/12Colecoes/Exercicio_1)

<b> Exercício 2 <b> <br/>

Crie um programa de votação, onde o usuário deve escolher a sua linguagem de programação preferida dentre as seguintes opções:<br/>
1. C# 
2. Java 
3. C 
4. C++ 
5. Python 

O programa solicita votos até que o número 0 seja escolhido. Quando isto acontecer, o programa deverá mostrar a lista de opções em uma tabela, juntamente com o número de votos de cada opção e a porcentagem de votos com relação ao total. A tabela também deve mostrar , no final , o total de votos realizados .<br/>

Por fim , o programa deve mostrar qual foi a linguagem de programação mais votada, bem como o número de votos que ela recebeu.<br>
Algumas considerações importantes: <br/>
- As opções disponíveis para votação devem ser armazenadas em um dicionário , onde o número da opção mapeado para a linguagemde programação corresponde.
- Os votos coletados devem ser armazenados em uma lista.
- Se uma opção inválida for digitada, o programa deverá mostrar uma mensagem de erro e solicitar novamente o voto.

[ir para o código](/12Colecoes/Exercicio_2)



