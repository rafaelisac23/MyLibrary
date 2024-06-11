namespace MyLibrary.Models;

public class Student
{
    public int StudentId { get; set; } //nesse formato o EF sabe que é chave primaria 
    public string? Name { get; set; }
    public DateTime DateBirth { get; set; }
    public string? Email { get; set; }
    public string? cellphone { get; set; }

    // ainda não criado chaves estrangeiras


}
