# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com a participação dos usuários em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

Rafaela Alves Guimarães tem 30 anos, é empreendedora e dona de uma startup de sucesso que atua na área de crowdfunding. Gosta de agilizar e facilitar processos além da vida profissional. Precisa de momentos de descontração devido aos desgastes advindos do trabalho. Já se envolveu em assuntos não desejados, pela necessidade de se socializar, mas sem saber a motivação das pessoas que procurou. Não possui familiares e tem uma rotina cansativa de trabalho. Quase nunca consegue sair aos finais de semana. Para ela, esses momentos devem ser o menos desgastante possível.

Fernando Almeida tem 26 anos, é estudante de Engenharia de Software e estagiário de uma empresa que atua na criação de games. Tem seu mindset voltado para automatização de processos em detrimento de processos manuais e demorados. Já possui contato direto com a área da tecnologia e acredita que ela seja uma facilitadora de diversas situações na vida dos indivíduos. Seus amigos são de outras áreas, com isso ele não consegue um bom bate papo sobre o assunto que ele realmente gosta de conversar. É uma pessoa extremamente criativa e prática. Gostaria que cada vez mais a tecnologia fosse utilizada no dia-a-dia com o intuito, principalmente, de democratizar, disponibilizar informações e acelerar processos a partir de soluções inteligentes.

Luiz Gonçalves tem 43 anos, é garçom e tem contato com vários tipos de pessoas de diversos lugares diferentes e conversa sobre vários temas distintos. Por várias vezes foi mal interpretado quando se aproximou e puxou papo. Trabalha como garçom há mais de 10 anos e tem que ser gentil e agradável para que seu trabalho seja bem aceito, mas sem se aproximar muito.

Marisa Bastos tem 56 anos, é coach. Tem como motivações o maior retorno financeiro e ter acesso a pessoas e ser direcionada ás necessidades de acordo com o tema do bate papo. Tem como frustações a procura de clientes e vários feedbacks. Ela administra sua agência sempre prezando por alternativas atrativas  e facilitadoras para seus clientes.




## Histórias de Usuários

A fim de buscar mais informações sobre os motivos e causas de uso dessas pessoas à plataforma a ser desenvolvida, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Rafaela A. Guimarães| Um site onde possa achar pessoas com o mesmo interesse em moda que eu.| Consumir mais conteúdo de moda             |
|Fernando Almeida    | Formar um time para jogos.         | Gosto de jogar nas distrações do dia a dia. |
|Marisa Bastos       | Um amigo(a) para assistir em grupo, programas de culinária.| Construir laços com o mesmo interesse.|
|Luiz Gonçalves      | Encontrar pessoas que são fãs de sua banda favorita.| Encontrar pessoas que são fãs de sua banda favorita. |


## Requisitos

Os propósitos funcionais da plataforma serão denotados por intermédio da apresentação de duas categorias diferentes de requisitos (funcionais e não funcionais) que indicará as características que a plataforma demonstrará de maneira total. Sendo apresentados nas tabelas a seguir.


### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve conter uma página inicial com informações sobre os principais objetivos e propostas para os usuários. | ALTA | 
|RF-002| O site deve conter uma página de cadastro dos usuários e suas principais características.   | ALTA |
|RF-003| O site deve conter uma página de Login para os usuários acessarem de forma instantânea .   | ALTA |
|RF-004| O site deve contar uma página de suporte aos desenvolvedores.   | ALTA |
|RF-005| O site deve conter uma página “sobre” com as principais informações e propostas do site para os usuários.   | ALTA |
|RF-006| O site deve apresentar a opção de atualizar e remover informações de cadastro dos usuários.   | ALTA |
|RF-007| O site deve conter uma página de criação e busca de grupos e pessoas com interesses similares.   | ALTA |
|RF-008| O site deve conter página de contato para usuários interessados em saber mais sobre a aplicação, propor sugestões e sanar quaisquer dúvidas que venham apresentar.   | ALTA |
|RF-009| O site deve disponibilizar ao usuário a opção de recebimento de e-mails informativos sobre interesses específicos da aplicação, dicas e outros.   | BAIXA |
|RF-010| O Site irá disponibilizar ao usuário a opção de se desvincular da plataforma, endo assim, o registro de e-mail e qualquer envio automático serão desabilitados.   | BAIXA |

### Requisitos não Funcionais

Já os requisitos não funcionais não estão relacionados diretamente com os serviços específicos do sistema oferecidos aos seus usuários. Eles estão relacionados com o nível de serviço esperado para o melhor funcionamento do software como um todo. 
O descritivo abaixo representa o escopo não funcional que a plataforma atenderá. 


|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O Site deve ser estruturado de forma a facilitar a utilização por pessoas de quaisquer idades. | ALTA | 
|RNF-002| O Site deve conter tags auxiliares em quaisquer imagens, vídeos e componentes visuais, a fim de permitir a utilização de leitores para pessoas com baixa visão. |  ALTA |
|RNF-003| O Site deverá estar apto a funcionar em dispositivos móveis, utilizando técnicas de responsividade.|  ALTA |
|RNF-004| As informações de cadastro dos usuários deverão ser armazenadas para fins de segurança. |  ALTA |
|RNF-005| Deverá ser implementado um sistema de verificação de autenticidade para os usuários. |  ALTA |
|RNF-006| O Site será visualmente leve e evitar cores muito contrastantes para um maior conforto do usuário. | MEDIA |
|RNF-007| O Site irá utilizar de cache no navegador para facilitar o retorno do usuário a etapas anteriores a que se encontravam. |  BAIXA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 11/12/2022. |
|RE-02| O aplicativo deve restringir aplicações de frontend e backend.       |
|RE-03| O projeto deve ser realizado pela equipe e não terceirizado por outros  membros fora da instituição.       |
|RE-04| O projeto deve seguir normas de privacidade da web e mostrar termos de política de privacidade e uso da ferramenta.        |

## Diagrama de Casos de Uso

O diagrama contempla as principais ligações previstas entre casos de uso e atores e permite detalhar os Requisitos Funcionais identificados na etapa de elicitação, como segue na figura X abaixo: 

<img src="componentes.png" alt="some text" width=60 height=40>