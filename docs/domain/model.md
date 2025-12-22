# Modelo de Domínio — BoletoPrinter

## Entidades Principais

### EmailAccount
- Id
- Name
- ImapServer
- Username
- Password
- Enabled

### EmailMessage
- Id
- Subject
- ReceivedAt
- Processed

### PdfAttachment
- Id
- FilePath
- IsBoleto

### PrintJob
- Id
- Status
- CreatedAt
- PrintedAt

## Relacionamentos

EmailAccount 1---* EmailMessage
EmailMessage 1---* PdfAttachment
PdfAttachment 1---1 PrintJob