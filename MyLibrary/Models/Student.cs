using System.Collections.ObjectModel;

namespace MyLibrary.Models;

public class Student
{
    public Student()
    {
        Loans = new Collection<Loan>();
    }
    public int StudentId { get; set; } //nesse formato o EF sabe que é chave primaria 
    public string? Name { get; set; }
    public DateTime DateBirth { get; set; }
    public string? Email { get; set; }
    public string? Cellphone { get; set; }

    //coleçoes//
    public ICollection<Loan>? Loans { get; set; }

   


}
