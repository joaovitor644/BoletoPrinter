# Documento de Requisitos de Software (SRS)
## Projeto: BoletoPrinter

---

## 1. Introdução

### 1.1 Propósito

Este documento descreve os requisitos funcionais e não funcionais do sistema **BoletoPrinter**, cujo objetivo é automatizar a leitura de emails, identificação de boletos bancários em formato PDF e envio desses boletos para impressão em uma impressora de rede local.

O documento serve como base para:
- Desenvolvimento do sistema
- Validação de funcionalidades
- Evolução futura do projeto

---

### 1.2 Escopo do Sistema

O sistema BoletoPrinter será uma aplicação multiplataforma (Windows e Linux), desenvolvida em **.NET**, composta por:

- Um **serviço em background (Worker Service)** para processamento de emails
- Uma **interface Web** para configuração e monitoramento
- Integração com servidores de email via **IMAP**
- Integração com impressoras de rede
- Suporte a múltiplas contas de email
- Observabilidade e pipeline de CI/CD

---

### 1.3 Definições, Acrônimos e Abreviações

| Termo | Descrição |
|-----|----------|
| IMAP | Internet Message Access Protocol |
| PDF | Portable Document Format |
| Worker Service | Serviço .NET executado em background |
| CI/CD | Continuous Integration / Continuous Deployment |
| Observabilidade | Métricas, logs e rastreamento do sistema |

---

## 2. Descrição Geral

### 2.1 Perspectiva do Produto

O BoletoPrinter é um sistema independente, porém integrado a serviços externos como servidores de email e impressoras de rede. Ele opera de forma contínua e automática, com mínima intervenção do usuário após configurado.

---

### 2.2 Funções do Produto

- Monitorar contas de email configuradas
- Buscar emails periodicamente (a cada 10 segundos)
- Identificar boletos em anexos PDF
- Imprimir automaticamente a primeira página do boleto
- Permitir configuração via interface Web
- Registrar logs e métricas de execução

---

### 2.3 Classes de Usuários

| Usuário | Descrição |
|------|----------|
| Usuário Administrador | Configura contas de email, impressoras e parâmetros do sistema |
| Usuário Operacional | Apenas monitora o status do sistema via interface Web |

---

### 2.4 Ambiente Operacional

- Sistemas Operacionais:
  - Linux
  - Windows
- Runtime:
  - .NET 8 ou superior
- Rede:
  - Impressora em rede local privada
  - Acesso à internet para servidores de email

---

### 2.5 Restrições

- O processamento de emails será **sequencial**
- O intervalo de verificação será fixo inicialmente em **10 segundos**
- O sistema deve funcionar sem dependência de interfaces gráficas no servidor
- Impressão limitada à primeira página do PDF

---

### 2.6 Suposições e Dependências

- O servidor de email suporta IMAP
- Os boletos estarão anexados como arquivos PDF
- A impressora suporta impressão via rede (IP)
- O usuário fornecerá credenciais válidas de email

---

## 3. Requisitos Funcionais

### RF-01 — Cadastro de Contas de Email
O sistema deve permitir cadastrar uma ou mais contas de email para monitoramento.

---

### RF-02 — Habilitar ou Desabilitar Contas
O sistema deve permitir ativar ou desativar contas de email individualmente.

---

### RF-03 — Leitura de Emails via IMAP
O sistema deve acessar os servidores de email configurados utilizando o protocolo IMAP.

---

### RF-04 — Verificação Periódica
O sistema deve verificar novas mensagens a cada **10 segundos**, de forma sequencial.

---

### RF-05 — Identificação de Boletos
O sistema deve analisar anexos PDF e identificar se o documento corresponde a um boleto bancário.

---

### RF-06 — Processamento Sequencial
Os emails devem ser processados um por vez, respeitando a ordem de leitura.

---

### RF-07 — Impressão de Boletos
O sistema deve enviar o boleto identificado para a impressora configurada, imprimindo apenas a primeira página.

---

### RF-08 — Prevenção de Reprocessamento
O sistema deve marcar emails já processados para evitar duplicidade de impressão.

---

### RF-09 — Interface Web de Configuração
O sistema deve fornecer uma interface Web para:
- Gerenciar contas de email
- Configurar impressora
- Visualizar status do serviço

---

### RF-10 — Logs de Execução
O sistema deve registrar logs detalhados de:
- Leitura de emails
- Identificação de boletos
- Impressões realizadas
- Erros e exceções

---

## 4. Requisitos Não Funcionais

### RNF-01 — Multiplataforma
O sistema deve funcionar em ambientes Linux e Windows sem alterações no código.

---

### RNF-02 — Desempenho
O sistema deve processar emails sem bloquear a execução do serviço, respeitando o intervalo configurado.

---

### RNF-03 — Observabilidade
O sistema deve expor:
- Logs estruturados
- Métricas básicas (emails processados, boletos impressos, falhas)

---

### RNF-04 — Segurança
- As credenciais de email devem ser armazenadas de forma segura
- A interface Web deve exigir autenticação

---

### RNF-05 — Manutenibilidade
O sistema deve seguir arquitetura em camadas, facilitando manutenção e evolução.

---

### RNF-06 — Implantação
O sistema deve suportar execução via:
- Docker
- Execução nativa em .NET

---

## 5. Requisitos de Interface Externa

### 5.1 Interface com Email
- Protocolo: IMAP
- Porta configurável
- Suporte a SSL/TLS

---

### 5.2 Interface com Impressora
- Impressora acessível via IP
- Comunicação via sistema operacional

---

### 5.3 Interface Web
- Acessível via navegador
- Interface responsiva
- Configurações persistidas localmente

---

## 6. Requisitos de Qualidade

| Qualidade | Descrição |
|---------|----------|
| Confiabilidade | Evitar impressões duplicadas |
| Usabilidade | Interface simples e objetiva |
| Escalabilidade | Suporte a múltiplas contas |
| Portabilidade | Linux e Windows |

---

## 7. Apêndice

Este documento poderá ser atualizado conforme novas funcionalidades forem incorporadas ao sistema.
