namespace MyLibrary.Models;

public class Loan
{
    public int LoanId { get; set; }
    public DateTime DateLoan { get; set; }
    public DateTime DateReturn { get; set; }

    //ainda nãoo criado chave estrangeira
}
