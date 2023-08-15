# Exercício 01 – C# e Orientação a Objetos

Este repositório contém a implementação de um exercício de programação em C# que envolve conceitos de orientação a objetos. O exercício envolve a criação de classes e interfaces para modelar um sistema bancário simples.

## Classes e Interfaces
 
### Interface IContaInvestimento
- Método: `CalculaRetornoInvestimento()`

### Enum TipoConta
- Valores: Comum, Especial, Premium

### Classe Abstrata Conta
- Namespace: `Fiap.Banco.Model`
- Propriedades:
  - Agencia: int
  - Numero: int
  - DataAbertura: DateTime
  - Saldo: decimal
- Métodos abstratos:
  - `Depositar(decimal valor)`
  - `Retirar(decimal valor)`

### Classe ContaCorrente
- Namespace: `Fiap.Banco.Model`
- Herda de: Conta
- Propriedades:
  - Tipo: Enum TipoConta
- Métodos:
  - `Depositar`: adiciona valor ao saldo
  - `Retirar`: lança uma exceção se a conta for comum e o saldo ficar negativo após o saque

### Classe ContaPoupanca
- Namespace: `Fiap.Banco.Model`
- Herda de: Conta
- Implementa: IContaInvestimento
- Propriedades:
  - Taxa: decimal
- Fields readonly (somente leitura):
  - `_rendimento`: decimal
- Construtor: recebe um valor decimal e atribui ao field `_rendimento`
- Métodos:
  - `Depositar`: atribui valor ao saldo
  - `Retirar`: verifica se o saldo é suficiente e desconta a Taxa de retirada
  - `CalculaRetornoInvestimento`: retorna o valor do saldo vezes o rendimento

## Instruções de Uso

1. Clone este repositório em sua máquina local.
2. Abra o projeto em sua IDE favorita que suporte C# (por exemplo, Visual Studio).
3. Compile e execute o programa.
4. Serão criadas uma instância de ContaCorrente e uma instância de ContaPoupanca com valores iniciais para suas propriedades.
5. Teste os métodos de retirada para verificar exceções, conforme o enunciado do exercício.

Lembre-se de que este exercício visa praticar os conceitos de orientação a objetos e a implementação das classes e métodos mencionados. Sinta-se à vontade para explorar e expandir o código conforme sua compreensão dos conceitos aumenta.

Divirta-se programando e aprendendo!
