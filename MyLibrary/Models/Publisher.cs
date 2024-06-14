using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

public class Publisher
{
    public Publisher()
    {
        Books = new Collection<Book>();
    }

    public int PublisherId { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
    public DateTime Ano { get; set; }

    public ICollection<Book>? Books { get; set; }

    //ainda não criado chave estrangeira
}
