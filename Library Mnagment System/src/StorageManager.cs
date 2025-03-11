using Newtonsoft.Json;

class StorageManager
{
    private static readonly string FilePath = "books.json";

    public static List<Book> LoadBooks()
    {
        try
        {
            if (!File.Exists(FilePath)) return new List<Book>();
            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
        }
        catch (Exception ex)
        {
            UserInputHelper.DisplayError($"Error loading books: {ex.Message}");
            return new List<Book>();
        }
    }

    public static void SaveBooks(List<Book> books)
    {
        try
        {
            string json = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
        catch (Exception ex)
        {
            UserInputHelper.DisplayError($"Error saving books: {ex.Message}");
        }
    }
}