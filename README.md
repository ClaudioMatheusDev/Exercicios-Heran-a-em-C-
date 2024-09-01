# Exercícios de Herança em C#

Este repositório contém implementações de exercícios relacionados à herança em C#. Vamos explorar algumas classes e suas relações. A seguir, detalho cada um dos exercícios:

## 1. Funcionário e suas subclasses

### Classe `Funcionário`

A classe `Funcionário` representa um funcionário genérico e possui os seguintes atributos e métodos:

- **Atributos**:
  - `Nome`: Nome do funcionário.
  - `Salário`: Salário base do funcionário.

- **Métodos**:
  - `addAumento(double valor)`: Adiciona um aumento ao salário.
  - `ganhoAnual()`: Calcula o ganho anual do funcionário.
  - `exibeDados()`: Imprime os valores do funcionário.

### Classe `Assistente`

A classe `Assistente` herda da classe `Funcionário` e adiciona o atributo `Número de Matrícula`. Além disso, sobrescreve o método `exibeDados()` para incluir o número de matrícula.

### Classes `Técnico` e `Administrativo`

As classes `Técnico` e `Administrativo` também herdam da classe `Funcionário`. Cada uma delas possui características específicas:

- `Técnico`: Possui um bônus salarial.
- `Administrativo`: Possui um turno (dia ou noite) e um adicional noturno.

Ambas as classes sobrescrevem o método `ganhoAnual()` para calcular o ganho anual considerando suas particularidades.

## 2. Diagramas de Classes
Implemente os diagramas de classes abaixo:

![image](https://github.com/user-attachments/assets/9d87f123-e906-4552-bda9-f162c3b56211)


## 3. Classe `Imóvel` e subclasses

### Classe `Imóvel`

A classe `Imóvel` representa um imóvel com os seguintes atributos:

- `Endereço`: Endereço do imóvel.
- `Preço`: Preço base do imóvel.

### Classe `Novo`

A classe `Novo` herda da classe `Imóvel` e adiciona um adicional no preço. Ela possui métodos para acessar e imprimir esse valor adicional.

### Classe `Velho`

A classe `Velho` também herda da classe `Imóvel` e possui um desconto no preço. Ela também oferece métodos para acessar e imprimir o desconto.

---
