using System.Net;

internal class Program
{
    private static async Task Main(string[] args)
    {
        //using (HttpClient client = new HttpClient())
        //{
        //    var link = Console.ReadLine();
        //    byte[] image = await client.GetByteArrayAsync(link);
        //    var fileName = Guid.NewGuid().ToString() + ".png";
        //    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        //    File.WriteAllBytes(path, image);

        //    Console.WriteLine(Path.Combine(path, fileName));
        //}

        Console.WriteLine("Rasmning linkini kiriting:");
        string link = Console.ReadLine();

        using (WebClient client = new WebClient())
        {
            try
            {
                string fileName = "image.png"; // Rasm fayl nomi
                client.DownloadFile(link, fileName);
                string path = System.IO.Path.GetFullPath(fileName);
                Console.WriteLine("Rasm muvaffaqiyatli yuklandi. Yo'l: " + path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rasmni yuklashda xatolik yuz berdi: " + ex.Message);
            }
        }
    }
}