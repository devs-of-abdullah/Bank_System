

namespace Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string IBAN { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;   
        public decimal Balance { get; set; } = 0;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<DepositEntity> Deposits { get; set; } = new List<DepositEntity>();
        public ICollection<WithdrawEntity> Withdraws { get; set; } = new List<WithdrawEntity>();

    }
}
