using System.Collections.ObjectModel;

namespace MyLibrary.Models;

public class Publisher
{
    public Publisher()
    {
        Books = new Collection<Book>();
    }

    public int PublisherId { get; set; }
    public string? Name { get; set; }
    public DateTime Ano { get; set; }

    public ICollection<Book>? Books { get; set; }

    //ainda não criado chave estrangeira
}
