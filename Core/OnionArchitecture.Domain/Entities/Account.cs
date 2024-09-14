using OnionArchitecture.Domain.Common;

namespace OnionArchitecture.Domain.Entities
{
    public class Account : BaseEntity
    {
        public DateTime DateCreated { get; set; }

        public string AccountType { get; set; }

        public Guid OwnerId { get; set; }
    }
}