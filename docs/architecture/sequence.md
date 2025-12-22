# Diagrama de Sequência — Processamento de Boletos

## Fluxo principal

1. Scheduler dispara execução
2. Worker acessa o servidor IMAP
3. Emails são processados sequencialmente
4. PDFs são analisados
5. Boletos são identificados
6. Primeira página é impressa

## Sequência lógica

