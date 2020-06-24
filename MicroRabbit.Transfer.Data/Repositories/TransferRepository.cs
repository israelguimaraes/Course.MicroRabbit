using MicroRabbit.Transfer.Data.Contexts;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbit.Transfer.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.Add(transferLog);
            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.Transfers.ToList();
        }
    }
}
