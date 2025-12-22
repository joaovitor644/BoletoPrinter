# Arquitetura de Camadas — BoletoPrinter

## Visão Geral

O sistema adota uma arquitetura em camadas para garantir baixo acoplamento, facilidade de manutenção e testabilidade.

## Camadas

### Presentation
- Web UI
- Controllers
- ViewModels

### Application
- Casos de uso
- Orquestração de fluxo
- Regras de aplicação

### Domain
- Entidades
- Interfaces
- Regras de negócio

### Infrastructure
- Implementações técnicas
- IMAP
- PDF
- Impressão
- Persistência

## Regra de Dependência

- Presentation → Application
- Application → Domain
- Infrastructure → Domain
- Domain **não depende** de nenhuma outra camada
