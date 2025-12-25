namespace BoletoPrinter.Domain.Entities;

/// <summary>
/// Representa um registro de log de processamento do sistema.
/// </summary>
/// <remarks>
/// Esta entidade armazena informações detalhadas sobre eventos ocorridos durante
/// o processamento de emails, análise de PDFs e impressão de boletos.
/// </remarks>
public class ProcessingLog
{
    /// <summary>
    /// Identificador único do registro de log.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nível de severidade do log.
    /// </summary>
    /// <remarks>
    /// Possíveis valores: Information, Warning, Error, Critical
    /// </remarks>
    public LogLevel Level { get; set; }

    /// <summary>
    /// Categoria ou componente que gerou o log.
    /// </summary>
    /// <example>EmailProcessor, PdfAnalyzer, PrintService</example>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Mensagem descritiva do evento registrado.
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Detalhes adicionais ou stack trace em caso de erro.
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// Identificador da conta de email relacionada, se aplicável.
    /// </summary>
    public int? EmailAccountId { get; set; }

    /// <summary>
    /// Identificador do trabalho de impressão relacionado, se aplicável.
    /// </summary>
    public int? PrintJobId { get; set; }

    /// <summary>
    /// Data e hora em que o evento ocorreu.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Informações adicionais em formato JSON, se necessário.
    /// </summary>
    public string? AdditionalData { get; set; }
}

/// <summary>
/// Enumeração que representa os níveis de severidade de um log.
/// </summary>
public enum LogLevel
{
    /// <summary>
    /// Informação geral sobre o funcionamento do sistema.
    /// </summary>
    Information = 0,

    /// <summary>
    /// Aviso sobre situações que podem requerer atenção.
    /// </summary>
    Warning = 1,

    /// <summary>
    /// Erro que não impede o funcionamento do sistema.
    /// </summary>
    Error = 2,

    /// <summary>
    /// Erro crítico que pode interromper o funcionamento do sistema.
    /// </summary>
    Critical = 3
}

