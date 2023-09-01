
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento.

## Gerenciamento de Projeto

### Divisão de Papéis

A equipa está organizada da seguinte maneira:
- `Scrum Master`: 
- `Product Owner`: 
- `Equipe de Desenvolvimento`: 
- `Equipe de Design`: 
 
### Ferramentas

As ferramentas empregadas no projeto são:

| **Ambiente** | **Plataforma** | **Link de acesso** |
|:----|:---|:-----|
| Comunicação | Teams <br> Whatsapp | https://teams.microsoft.com/ <br> https://www.whatsapp.com/ |
| Documentos do Projeto | Github <br> Sharepoint | https://github.com/ <br> https://sgapucminasbr.sharepoint.com/ |
| Editor de código | Visual Studio Code | https://code.visualstudio.com |
| Gerenciamento do Projeto | Github | https://github.com/ |
| Pesquisa | Formulários do Google | https://drive.google.com/ |
| Projeto de Interface e Wireframe | Figma | https://www.figma.com/ |
| Respositório do Código Fonte | Github | https://github.com/ |
| User Flow | draw.io | https://www.diagrams.net/ |

O Teams será usado para videoconferências das reuniões de planejamento do sprint, backlog do sprint, revisão do sprit e revisão do sprint. O Whatsapp para comunicações pontuais no decorrer do dia.

A documentação do projeto ficará hospedada no Github, em razão da facilidade de acesso por parte dos integrantes da equipe. Nos casos em que houver necessidade de documentos mais elaborados (apresentações, planilhas, etc), será utilizado o Office 365, com hospedagem no Sharepoint. Da mesma forma serão utilizadas as ferramentas de gerenciamento de projeto da plataforma, bem como a mesma também servirá de repositório para o código fonte, em razaão de suas funcionalidades de controle de versão.

Para edição de código, foi escolhida a ferramenta Visual Studio Code por: 
1) Ser gratuita e opensource;
2) Ser amplamente  utilizada;
3) Possuir um extenso marketplace de addins que possibilitam expandir suas funções, inclusive integrando com o sistema de controle de versões.

### Processo

Para a organização e distribuição das tarefas do projeto, o grupo esta utilizando o GitHub, seguindo os critérios de:
- `Product Backlog`: Recebe as tarefas a serem trabalhadas e presenta o Backlogdo produto. Todas as atividades identificadas no decorrer do projeto são incorporadas a esta lista.
- `To Do`: Esta lista representa o Sprint Backlog que está sendo trabalhado.
- `In progress`: Lista das tarefas iniciadas.
- `Testing`: Lista das tarefas concluidas que passarão pelo processo de teste e controle de qualidade.
- `Done`: Nesta lista são colocadas as tarefas finalizadas e aprovadas.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o [Git](https://git-scm.com/), sendo que o [Github](https://github.com) foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bugfix`: uma funcionalidade encontra-se com problemas
- `improvement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida
