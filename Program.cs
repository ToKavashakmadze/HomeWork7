namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var File = new File1();
            File.size = 128;
            File.TypeOfFile = "txt";
            File.Write();
            File.delete();
            File.Edit();
            File.Read();

        }
    }
}