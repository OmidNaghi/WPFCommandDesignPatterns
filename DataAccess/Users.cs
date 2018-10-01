using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityDataAccess
{
    [Table("Users", Schema = "Security")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
