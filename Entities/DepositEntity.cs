

namespace Entities
{
    public class DepositEntity
    {
        public int Id { get; set; }

        public int UserId {  get; set; }
        public UserEntity User { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
