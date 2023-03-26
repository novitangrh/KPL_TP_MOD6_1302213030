
// See https://aka.ms/new-console-template for more information
using tpmodul6_1302213030;

class main
{
    public static void Main(String[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Novita Sabila Nugraha");
        video.printVideoDetails();

        for (int i = 0; i < 10000001; i += 10000000)
        {
            video.increasePlayCount(1000000);
        }
        Console.WriteLine();
        video.printVideoDetails();
    }
}
