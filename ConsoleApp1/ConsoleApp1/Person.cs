using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    [Table(name:"Person")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get;set; }
        public string? LastName { get; set; }
    }
}
