namespace Domain.Accounts
{
    using System.Threading.Tasks;
    using Domain.Accounts.Credits;
    using Domain.Accounts.Debits;
    using Domain.Accounts.ValueObjects;

    /// <summary>
    /// Account <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns#repository">Repository Domain-Driven Design Pattern</see>.
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Gets an Account.
        /// </summary>
        /// <param name="id">AccountId.</param>
        /// <returns>An Account instance.</returns>
        Task<IAccount> Get(AccountId id);

        /// <summary>
        /// Adds an Account.
        /// </summary>
        /// <param name="account">Account object.</param>
        /// <param name="credit">Credit object.</param>
        /// <returns>Task.</returns>
        Task Add(IAccount account, ICredit credit);

        /// <summary>
        /// Updates an Account.
        /// </summary>
        /// <param name="account">Account object.</param>
        /// <param name="credit">Credit object.</param>
        /// <returns>Task.</returns>
        Task Update(IAccount account, ICredit credit);

        /// <summary>
        /// Updates the Account.
        /// </summary>
        /// <param name="account">Account object.</param>
        /// <param name="debit">Debit object.</param>
        /// <returns>Task.</returns>
        Task Update(IAccount account, IDebit debit);

        /// <summary>
        /// Deletes the Account.
        /// </summary>
        /// <param name="account">Account object.</param>
        /// <returns>Task.</returns>
        Task Delete(IAccount account);
    }
}
