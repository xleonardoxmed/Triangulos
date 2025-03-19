
# 🛠️ Classificador de Triângulos
Este é um projeto simples em C# que permite ao usuário informar os valores dos lados de um triângulo e, com base nessas informações, verifica se os valores formam um triângulo válido e qual é o seu tipo: Equilátero, Isósceles ou Escaleno.

![](https://i.imgur.com/6UYG3SE.gif)

# 📌 Funcionalidades
Validação de triângulos com base na regra matemática (a soma de dois lados deve ser sempre maior que o terceiro).

Permite executar múltiplas verificações até o usuário decidir sair.

# 🚀 COMO FUNCIONA?

O console solicitará os valores dos lados X, Y e Z. Depois mostrará se é um triângulo válido e o tipo correspondente.

# ⚙ Estrutura do Projeto
A soma de quaisquer dois lados deve ser maior que o terceiro lado.

Se os três lados forem iguais → Equilátero.

Se apenas dois lados forem iguais → Isósceles.

Se todos os lados forem diferentes → Escaleno.

# 📄 Exemplo de Uso

```
-------------------------------
Classificador de Triângulos
-------------------------------
Informe o valor do lado X: 5
Informe o valor do lado Y: 5
Informe o valor do lado Z: 5
-------------------------------
Valores Informados
-------------------------------
Lado X: 5
Lado Y: 5
Lado Z: 5
-------------------------------
O triângulo é Equilátero
-------------------------------
Deseja recomeçar?:  (S/N)
```

# COMO USAR?

Clone o Repositório
```
git clone https://github.com/xleonardoxmed/Triangulos.git
```
Navegue até a pasta raiz da solução
```
cd Triangulos
```
Restaure as dependências
```
dotnet restore
```
Navegue até a pasta do projeto
```
cd Triangulos.ConsoleApp
```
Execute o projeto
```
dotnet run
```