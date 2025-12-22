# BoletoPrinter

BoletoPrinter é uma aplicação multiplataforma desenvolvida em .NET que automatiza o processo de impressão de boletos bancários.

O sistema monitora uma ou mais contas de email via IMAP em intervalos configuráveis, identifica automaticamente anexos PDF que representam boletos bancários, extrai a primeira página e envia o documento para impressão em uma impressora de rede local.

O projeto foi projetado para funcionar tanto em ambientes Linux quanto Windows, oferecendo processamento sequencial, observabilidade integrada e uma interface web para configuração e monitoramento.

## Principais funcionalidades

- Monitoramento de múltiplas contas de email (IMAP)
- Detecção automática de boletos em PDF
- Extração da primeira página do boleto
- Impressão automática em impressoras de rede
- Compatível com Linux (CUPS) e Windows
- Processamento sequencial a cada 10 segundos
- Interface web para configuração
- Logs, métricas e tracing (observabilidade)
- Pipeline de CI/CD integrado

## Casos de uso

- Automação de impressão de boletos em empresas
- Redução de processos manuais no setor financeiro
- Homelab e automações pessoais
- Ambientes que exigem impressão imediata de documentos financeiros

## Tecnologias utilizadas

- .NET 8
- ASP.NET Core
- IMAP
- PDF processing
- Docker
- OpenTelemetry
- Serilog
