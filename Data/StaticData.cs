using WebApplication051024_Fitnes.Models;

namespace WebApplication051024_Fitnes.Data
{
    public static class StaticData
    {
        public static List<Category> Categories = new List<Category>
    {
        new Category
        {
            Id = 1,
            Name = "Для набора мышечной массы",
            Description = "Программы для набора мышечной массы.",
            Articles = new List<Article>
            {
                new Article { Id = 1, Title = "Программа тренировок", Content = "Полное содержание статьи 1..." },
                new Article { Id = 2, Title = "Питание для мышечной массы", Content = "Полное содержание статьи 2..." }
            }
        },
        new Category
        {
            Id = 2,
            Name = "Для похудения",
            Description = "Программы для похудения.",
            Articles = new List<Article>
            {
                new Article { Id = 3, Title = "Кардио тренировки", Content = "Полное содержание статьи 3..." },
                new Article { Id = 4, Title = "Диеты и питание", Content = "Полное содержание статьи 4..." }
            }
        },
        new Category
        {
            Id = 3,
            Name = "Людям за 60",
            Description = "Программы для людей старше 60 лет.",
            Articles = new List<Article>
            {
                new Article { Id = 5, Title = "Упражнения для старшего возраста", Content = "Полное содержание статьи 5..." },
                new Article { Id = 6, Title = "Питание для старшего возраста", Content = "Полное содержание статьи 6..." }
            }
        }
    };
    }
}
