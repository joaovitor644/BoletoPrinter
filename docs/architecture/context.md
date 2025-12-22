# Diagrama de Contexto — BoletoPrinter

## Visão Geral

O BoletoPrinter é um sistema responsável por automatizar a impressão de boletos bancários recebidos por email.

Ele atua como um serviço intermediário entre contas de email, processamento de PDFs e impressoras de rede locais.

## Atores e Sistemas Externos

- **Usuário**
  - Configura o sistema
  - Acompanha status e logs via Web UI

- **Serviço de Email (IMAP)**
  - Fonte dos boletos em PDF

- **Impressora de Rede**
  - Destino final dos boletos impressos

- **Sistema Operacional**
  - Windows ou Linux (CUPS)


## Responsabilidade do Sistema

- Monitorar emails
- Identificar boletos em PDF
- Imprimir automaticamente a primeira página

