using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories;

namespace OnionArchitecture.Persistence.Repositories
{
    internal sealed class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OwnerRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Owner>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.Owners.Include(x => x.Accounts).ToListAsync(cancellationToken);

        public async Task<Owner> GetByIdAsync(Guid ownerId, CancellationToken cancellationToken = default) =>
            await _dbContext.Owners.Include(x => x.Accounts).FirstOrDefaultAsync(x => x.Id == ownerId, cancellationToken);

        public void Insert(Owner owner) => _dbContext.Owners.Add(owner);

        public void Remove(Owner owner) => _dbContext.Owners.Remove(owner);
    }
}