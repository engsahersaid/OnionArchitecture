using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories;

namespace OnionArchitecture.Persistence.Repositories
{
    internal sealed class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AccountRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Account>> GetAllByOwnerIdAsync(Guid ownerId, CancellationToken cancellationToken = default) =>
            await _dbContext.Accounts.Where(x => x.OwnerId == ownerId).ToListAsync(cancellationToken);

        public async Task<Account> GetByIdAsync(Guid accountId, CancellationToken cancellationToken = default) =>
            await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == accountId, cancellationToken);

        public void Insert(Account account) => _dbContext.Accounts.Add(account);

        public void Remove(Account account) => _dbContext.Accounts.Remove(account);
    }
}