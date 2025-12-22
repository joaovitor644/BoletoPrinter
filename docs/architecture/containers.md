# Diagrama de Containers — BoletoPrinter

## Visão Geral

Este diagrama descreve os principais containers executáveis do sistema BoletoPrinter e como eles se comunicam.

## Containers

### Web Application
- Tecnologia: ASP.NET Core
- Responsabilidades:
  - Interface de configuração
  - Visualização de logs e status
  - Gerenciamento de contas de email e impressoras

### Worker Service
- Tecnologia: .NET Worker Service
- Responsabilidades:
  - Polling de emails
  - Processamento de PDFs
  - Detecção de boletos
  - Impressão automática

### Banco de Dados
- Tecnologia: SQLite
- Responsabilidades:
  - Persistir configurações
  - Histórico de processamentos

### Sistemas Externos
- Servidor de Email (IMAP)
- Impressora de Rede


