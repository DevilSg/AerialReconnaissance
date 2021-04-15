using System;

namespace AerialReconnaissance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размеры карты по X: ");
            int SizeMapX = int.Parse(Console.ReadLine());
            Console.WriteLine("Размеры карты по Y: ");
            int SizeMapY = int.Parse(Console.ReadLine());
            
            int[,] map = new int [SizeMapX,SizeMapY];
            GameMap gamemap = new GameMap(map,SizeMapX,SizeMapY);
            gamemap.CreateMap();
            Scan scan = new Scan(map,SizeMapX, SizeMapY);
            
            
        }
    }
}
