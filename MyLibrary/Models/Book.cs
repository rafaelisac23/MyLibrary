using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

public class Book
{
    public Book()
    {
        Loans = new Collection<Loan>();
    }

    public int BookId { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    public string? Genre { get; set; }

    //chave estrangeira
    [Required]
    public int PublisherId {  get; set; }
    public Publisher? Publisher { get; set; }

    //fim

    //coleção//
    public ICollection<Loan>? Loans { get; set; }


   

}
