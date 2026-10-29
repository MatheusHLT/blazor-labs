# 🧪 Blazor Playground - Laboratório de Estudos Práticos

Este repositório centraliza uma coleção de aplicações práticas, utilitários lógicos e integrações de APIs REST desenvolvidos com o objetivo de dominar os recursos modernos do ecossistema **.NET** e do framework **Blazor**.

O projeto foi construído utilizando o modelo arquitetural moderno introduzido pela Microsoft, focando em alta performance e separação clara de responsabilidades.

---

## 🏗️ Arquitetura do Projeto

A solução foi gerada através do comando `dotnet new blazor --interactivity WebAssembly`, criando uma arquitetura dividida de forma limpa entre o Servidor e o Cliente (Navegador):

### 📂 Projeto Principal (Servidor / Host)
* **Função:** Atua como o ponto de entrada da aplicação, gerenciando o ciclo de vida inicial, roteamento base, políticas de segurança e a **pré-renderização (Static Server-Side Rendering - SSR)** das páginas.
* **Componentes Inclusos:** Contém o layout mestre (`MainLayout`), o menu de navegação dinâmico (`NavMenu`) e páginas que não necessitam de interatividade pesada em tempo real no cliente.

### 📂 Projeto `.Client` (Cliente / WebAssembly)
* **Função:** Contém os componentes que usam `@rendermode InteractiveWebAssembly`. Todo o código desta pasta é compilado para WebAssembly e executado de forma isolada diretamente no navegador do usuário.
* **Componentes Inclusos:** Armazena as telas de consumo de dados assíncronos e componentes com eventos interativos em C# (cliques, manipulação de estados e requisições HTTP).

---

## 🛠️ Práticas de Engenharia de Software Aplicadas

* **Mapeamento Unitário de Dados (Abordagem DTO de Mercado):** A pasta `Models` dentro do projeto cliente adota a divisão em subpastas por contexto (`PokeApi`, `ValorantApi`, `BrasilApiCep`, etc.). Cada entidade do JSON externo possui um arquivo de classe C# isolado de responsabilidade única.
* **Convenção de Nomenclatura Oficial:** Aplicação estrita das *Framework Design Guidelines* da Microsoft para siglas longas em nomes compostos no C# (ex: `ViaCep` e `ValorantApi` no código; e *Valorant API* na camada visual de exibição).
* **Persistência de Estado (JS Interop):** Uso do serviço `IJSRuntime` para gerenciar ciclos de vida avançados através do método `OnAfterRenderAsync` e garantir a persistência de coleções no `localStorage` do navegador.

---

## 🚀 Funcionalidades e Laboratórios Inclusos

### ⚡ Consumo de APIs Externas
* **PokeAPI:** Tela interativa de busca de pokémons que consome dados de forma assíncrona, exibindo sprites e propriedades físicas mapeadas dinamicamente.
* **BrasilAPI (CEP):** Módulo de localização e consulta de endereços estruturado via integração com serviços públicos nacionais.
* **Valorant API:** Consumo e exibição de dados dinâmicos estruturados sobre o ecossistema do jogo Valorant.
* **JsonPlaceHolder API:** Laboratório prático focado no consumo de dados simulados (Mock REST) para testes estruturais de requisições.
* **Dragonball API:** Integração focada na listagem e processamento de informações de mídias externas.

### ⚙️ Lógica, Algoritmos e Persistência
* **Média Escolar:** Calculadora acadêmica com validações de dados reativas (*Defensive Programming*) e exibição de alertas condicionais baseados na situação do estudante.
* **Gerenciador de Tarefas:** Lista de afazeres robusta que previne duplicidade de registros, calcula dados em tela em tempo real e mantém os dados salvos mesmo após fechar o navegador.
* **Sorteador Dinâmico:** Gerador aleatório numérico com isolamento estilizado de elementos via tags HTML `<span>` combinadas com o sistema de cores do Bootstrap.

---

## 💻 Como Rodar o Projeto Localmente

1. Certifique-se de possuir o **.NET SDK** instalado em sua máquina.
2. Clone o repositório para o seu ambiente local.
3. Abra o terminal na **pasta raiz** da solução (onde se encontra o arquivo `.sln`).
4. Execute o comando para compilar e iniciar o host servidor com suporte a Hot Reload:
   ```bash
   dotnet watch --project ProjetoFinal/ProjetoFinal.csproj
   ```
5. Acesse o endereço local disponibilizado no seu terminal através do navegador.

---

#### 👨‍💻 Desenvolvido por:
**Matheus Honorato**  
*Estudante de Desenvolvimento de Software focado em tecnologias Microsoft .NET.*