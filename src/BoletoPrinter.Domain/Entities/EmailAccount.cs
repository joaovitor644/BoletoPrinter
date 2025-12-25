namespace BoletoPrinter.Domain.Entities;

/// <summary>
/// Representa uma conta de email configurada para monitoramento de boletos.
/// </summary>
/// <remarks>
/// Esta entidade armazena as credenciais e configurações necessárias para conectar
/// a um servidor IMAP e monitorar emails em busca de boletos bancários.
/// </remarks>
public class EmailAccount
{
    /// <summary>
    /// Identificador único da conta de email.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome descritivo da conta de email para identificação no sistema.
    /// </summary>
    /// <example>Conta Principal - Financeiro</example>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Endereço do servidor IMAP.
    /// </summary>
    /// <example>imap.gmail.com</example>
    public string ImapServer { get; set; } = string.Empty;

    /// <summary>
    /// Porta do servidor IMAP.
    /// </summary>
    /// <remarks>
    /// Geralmente 993 para IMAP com SSL/TLS ou 143 para IMAP sem criptografia.
    /// </remarks>
    public int ImapPort { get; set; }

    /// <summary>
    /// Nome de usuário para autenticação no servidor IMAP.
    /// </summary>
    /// <example>usuario@exemplo.com</example>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Senha para autenticação no servidor IMAP.
    /// </summary>
    /// <remarks>
    /// Deve ser armazenada de forma segura, preferencialmente criptografada.
    /// </remarks>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Indica se a conta está habilitada para monitoramento.
    /// </summary>
    /// <remarks>
    /// Quando desabilitada, a conta não será verificada durante o processamento periódico.
    /// </remarks>
    public bool Enabled { get; set; }

    /// <summary>
    /// Indica se deve usar SSL/TLS para conexão segura.
    /// </summary>
    public bool UseSsl { get; set; } = true;

    /// <summary>
    /// Data e hora de criação do registro.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Data e hora da última atualização do registro.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}

