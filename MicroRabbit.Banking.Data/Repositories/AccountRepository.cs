using MicroRabbit.Banking.Data.Contexts;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbit.Banking.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;

        public AccountRepository(BankingDbContext context)
        {
            _ctx = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts.ToList();
        }
    }
}
