# Softplan - Desafio Técnico em .NET (Gustavo Figueira Lopes)
Projeto com as duas APIs desenvolvidas para o processo seletivo.

## Primeira API
1. Endpoint: Apresenta a taxa de juros padrão fixa no código (0.01), sendo definida nas configurações da aplicação no **appsettings.json**.
```
api/InterestRate/GetDefault
```

## Segunda API
1. Endpoint: Calcula os Juros Compostos com base no **valor inicial**, **tempo (em meses)** e a **taxa de juros** padrão obtida através da Primeira API.
```
api/CompoundInterest/Calculate?initialValue=100&period=5
```

	- A taxa de juros (**interestRate**) também pode ser fornecida na query, mas é um comando opcional.
```
api/CompoundInterest/Calculate?initialValue=100&period=5&interestRate=0.2
```
2. Endpoint: Retorna a [URL](https://github.com/GustavoFigueira/Softplan-Desafio-Tecnico) do projeto no **Github**.
```
api/About/ShowMeTheCode
```

### Extras 1
O projeto base foi construído utilizando conceitos provinientes de DDD, Clean Code e Clean Architeture.  Conta também com as seguintes _features_:
* Documentação com **Swagger**.
* **Docker**.
* TDD - Testes Unitários e Testes de Integração com **xUnit**.

> A camada de banco foi iniciada, mas está aberta para implementação visto que o enunciado não explicita esta necessidade. Os cálculos e buscas são feitas inicialmente em memória.

### Extras 2
Além disso, foi criado um app feito em **Flutter** que consome as APIs.
[Repositório no Github](https://github.com/GustavoFigueira/Softplan-Challenge-App)

![Print 1](./docs/app1.png?raw=true "Print App")
![Print 2](./docs/app2.png?raw=true "Print App")


