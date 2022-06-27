# Exercícios

Este exercício propõe a utilização dos conteúdos aprendidos nas semanas anteriores para constuir uma aplicação frontend (Angular) que se comunicará com uma API (C#) para realizar operações CRUD. 

Os respectivos projetos foram pré-configurados e disponibilizados nos diretórios **Exercicio/Api** e **Exercicio/Frontend**.

Os seguintes requisitos devem ser atendidos:

### API

1) Um modelo deve ser criado para representar um **Livro**, com as propriedades **Codigo** (chave), **Titulo**, **Autor** e **Paginas**.

2) Um serviço deve ser criado para realizar as operações de **Inserção**, **Leitura**, **Modificação** e **Remoção** relativas ao modelo citado, interagindo com o banco de dados através do **DatabaseContext** já criado.

3) Um controlador deve ser criado para expor as operações do serviço citado, através de chamadas à API.

### Frontend

1) A aplicação consiste em duas telas. A primeira servirá para exibição dos livros cadastrados, enquanto a segunda servirá para preenchimento dos dados que serão inseridos ou modificados. Devem ser aplicadas rotas para navegar entre as telas.

2) A tela de exibição dos livros cadastrados deve utilizar o mat-table (Material) para listagem no formato de tabela. Em cada linha devem haver botões para modificar e remover o livro em questão, conforme inspiração abaixo.

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2019/Assets/imgTabela.png)

Também deve haver um botão, fora da tabela, para incluir um novo livro.

3) A tela de dados do livro deve utilizar os recursos disponíveis no Material, como matInput, mat-form-field, mat-label, mat-button, etc.

4) A tela de dados do livro deve utilizar formulário (template-driven ou reactive) para exigir o preenchimento de campos obrigatórios.

5) Um modelo deve ser criado para representar um **Livro**, com as propriedades necessárias.

6) Um serviço deve ser criado para realizar as operações necessárias, relativas ao modelo citado, interagindo com a API.

# Referências

#### Google
- https://www.google.com/