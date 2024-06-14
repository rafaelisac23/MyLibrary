using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;


public class Student
{
    public Student()
    {
        Loans = new Collection<Loan>();
    }
   
    public int StudentId { get; set; } //nesse formato o EF sabe que é chave primaria 

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    public DateTime DateBirth { get; set; }

    [Required]
    [StringLength(100)]
    public string? Email { get; set; }
    [Required]
    public string? Cellphone { get; set; }

    //coleçoes//
    public ICollection<Loan>? Loans { get; set; }

   


}
