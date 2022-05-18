namespace TaskAuthenticationAuthorization.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public  int? RoleId { get; set; }

        public Role Role { get; set; }

        public buyerType BuyerType { get; set; } = buyerType.none;
        
        public enum buyerType
        {
            none = 1, 
            regular, 
            golden, 
            wholesale
        }
    }
    
}
