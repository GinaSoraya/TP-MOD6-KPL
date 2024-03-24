// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class Program
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            random input = new random();
            id = input.id();
            playCount = 0;
            Debug.Assert(title.Length < 100 && title != null);
            
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount < 10000000);
            try
            {
                checked
                {
                    this.playCount = playCount;
                }
            }
            catch (OverflowException) {
                Console.WriteLine("Penambahan play count");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("id video:  " + id);
            Console.WriteLine("judul video: " + this.title);
            Console.WriteLine("playCount: " + this.playCount);
        }
    }
    public static void Main(String[] args)
    {
        SayaTubeVideo input = new SayaTubeVideo("Tutorial Design By Contract - GINA SORAYA");
        input.IncreasePlayCount(int.MaxValue);
        input.PrintVideoDetails();
    }
    class random
    {
        public int id()
        {
            Random input = new Random();
            return input.Next(10000, 99999);
        }
    }
}