using System.ComponentModel.DataAnnotations;

namespace PracticingCRUDSQLite
{
    public class User
    {
        [Key]//this attribute will be used to indicate that this prop Id is the Key = unique for every user entry// will be automated
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}