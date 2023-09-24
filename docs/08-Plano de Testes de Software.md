# Plano de Testes de Software

O plano de teste de software proposto para avaliação dos requisitos funcionais da aplicação interativa é apresentado a seguir. Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil e a confirmação de que todos os campos foram preenchidos |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://www.lavajatoadomicilio.com/src/index.html <br> - Clicar em "Criar agendamentos" <br> - Em seguida ir em "Pussui cadastro" <br> - Em seguida preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login e a confirmação de que todos os campos foram preenchidos de forma devida	|
|Requisito Associado | RF-002	- A aplicação deve possuir opção de fazer login, sendo o login o CPF do usuário. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://www.lavajatoadomicilio.com/src/index.html <br> - Clicar no botão "Criar agendamentos" <br> - Clicar em "possui cadastro" <br> - Preencher o campo de CPF(login) e senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Fazer pedido após login no menu principal	|
|Requisito Associado | RF-003	- A aplicação irá permitir o usuário a gerar seu pedido no menu principal |
| Objetivo do Teste 	| Realizar agendamento do cliente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://www.lavajatoadomicilio.com/src/index.html <br> - Clicar no botão "Criar agendamentos" <br> - Após login do usuário ao menu principal <br> - Selecionar o modelo de lavagem ideal para seu veiculo <br> - Seguir o passo a passo para confirmar dados e pagamentos. |
|Critério de Êxito | - Pedido agendado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Teste para cliente efetuar pagamento	|
|Requisito Associado | RF-004	- A aplicação deve possuir formas de pagamento diversificadas para os clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar pagamentos. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://www.lavajatoadomicilio.com/src/index.html <br> - Após login e modelo escolhido para agendamento. <br> - Na tela de pagamento, confirmar valor, data, hora, endereço registrado e formas de pagamentos <br> - Em seguida pegar recibo de pagamento e agendamento e voltar para menu inicial. |
|Critério de Êxito | - Formas de pagamentos e registro averiguado. |
|  	|  	|
| Caso de Teste 	| CT-05 – Realizar avaliação do trabalho	|
|Requisito Associado | RF-005	- A aplicação irá permitir o usuário avaliar e comentar sobre o serviço prestado |
| Objetivo do Teste 	| Usuário irá comentar e avaliar o serviço. |
| Passos 	| - Após serviço feito com o cliente com data marcada e registro gerado irá para tela de avaliação <br> - Ir em perfil, meus agendamentos <br> - Clicar em "avaliar" <br> - Marcar numero de estrelas e deixar comentário <br> - Conferir registro da avaliação <br> |
|Critério de Êxito | - Avaliação e comentário registrado. |

