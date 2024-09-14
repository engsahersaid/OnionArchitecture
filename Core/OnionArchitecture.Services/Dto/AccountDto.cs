﻿namespace OnionArchitecture.Services.Dto
{
    public class AccountDto
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string AccountType { get; set; }

        public Guid OwnerId { get; set; }
    }
}