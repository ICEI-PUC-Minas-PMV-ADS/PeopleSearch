# Arquitetura da Solução

Nesse item do projeto demonstraremos os detalhes técnicos de implementação da arquitetura de solução a ser aplicada pelo time de desenvolvedores demonstrando os componentes e detalhes que compõem a parte.
Após as especificações dos requisitos, foram desenvolvidos o Diagrama de Caso de Uso, citado acima, Diagrama de Classes, Modelo de Entidade Relacional e o Projeto de Banco de Dados. Essas arquiteturas possibilitam o melhor entendimento do sistema, especificando o fluxo das informações de forma clara e objetiva, visando o entendimento de como o sistema deve se comportar.


## Diagrama de Classes

 <img src="DiagramaDeClasses.jpg" class="Diagrama" alt="Diagrama de Classes">
O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Projeto da Base de Dados

 Um projeto de banco de dados é subdividido em várias etapas onde o objetivo é a criação de um banco de dados otimizado e que atenda as expectativas do cliente. E nesse contexto, os modelos de dados são muito importantes e foram extraídos através dos requisitos coletados e o projeto conceitual e lógico.
 Nesta fase trabalhamos com requisitos de informação e regras de negócio do domínio do problema; Não nos preocupamos com aspectos físicos do banco de dados ou da tecnologia utilizada; Buscamos o entendimento do negócio junto aos usuários.


## Tecnologias Utilizadas

Os componentes que fazem parte da solução são apresentados na Figura que se segue:
Navegador - Interface básica do sistema 
Páginas Web - Conjunto de arquivos HTML, CSS, JavaScript e imagens que implementam as funcionalidades do sistema.
Local Storage - armazenamento mantido no Navegador, onde são implementados bancos de dados baseados em JSON. São eles: 
Cadastros - campo para inserção de informações pessoais e interesses na plataforma
Àreas de Interesse - cadastramento de opções de interesse que será ofertado ou criado pelo próprio usuário.
News API - plataforma que permite o acesso às notícias exibidas no site.


## Hospedagem

 O site utilizará a plataforma do GitHub  como ambiente de hospedagem do projeto. Será mantido no ambiente da URL: https://github.com/ICEI-PUC-Minas-PMV-ADS/PeopleSearch sendo incorporado ao próprio repositório que será criado no GitHub.

