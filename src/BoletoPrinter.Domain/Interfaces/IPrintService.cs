using BoletoPrinter.Domain.Entities;

namespace BoletoPrinter.Domain.Interfaces;

/// <summary>
/// Interface que define o contrato para serviços de impressão de documentos.
/// </summary>
/// <remarks>
/// Esta interface abstrai as operações de impressão, permitindo diferentes implementações
/// para diferentes sistemas operacionais (Windows, Linux/CUPS) e tipos de impressoras.
/// </remarks>
public interface IPrintService
{
    /// <summary>
    /// Envia um arquivo PDF para impressão na impressora especificada.
    /// </summary>
    /// <param name="pdfStream">Stream contendo o conteúdo do arquivo PDF a ser impresso.</param>
    /// <param name="printerName">Nome da impressora de destino.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se o trabalho de impressão foi enviado com sucesso; caso contrário, false.</returns>
    /// <remarks>
    /// A implementação deve enviar o PDF para a fila de impressão do sistema operacional.
    /// O método retorna quando o trabalho é enviado, não necessariamente quando a impressão é concluída.
    /// </remarks>
    /// <exception cref="System.Exception">Pode lançar exceções se a impressora não estiver disponível ou se houver problemas de comunicação.</exception>
    Task<bool> PrintPdfAsync(Stream pdfStream, string printerName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém a lista de impressoras disponíveis no sistema.
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Lista de nomes das impressoras disponíveis.</returns>
    /// <remarks>
    /// A implementação deve consultar o sistema operacional para obter a lista atualizada
    /// de impressoras instaladas e disponíveis.
    /// </remarks>
    Task<IEnumerable<string>> GetAvailablePrintersAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Verifica se uma impressora específica está disponível e acessível.
    /// </summary>
    /// <param name="printerName">Nome da impressora a ser verificada.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se a impressora está disponível; caso contrário, false.</returns>
    Task<bool> IsPrinterAvailableAsync(string printerName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém o status atual de um trabalho de impressão.
    /// </summary>
    /// <param name="printJob">Trabalho de impressão cujo status deve ser verificado.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Status atualizado do trabalho de impressão.</returns>
    /// <remarks>
    /// A implementação deve consultar o sistema operacional para obter o status atual
    /// do trabalho de impressão, atualizando o objeto PrintJob fornecido.
    /// </remarks>
    Task<PrintJobStatus> GetPrintJobStatusAsync(PrintJob printJob, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cancela um trabalho de impressão em andamento.
    /// </summary>
    /// <param name="printJob">Trabalho de impressão a ser cancelado.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se o trabalho foi cancelado com sucesso; caso contrário, false.</returns>
    Task<bool> CancelPrintJobAsync(PrintJob printJob, CancellationToken cancellationToken = default);
}

