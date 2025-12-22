# Diagrama de Componentes — Worker Service

## Visão Geral

Este diagrama detalha os principais componentes internos do Worker Service e suas responsabilidades.

## Componentes

- **Scheduler**
  - Dispara o processamento a cada 10 segundos

- **EmailProcessor**
  - Conecta ao IMAP
  - Recupera emails e anexos

- **AttachmentHandler**
  - Filtra PDFs
  - Gerencia armazenamento temporário

- **BoletoDetector**
  - Identifica se o PDF é um boleto

- **PdfProcessor**
  - Extrai a primeira página

- **PrintService**
  - Envia o PDF para impressão

## Fluxo entre componentes

