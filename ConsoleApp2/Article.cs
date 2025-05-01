using System.Linq;

public class Article
{
    public Person Author { get; set; }
    public string Title { get; set; }
    public double Rating { get; set; }

    // Конструктор с параметрами
    public Article(Person author, string title, double rating)
    {
        Author = author;
        Title = title;
        Rating = rating;
    }

    // Конструктор по умолчанию
    public Article()
    {
        Author = new Person("Неизвестно", "Автор");
        Title = "Без названия";
        Rating = 0.0;
    }

    public override string ToString()
    {
        return $"Автор: {Author}, Название: {Title}, Рейтинг: {Rating}";
    }
}