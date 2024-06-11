namespace MyLibrary.Models;

public class Loan
{
    public int LoanId { get; set; }
    public DateTime DateLoan { get; set; }
    public DateTime DateReturn { get; set; }

    //Chave estrangeira aluno
    public int StudentId { get; set; }
    public Student? Student { get; set; }

    // Fim-Chave estrangeira aluno

    //Chave estrangeira livro
    public int BookId { get; set; }
    public Book? Book { get; set; }

    // fim-Chave estrangeira livro
}
