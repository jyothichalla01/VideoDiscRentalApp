using System.ComponentModel.DataAnnotations;

namespace DApplication.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string? Email { get; set; }
        public byte[] Password { get; set; }
        public long? Phone { get; set; }
        public byte[] Key { get; set; }
    }
}
