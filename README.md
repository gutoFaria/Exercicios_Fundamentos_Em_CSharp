# Exercicios_Fundamentos_Em_CSharp

## Exercícios Pasta Conceito

<b> Exercício 1 </b> </br>
Escreva um programa que solicita que sejam digitadas três notas de um aluno e um peso para
cada nota. Calcule e imprima a média do aluno. [ir para o código](/1Conceitos/Exercicio_1/Program.cs) <br/>

<b> Exercício 2 </b> </br>
Escreva um programa semelhante ao do exercício 1, mas agora o número de notas e pesos
pode variar. O usuário deve digitar quantas notas ele desejar e, para parar, a nota -1 deve ser
digitada. Neste momento a média das notas e pesos digitados anteriormente deve ser
calculada e o resultado impresso na tela.[ir para o código](/1Conceitos/Exercicio_2/Program.cs)</br>

<b> Exercício 3 </b> </br>
1. Imprima todos os números de 10 a 25. <br/>
2. Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.). <br/>
3. Começando em 0, imprima os números seguintes, enquanto a soma dos números já
impressos for menor que 100. <br/>
4. Imprima a tabuada do 9 (até o décimo valor).[ir para o código](/1Conceitos/Exercicio_3/Program.cs) </br>

<b>Exercício 4</b> </br>
Escreva um programa que calcule o fatorial de 10. [ir para o código](/1Conceitos/Exercicio_4/Program.cs) </br>

<b>Exercício 5</b> </br>
Imprima os 15 primeiros números da série de Fibonacci. A série de Fibonacci possui a seguinte sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc. Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento
vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3). [ir para o código](/1Conceitos/Exercicio_5/Program.cs) </br>

<b>Exercício 6</b> </br>
Escreva um programa que imprime na saída os valores assumidos por x. Esta variável x deve
iniciar com algum valor inteiro, fornecido pelo usuário. Se x for par, x deve receber o valor dele mesmo somado com 5. Já se x for ímpar, x deve receber o valor dele multiplicado por 2. O programa termina assim que x for maior que 1000. Por exemplo, para x = 10, a saída deve ser: 15, 30, 35, 70, 75, 150, 155, 310, 315, 630, 635, 1270. Faça este exercício usando blocos if e depois usando blocos switch. [ir para o código](/1Conceitos/Exercicio_6/Program.cs) </br>

<b>Exercício 7</b> </br>
Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou
inválida. Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve
fornecer os valores para estas variáveis via console. Considerar que fevereiro pode ter
somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999. [ir para o código](/1Conceitos/Exercicio_7/Program.cs) </br>

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
· posicao(int): indica em qual posição está o ponteiro (1, 2, 3, 4, etc.).  [ir para o código](/2ClasseEstrutura/Exercicio_1/Program.cs) </br>

<b>Exercício 2</b> </br>
Pratica básica de struct </br>
Crie a estrutura (struct) Fracao, que representa uma fração matemática. Esta estrutura deve ser capaz de armazenar o numerador e o denominador da fração. Ela ainda deve ter um método que recebe uma fração como parâmetro, multiplica ambas as frações, e retorna uma nova fração como resultado. Crie um programa simples que instancia duas frações, define seus valores, calcula o valor da multiplicação entre elas e mostra o resultado. [ir para o código](/2ClasseEstrutura/Exercicio_2/Program.cs) </br>

### Exercícios Pasta Objetos
<b>Exercício 6</b> </br>
Crie classes que representam as figuras geométricas: Triangulo, Quadrado, Circunferencia e Trapezio. Cada uma destas classes deve ter um método para calcular a sua área, com a seguinte assinatura: double CalcularArea().</br>
Perceba que o método CalcularArea() não recebe parâmetros. Portanto todos os dados necessários devem ser armazenados no objeto da classe em fields, para depois serem utilizados pelo método. [ir para o código](/1Objetos/Exercicio_1/Program.cs) </br>