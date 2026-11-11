namespace Indexatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] initialBooks = new Book[]
            {
                new Book("Преступление и наказание", "Ф.М. Достоевский"),
                new Book("Мастер и Маргарита", "М.А. Булгаков"),
                new Book("Война и мир", "Л.Н. Толстой"),
                new Book("Евгений Онегин", "А.С. Пушкин")
            };
            Library library = new Library(initialBooks);
            Console.WriteLine($"Книга по индексу 1: {library[1].Title}");
            library[0] = new Book("Идиот", "Ф.М. Достоевский");
            Console.WriteLine($"Новая книга по индексу 0: {library[0].Title}");
            try
            {
                Console.WriteLine(library[99].Title);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка доступа к элементу: {ex.Message}");
            }
        }
    }
}
