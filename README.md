# Sistema de Orçamento - C# (.NET)

---

## Sobre o Projeto

Este projeto consiste em um sistema desktop desenvolvido em **C# (WinForms)** para **automatização de orçamentos de peças de comunicação visual**.

A aplicação foi criada com o objetivo de resolver um problema real:  
**reduzir erros manuais, agilizar cálculos e gerar documentos profissionais automaticamente.**

---

## Funcionalidades

 **Cálculo automático de orçamento** baseado em:

- Dimensão da peça (largura x comprimento)
- Tipo de material
- Tipo de máquina (Router ou Laser)
- Quantidade
- Fator de ajuste

 **Adição de múltiplos itens** em um único orçamento

 **Geração automática de PDF** contendo:

- Dados do cliente  
- Data do orçamento  
- Lista de itens detalhada  
- Valor total formatado  

 **Validação de campos obrigatórios**

---

##  Tecnologias Utilizadas

- **C#**
- **.NET (WinForms)**
- **iText (PDF generation)**

---

##  Estrutura do Projeto

```bash
sistemaOrcamento/
│
├── Form1.cs              # Interface e fluxo principal (UI)
├── ItemOrcamento.cs      # Modelo de dados
├── PdfService.cs         # Serviço responsável pela geração do PDF
└── Program.cs
```

---

##  Regra de Negócio (Cálculo)

O cálculo do orçamento segue a seguinte lógica:

### 1. Cálculo da área

```csharp
areaM2 = largura * comprimento;
```

### 2. Conversão para cm²

```csharp
areaCm2 = areaM2 * 10000;
```

### 3. Ajuste baseado na chapa

```csharp
ajuste = valorChapaAtual / valorChapaPadrao;
```

### 4. Cálculo final

```csharp
valorFinal = areaCm2 * valorCm2 * quantidade * fator;
```

### 5. Regra adicional

- **Máquina Laser aplica multiplicador no custo**

---

##  Geração de PDF

A geração de PDF é realizada utilizando a biblioteca **iText**, permitindo:

- Criação de documentos estruturados  
- Tabelas dinâmicas  
- Formatação de texto (negrito, alinhamento, etc.)  
- Cálculo automático do valor total  

---

##  Aprendizados

Durante o desenvolvimento, foram aplicados conceitos importantes como:

- **Separação de responsabilidades (Service Layer)**
- **Organização de código orientado a objetos**
- **Manipulação de dados e cálculos dinâmicos**
- **Integração com bibliotecas externas**
- **Validação de entrada de dados**

---

##  Melhorias Futuras

-  Evoluir para **API REST com ASP.NET Core**
-  Integração com **banco de dados**
-  Implementação de **arquitetura em camadas (Service/Repository)**
-  Migração da interface para **WPF ou aplicação Web**
-  Exportação para outros formatos (Excel, etc.)

---

## Preview

> Adicione aqui prints do sistema e do PDF gerado

---

##  Como Executar o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/seu-repo.git
```

### 2. Abra no Visual Studio

### 3. Execute o projeto

```bash
Ctrl + F5
```

---

##  Contato

- LinkedIn: https://www.linkedin.com/in/devvitorfernandes/  
- GitHub: https://github.com/vitorDev404

---

##  Considerações Finais

Este projeto representa um passo importante na minha evolução como desenvolvedor, principalmente na construção de soluções aplicadas a problemas reais.
