namespace BoletoPrinter.Domain.Interfaces;

/// <summary>
/// Interface que define o contrato para análise e processamento de arquivos PDF.
/// </summary>
/// <remarks>
/// Esta interface abstrai as operações de análise de PDFs para identificar boletos bancários
/// e extrair páginas específicas, permitindo diferentes implementações de bibliotecas de PDF.
/// </remarks>
public interface IPdfAnalyzer
{
    /// <summary>
    /// Analisa um arquivo PDF para determinar se ele representa um boleto bancário.
    /// </summary>
    /// <param name="pdfStream">Stream contendo o conteúdo do arquivo PDF.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se o PDF é identificado como um boleto bancário; caso contrário, false.</returns>
    /// <remarks>
    /// A implementação deve analisar o conteúdo do PDF (texto, estrutura, campos específicos)
    /// para identificar características típicas de boletos bancários brasileiros.
    /// </remarks>
    /// <exception cref="System.Exception">Pode lançar exceções se o arquivo não for um PDF válido ou estiver corrompido.</exception>
    Task<bool> IsBoletoAsync(Stream pdfStream, CancellationToken cancellationToken = default);

    /// <summary>
    /// Extrai a primeira página de um arquivo PDF.
    /// </summary>
    /// <param name="pdfStream">Stream contendo o conteúdo do arquivo PDF completo.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Stream contendo apenas a primeira página do PDF.</returns>
    /// <remarks>
    /// O stream retornado deve conter um PDF válido com apenas a primeira página.
    /// O stream original não deve ser modificado.
    /// </remarks>
    /// <exception cref="System.Exception">Pode lançar exceções se o arquivo não for um PDF válido ou não tiver páginas.</exception>
    Task<Stream> ExtractFirstPageAsync(Stream pdfStream, CancellationToken cancellationToken = default);

    /// <summary>
    /// Valida se o stream fornecido contém um arquivo PDF válido.
    /// </summary>
    /// <param name="pdfStream">Stream a ser validado.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se o stream contém um PDF válido; caso contrário, false.</returns>
    Task<bool> IsValidPdfAsync(Stream pdfStream, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém o número total de páginas de um arquivo PDF.
    /// </summary>
    /// <param name="pdfStream">Stream contendo o conteúdo do arquivo PDF.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Número total de páginas do PDF.</returns>
    /// <exception cref="System.Exception">Pode lançar exceções se o arquivo não for um PDF válido.</exception>
    Task<int> GetPageCountAsync(Stream pdfStream, CancellationToken cancellationToken = default);
}

