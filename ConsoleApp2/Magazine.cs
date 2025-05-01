using System.Linq;

public class Magazine
{
    private string _name;
    private Frequency _frequency;
    private DateTime _releaseDate;
    private int _circulation;
    private Article[] _articles;

    // Конструктор с параметрами
    public Magazine(string name, Frequency frequency, DateTime releaseDate, int circulation)
    {
        _name = name;
        _frequency = frequency;
        _releaseDate = releaseDate;
        _circulation = circulation;
        _articles = new Article[0];
    }

    // Конструктор по умолчанию
    public Magazine()
    {
        _name = "Новый журнал";
        _frequency = Frequency.Monthly;
        _releaseDate = DateTime.Now;
        _circulation = 1000;
        _articles = new Article[0];
    }

    // Свойства
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Frequency Frequency
    {
        get => _frequency;
        set => _frequency = value;
    }

    public DateTime ReleaseDate
    {
        get => _releaseDate;
        set => _releaseDate = value;
    }

    public int Circulation
    {
        get => _circulation;
        set => _circulation = value;
    }

    public Article[] Articles
    {
        get => _articles;
        set => _articles = value;
    }

    // Средний рейтинг (только чтение)
    public double AverageRating => _articles.Length == 0 ? 0 : _articles.Average(a => a.Rating);

    // Индексатор
    public bool this[Frequency frequency] => _frequency == frequency;

    // Добавление статей
    public void AddArticles(params Article[] newArticles)
    {
        _articles = _articles.Concat(newArticles).ToArray();
    }

    public override string ToString()
    {
        string articlesInfo = string.Join("\n", _articles.Select(a => a.ToString()));
        return $"Название: {_name}\nПериодичность: {_frequency}\nДата выхода: {_releaseDate:dd.MM.yyyy}\nТираж: {_circulation}\nСтатьи:\n{articlesInfo}";
    }

    public string ToShortString()
    {
        return $"Название: {_name}\nПериодичность: {_frequency}\nДата выхода: {_releaseDate:dd.MM.yyyy}\nТираж: {_circulation}\nСредний рейтинг: {AverageRating:F2}";
    }
}