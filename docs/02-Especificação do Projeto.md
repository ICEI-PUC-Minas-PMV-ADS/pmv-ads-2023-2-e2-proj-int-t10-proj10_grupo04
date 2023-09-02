# Especificações do Projeto

 O projeto a ser desenvolvido basea-se em um problema cotidiano do publico alvo, pessoas que necessitam dos cuidados de limpeza automotiva.
 Muitas vezes por falta de tempo ou até conhecimento necessessário para um bom cuidado com seu carro, as pessoas buscam um serviço de lava jato nas redondezas de sua residencia, mas nem sempre podem esperar pelo tempo de execução do serviço e também pela disponibilidade do profissional. Com estes dados em mente, pensamos em ofertar o serviço diretamente para nossos clientes, que, poderão agendar um horário/data para receber em seu domicílio uma visita especializada em lavagem automotiva de forma prática e rápida.

 A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada em um trabalho de imersão feita pelos membros da equipe a partir da observação do cotidiano das pessoas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

![Personas](img/persona1.jpg)

Mateus Machado tem 32 anos e é vendedor autônomo no ramo do comércio digital(e-comerce). Ele trabalha em seu escritório em casa e pensa em se tornar um grande varejista no seguimento de eletrônicos. Devido ao grande aumento em sua vendas, seu tempo ficou curto para cuidar do seu automóvel e necessita de uma solução prática e agil para seu problema pois não pode parar seu negócio por muito tempo nestwe momento e alta nas vendas.

![Personas](img/persona2.jpg)

André Simão tem 28 anos, trabalha 10 horas por dia em um escritório de advocacia. Aos fins de semana gosta de ficar em casa e curtir suas series favoritas. Ele não possui conhecimento de produtos certos para limpeza do seu carro e prefere levar seu veículo em um lava jato, contudo, adoraria receber este serviço no conforto do seu lar para poder aproveitar ao máximo seu fim de semana.

![1053f9de9072a5802c77972ed5031d0c](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-proj10_grupo04/assets/125131708/baf7c516-b0d6-4832-81ca-eebdaf1ed487)

Marina Santos tem 32 anos e é Gerente de Marketing: Marina é uma profissional ocupada que trabalha longas horas e geralmente tem pouco tempo livre durante uma semana. Ela valoriza muito a aparência do seu carro, mas a lavagem regular muitas vezes é adiada devido à sua agenda apertada. Marina procura conveniência em todos os aspectos de sua vida e está disposta a pagar por serviços que economizem seu tempo. Ela mora em um apartamento na área central da cidade e não possui garagem própria para fazer a limpeza do carro em casa. 

![persona 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-proj10_grupo04/assets/125131708/dc0fd2e4-d9a6-4018-9ad3-ba8844a26bde)

Pedro Oliveira tem 28 anos é Estudante Universitário. André é um estudante que vive em um bairro mais afastado do centro da cidade. Ele não possui um carro próprio, mas usa o carro da família para se locomover. Como seus pais trabalham durante uma semana, André muitas vezes tem a responsabilidade de cuidar da limpeza do carro da família. Ele está sempre em busca de maneiras econômicas e eficientes de tarefas, já que possui um orçamento limitado. 

![Persona 3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-proj10_grupo04/assets/131534936/5e9c7d99-206a-4a05-934d-890e8a52f866)

Carlos Diniz tem 65 anos, é aposentado, casado, tem dois filhos e quatro netos. Mora em uma capital e tem um sítio em uma cidade do interior. Ele e sua esposa adoram passar uns dias no sítio e fazem isso com muita frequência, em casa estão sempre recebendo a visita de seus filhos e netos. Carlos não gosta do trânsito da capital onde mora, por isso, evita ao máximo tirar o carro da garagem quando está em casa. Para ele seria ótimo receber o serviço de lavagem automotiva sem ter que se deslocar até um lava-jato.


![Persona 4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-proj10_grupo04/assets/131534936/90896b8e-3608-442f-b7d5-9a3994632ee7)

Marcela Rangel tem 25 anos, é chef de cozinha em um restaurante. Em seu trabalho ela sempre procura fornecedores de alimentos locais que usam de métodos sustentáveis na produção. Ela faz isso para incentivar a economia sustentável em sua região e não se restringe apenas ao seu trabalho. Marcela esta sempre procurando novos produtos e serviços que compartilham dessa ideia.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                            |
|--------------------|------------------------------------|---------------------------------------------------|
|Mateus Machado      | Agendamento                        | Lavagem veícular completa                         |
|Mateus Machado      | Alterar Agendamento                | Permitir alterar horário da visita                |
|André Simão         | Ver valor do serviço               | Decidir se pode solicitar o serviço agora         |
|André Simão         | Ver agenda disponível              | Escolher o melhor horário para um fim de semana   |
|Marina Santos       | Poupar tempo e esforço             | Evitar a necessidade de procurar uma lavagem de carro tradicional|
|Marina Santos       | Contatar profissionais confiáveis  | Que respeitem sua propriedade e entreguem um serviço de alta qualidade|
|Pedro Oliveira      | Garantia na lavagem                | Lavagem seja feita com produtos de limpeza que não causem danos ao carro e ao meio ambiente| 
|Pedro Oliveira      | Preço Justo                        | Encontre uma solução de limpeza de carros acessível e conveniente|
|Marcela Rangel      | Serviço local                      | Estimular a econoia local de sua região| 
|Marcela Rangel      | Sustentabilidade                   | Encontrar profissionais que usem práticas e produtos sustentáveis|
|Carlos Diniz        | Praticidade                        | Receber o serviço a domicílio| 
|Carlos Diniz        | Opções de lavagem                  | Poder escolher o tipo de lavagem que melhor atenderá suas necessidades|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Cálculo de preço                        | ALTA |
|RF-003| Emitir um relatório de tarefas no mês   | MÉDIA |
|RF-004| Agendamento de Serviços                 | MÉDIA |
|RF-005| Rastreamento em Tempo Real              | MÉDIA |
|RF-006| Avaliações e Feedback                   | MÉDIA |
|RF-007| Pagamento online                        | MÉDIA |
|RF-008| Notificações e lembretes                | BAIXA |
|RF-009| Formulário de entrada de dados precisa ter validação dos campos               | MÉDIA |
|RF-010| O pagamento on-line usará um sistema externo fornecido via API                | BAIXA |
|RF-011| Permitir cadastro de usuário            | ALTA  |
|RF-012| Permitir contato pelo site via formulário ou similar | Média  |
|RF-011| Permitir cancelar o agendamento. Máximo 6 horas antes do horário marcado.     | ALTA  |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| Segurança de Dados | ALTA |
|RNF-004| Tempo de resposta rápido | MÉDIA | 
|RNF-005| Compatibilidade com Diferentes Dispositivos | MÉDIA | 
|RNF-006| Assegurar que o aplicativo esteja disponível e funcional 24h por dia  | ALTA |
|RNF-007| Garantir que o aplicativo seja intuitivo e fácil de usar | MÉDIA | 
|RNF-008| Projetar o aplicativo para suportar o aumento no número de clientes e prestadores de serviço | ALTA | 
|RNF-009| Não deve permitir que um mesmo usuário se cadastre duas vezes, validar por documento ou e-mail | ALTA | 
|RNF-010| Estar de acordo com a Lei Geral de Proteção de Dados Pessoais | ALTA | 
|RNF-011| Utilizar fontes de letras harmônicas | BAIXA | 
|RNF-012| Utilizar cor de background que permita um bom contraste com as letras(preferência cor fria) | MÉDIA | 
|RNF-013| Aplicar um bom uso de cores para uma boa harmonização do site, buscando realçar os pontos mais importantes. | MÉDIA |



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Será desenvolvido só para plataforma web              |
|03| Restrição de Localização de Atendimento Inicial       |
|04| A equipe de desenvolvimento não pode ter mais de 6 integrantes       |
|05| O projeto deve ser desenvolvido sem misturar muitas linguagens de programação, facilitando o entendimento de todos da equipe   |


## Diagrama de Casos de Uso

![caso de uso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-proj10_grupo04/assets/81435143/61b3b25c-7bb5-4dfb-ac35-d354835cc1d8)
