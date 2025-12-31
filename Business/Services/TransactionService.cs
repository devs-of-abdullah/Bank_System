

using Business.Interfaces;
using Data.Interfaces;

namespace Business.Services
{
    public class TransactionService : ITransactionService
    {
        readonly ITransactionRepository _repo;
        public TransactionService(ITransactionRepository repo) 
        { 
            _repo = repo;
        }
      
    }
}
