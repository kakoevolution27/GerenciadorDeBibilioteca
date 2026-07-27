Aqui está o guia de requisitos para o **BiblioTech**.

Os **Requisitos Funcionais (RF)** definem *o que* o sistema deve fazer (as ações do usuário). Já os **Requisitos Não Funcionais (RNF)** definem *como* o sistema deve ser construído, forçando o uso dos fundamentos do C# que você quer praticar.

---

## 1. Requisitos Funcionais (O que o sistema faz)

Estas são as funcionalidades que você precisará testar no Console para provar que o sistema funciona.

| ID | Funcionalidade | Descrição da Regra de Negócio |
| --- | --- | --- |
| **RF01** | Gestão de Acervo | Permitir adicionar, consultar e remover Livros e Revistas da biblioteca. |
| **RF02** | Gestão de Usuários | Permitir cadastrar usuários com um identificador único (ID). |
| **RF03** | Empréstimo de Item | Registrar a saída de um livro, validando se ele está disponível. |
| **RF04** | Bloqueio de Empréstimo | Impedir que um usuário com livros em atraso faça novos empréstimos. |
| **RF05** | Devolução de Item | Registrar o retorno do item e liberar o status para "disponível". |
| **RF06** | Cálculo de Atrasos | Ao devolver um item, avisar se houve atraso (baseado na data de devolução). |
| **RF07** | Relatórios de Acervo | Exibir todos os itens ordenados por ano de publicação ou agrupados por autor. |

---

## 2. Requisitos Não Funcionais (Como o sistema faz)

Aqui está a verdadeira "prova de fogo" do C#. Estas regras garantem que você não vai programar tudo em um único arquivo de forma procedural.

| ID | Pilar do C# | Restrição / Regra Técnica |
| --- | --- | --- |
| **RNF01** | Arquitetura | O código deve ser separado em 3 projetos (Domain, Data, ConsoleApp). |
| **RNF02** | Orientação a Objetos | `Livro` e `Revista` devem herdar de uma classe base abstrata `ItemAcervo`. |
| **RNF03** | Imutabilidade | O registro histórico de um empréstimo deve ser feito usando um `record`. |
| **RNF04** | Tratamento de Erros | Validações de negócio devem disparar Exceções Customizadas (ex: `ItemIndisponivelException`). |
| **RNF05** | Generics e Interfaces | O salvamento de dados deve usar uma interface genérica `IRepositorio<T>`. |
| **RNF06** | Assincronismo | A leitura e escrita dos arquivos JSON locais deve usar `async`, `await` e `Task`. |
| **RNF07** | Eventos e Delegates | O sistema deve disparar um `Event` do C# toda vez que um empréstimo em atraso for detectado. |
| **RNF08** | Manipulação de Dados | Todos os relatórios (buscas e ordenações) do RF07 devem ser feitos exclusivamente via `LINQ`. |

---

> **Dica de Ouro:** Não tente abraçar todos os requisitos de uma vez. Comece pelo núcleo estrito: crie o Domínio (RNF02 e RNF03), depois a Persistência Genérica (RNF05 e RNF06) e, por fim, amarre as regras na classe de serviço.
## 1. Requisitos Funcionais (O que o sistema faz)

Estas são as funcionalidades que você precisará testar no Console para provar que o sistema funciona.

| ID | Funcionalidade | Descrição da Regra de Negócio |
| --- | --- | --- |
| **RF01** | Gestão de Acervo | Permitir adicionar, consultar e remover Livros e Revistas da biblioteca. |
| **RF02** | Gestão de Usuários | Permitir cadastrar usuários com um identificador único (ID). |
| **RF03** | Empréstimo de Item | Registrar a saída de um livro, validando se ele está disponível. |
| **RF04** | Bloqueio de Empréstimo | Impedir que um usuário com livros em atraso faça novos empréstimos. |
| **RF05** | Devolução de Item | Registrar o retorno do item e liberar o status para "disponível". |
| **RF06** | Cálculo de Atrasos | Ao devolver um item, avisar se houve atraso (baseado na data de devolução). |
| **RF07** | Relatórios de Acervo | Exibir todos os itens ordenados por ano de publicação ou agrupados por autor. |

---

## 2. Requisitos Não Funcionais (Como o sistema faz)

Aqui está a verdadeira "prova de fogo" do C#. Estas regras garantem que você não vai programar tudo em um único arquivo de forma procedural.

| ID | Pilar do C# | Restrição / Regra Técnica |
| --- | --- | --- |
| **RNF01** | Arquitetura | O código deve ser separado em 3 projetos (Domain, Data, ConsoleApp). |
| **RNF02** | Orientação a Objetos | `Livro` e `Revista` devem herdar de uma classe base abstrata `ItemAcervo`. |
| **RNF03** | Imutabilidade | O registro histórico de um empréstimo deve ser feito usando um `record`. |
| **RNF04** | Tratamento de Erros | Validações de negócio devem disparar Exceções Customizadas (ex: `ItemIndisponivelException`). |
| **RNF05** | Generics e Interfaces | O salvamento de dados deve usar uma interface genérica `IRepositorio<T>`. |
| **RNF06** | Assincronismo | A leitura e escrita dos arquivos JSON locais deve usar `async`, `await` e `Task`. |
| **RNF07** | Eventos e Delegates | O sistema deve disparar um `Event` do C# toda vez que um empréstimo em atraso for detectado. |
| **RNF08** | Manipulação de Dados | Todos os relatórios (buscas e ordenações) do RF07 devem ser feitos exclusivamente via `LINQ`. |

---

> **Dica de Ouro:** Não tente abraçar todos os requisitos de uma vez. Comece pelo núcleo estrito: crie o Domínio (RNF02 e RNF03), depois a Persistência Genérica (RNF05 e RNF06) e, por fim, amarre as regras na classe de serviço.