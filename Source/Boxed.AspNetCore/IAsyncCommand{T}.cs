namespace Boxed.AspNetCore
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Executes a single command with one parameter and returns a result.
    /// </summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    public interface IAsyncCommand<T>
    {
        /// <summary>
        /// Executes the command asynchronously.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The result of the command.</returns>
        Task<IActionResult> ExecuteAsync(T parameter, CancellationToken cancellationToken = default);
    }
}
