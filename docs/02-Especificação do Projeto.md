# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

Rafaela Alves Guimarães tem 30 anos, é empreendedora e dona de uma startup de sucesso que atua na área de crowdfunding. Gosta de agilizar e facilitar processos além da vida profissional. Precisa de momentos de descontração devido aos desgastes advindos do trabalho. Já se envolveu em assuntos não desejados, pela necessidade de se socializar, mas sem saber a motivação das pessoas que procurou. Não possui familiares e tem uma rotina cansativa de trabalho. Quase nunca consegue sair aos finais de semana. Para ela, esses momentos devem ser o menos desgastante possível.

Fernando Almeida tem 26 anos, é estudante de Engenharia de Software e estagiário de uma empresa que atua na criação de games. Tem seu mindset voltado para automatização de processos em detrimento de processos manuais e demorados. Já possui contato direto com a área da tecnologia e acredita que ela seja uma facilitadora de diversas situações na vida dos indivíduos. Seus amigos são de outras áreas, com isso ele não consegue um bom bate papo sobre o assunto que ele realmente gosta de conversar. É uma pessoa extremamente criativa e prática. Gostaria que cada vez mais a tecnologia fosse utilizada no dia-a-dia com o intuito, principalmente, de democratizar, disponibilizar informações e acelerar processos a partir de soluções inteligentes.

Luiz Gonçalves tem 43 anos, é garçom e tem contato com vários tipos de pessoas de diversos lugares diferentes e conversa sobre vários temas distintos. Por várias vezes foi mal interpretado quando se aproximou e puxou papo. Trabalha como garçom há mais de 10 anos e tem que ser gentil e agradável para que seu trabalho seja bem aceito, mas sem se aproximar muito.

Marisa Bastos tem 56 anos, é coach. Tem como motivações o maior retorno financeiro e ter acesso a pessoas e ser direcionada ás necessidades de acordo com o tema do bate papo. Tem como frustações a procura de clientes e vários feedbacks. Ela administra sua agência sempre prezando por alternativas atrativas  e facilitadoras para seus clientes.




## Histórias de Usuários

A fim de buscar mais informações sobre os motivos e causas de uso dessas pessoas à plataforma a ser desenvolvida, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Rafaela A. Guimarães| Um site onde possa achar pessoas com o mesmo interesse em moda que eu| Consumir mais conteúdo de moda             |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |


> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
