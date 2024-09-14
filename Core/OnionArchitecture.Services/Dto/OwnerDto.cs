namespace OnionArchitecture.Services.Dto
{
    public class OwnerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public ICollection<AccountDto> Accounts { get; set; }
    }
}