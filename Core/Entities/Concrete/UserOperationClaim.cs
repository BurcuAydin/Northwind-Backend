namespace Core.Entities.Concrete
{
    //Hangi kullanıcıda hangi roller var
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
