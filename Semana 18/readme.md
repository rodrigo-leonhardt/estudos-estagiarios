# Exercícios

1) No exercício desta semana, a API desenvolvida na semana 10 será utilizada. 
Considerando que o endereço da API é http://localhost:5204 e o endereço da aplicação Angular da semana atual é http://localhost:4200, as chamadas serão bloqueadas por políticas CORS. 
Para que o acesso seja liberado, inclua a linha destacada abaixo no arquivo **Program.cs** da Semana 10.

```
  var app = builder.Build();

  app.UseSwagger();
  app.UseSwaggerUI();

  //Linha abaixo permite acesso de outras origens
  app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

  app.MapControllers();

  app.Run();
```

Após realiza a alteração, mantenha a API em execução para utilização pela solução Angular

2) Altere os trechos destacados no arquivo **sistema.service.ts** para que a API seja consumida a fim de listar todos os sistemas já cadastrados e incluir um novo sistema.

3) Modificar o trecho destacado no arquivo **app.component.ts** para utilizar os métodos disponibilizados pelo serviço acima. 
No método **incluirSistema**, após a inclusão bem sucedida, o método **listarSistemas** deve ser invocado. Isso atualizará em tela os sistemas atualmente cadastrados.
No método **pesquisarSistema** uma mensagem deve exibir o nome do sistema pesquisado (alert) quando a chamada for bem sucedida. Quando a chamada falhar a descrição do erro deve ser exibida (alert).

4) Após concluir as alterações, interaja com a aplicação pelo navegador para realizar as seguintes atividades:

#### Incluir sistemas

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2018/Assets/img01.png)

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2018/Assets/img02.png)

#### Pesquisar sistema existente

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2018/Assets/img03.png)

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2018/Assets/img04.png)

#### Pesquisar sistema inexistente

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2018/Assets/img05.png)

![img](https://raw.githubusercontent.com/rodrigo-leonhardt/estudos-estagiarios/main/Semana%2018/Assets/img06.png)

# Referências

#### CORS
- https://developer.mozilla.org/pt-BR/docs/Web/HTTP/CORS
- https://docs.microsoft.com/pt-br/aspnet/core/security/cors

#### HttpClient
- https://angular.io/guide/http
- https://angular.io/tutorial/toh-pt4
- https://angular.io/tutorial/toh-pt6
- https://angular.io/guide/observables
- https://angular.io/guide/comparing-observables
- https://youtu.be/Tu7wtZyTwdw
- https://youtu.be/Bg47WHVc020
- https://youtu.be/eJf_-pv6C34
- https://youtu.be/2TmYoPmPgdQ