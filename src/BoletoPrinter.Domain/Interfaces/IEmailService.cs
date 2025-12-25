using BoletoPrinter.Domain.Entities;

namespace BoletoPrinter.Domain.Interfaces;

/// <summary>
/// Interface que define o contrato para serviços de comunicação com servidores de email via IMAP.
/// </summary>
/// <remarks>
/// Esta interface abstrai as operações de conexão, leitura e processamento de emails,
/// permitindo diferentes implementações para diferentes provedores de email ou protocolos.
/// </remarks>
public interface IEmailService
{
    /// <summary>
    /// Conecta ao servidor IMAP usando as credenciais da conta de email especificada.
    /// </summary>
    /// <param name="emailAccount">Conta de email com as credenciais e configurações de conexão.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se a conexão foi estabelecida com sucesso; caso contrário, false.</returns>
    /// <exception cref="System.Exception">Pode lançar exceções relacionadas a problemas de rede ou autenticação.</exception>
    Task<bool> ConnectAsync(EmailAccount emailAccount, CancellationToken cancellationToken = default);

    /// <summary>
    /// Desconecta do servidor IMAP.
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Task que representa a operação assíncrona.</returns>
    Task DisconnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Verifica se há novos emails não processados na caixa de entrada.
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Lista de identificadores únicos dos emails não processados.</returns>
    /// <remarks>
    /// A implementação deve considerar apenas emails que ainda não foram processados
    /// pelo sistema, evitando reprocessamento.
    /// </remarks>
    Task<IEnumerable<string>> GetUnprocessedEmailIdsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtém os anexos PDF de um email específico.
    /// </summary>
    /// <param name="emailId">Identificador único do email.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>Lista de streams contendo os arquivos PDF anexados ao email.</returns>
    /// <remarks>
    /// Apenas anexos com extensão .pdf devem ser retornados. Os streams devem ser
    /// gerenciados adequadamente para evitar vazamentos de memória.
    /// </remarks>
    Task<IEnumerable<Stream>> GetPdfAttachmentsAsync(string emailId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Marca um email como processado para evitar reprocessamento.
    /// </summary>
    /// <param name="emailId">Identificador único do email a ser marcado.</param>
    /// <param name="cancellationToken">Token de cancelamento para operações assíncronas.</param>
    /// <returns>True se o email foi marcado com sucesso; caso contrário, false.</returns>
    Task<bool> MarkAsProcessedAsync(string emailId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Verifica se a conexão com o servidor IMAP está ativa.
    /// </summary>
    /// <returns>True se a conexão está ativa; caso contrário, false.</returns>
    bool IsConnected { get; }
}

