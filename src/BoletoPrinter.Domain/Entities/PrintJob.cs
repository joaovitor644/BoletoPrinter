namespace BoletoPrinter.Domain.Entities;

/// <summary>
/// Representa um trabalho de impressão de boleto.
/// </summary>
/// <remarks>
/// Esta entidade rastreia o status e informações de cada tentativa de impressão
/// de um boleto identificado no sistema.
/// </remarks>
public class PrintJob
{
    /// <summary>
    /// Identificador único do trabalho de impressão.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Status atual do trabalho de impressão.
    /// </summary>
    /// <remarks>
    /// Possíveis valores: Pending, Processing, Completed, Failed, Cancelled
    /// </remarks>
    public PrintJobStatus Status { get; set; }

    /// <summary>
    /// Caminho do arquivo PDF que será impresso.
    /// </summary>
    /// <remarks>
    /// Geralmente um arquivo temporário contendo a primeira página do boleto.
    /// </remarks>
    public string FilePath { get; set; } = string.Empty;

    /// <summary>
    /// Nome da impressora de destino.
    /// </summary>
    public string PrinterName { get; set; } = string.Empty;

    /// <summary>
    /// Mensagem de erro, se o trabalho falhou.
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Data e hora de criação do trabalho de impressão.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Data e hora em que a impressão foi concluída com sucesso.
    /// </summary>
    public DateTime? PrintedAt { get; set; }

    /// <summary>
    /// Identificador do email relacionado, se disponível.
    /// </summary>
    public int? EmailMessageId { get; set; }

    /// <summary>
    /// Identificador do anexo PDF relacionado, se disponível.
    /// </summary>
    public int? PdfAttachmentId { get; set; }
}

/// <summary>
/// Enumeração que representa os possíveis status de um trabalho de impressão.
/// </summary>
public enum PrintJobStatus
{
    /// <summary>
    /// Trabalho aguardando processamento.
    /// </summary>
    Pending = 0,

    /// <summary>
    /// Trabalho sendo processado atualmente.
    /// </summary>
    Processing = 1,

    /// <summary>
    /// Trabalho concluído com sucesso.
    /// </summary>
    Completed = 2,

    /// <summary>
    /// Trabalho falhou durante o processamento.
    /// </summary>
    Failed = 3,

    /// <summary>
    /// Trabalho foi cancelado.
    /// </summary>
    Cancelled = 4
}

