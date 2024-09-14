using OnionArchitecture.Domain.Common;

namespace OnionArchitecture.Domain.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}