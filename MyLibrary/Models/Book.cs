using System.Collections.ObjectModel;

namespace MyLibrary.Models;

public class Book
{
    public Book()
    {
        Loans = new Collection<Loan>();
    }

    public int BookId { get; set; }
    public string? Name { get; set; }
    public string? Genre { get; set; }

    //chave estrangeira
    public int PublisherId {  get; set; }
    public Publisher? Publisher { get; set; }

    //fim

    //coleção//
    public ICollection<Loan>? Loans { get; set; }


   

}
