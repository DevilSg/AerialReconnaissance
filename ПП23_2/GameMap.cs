using System;
using System.Collections.Generic;
using System.Text;

namespace AerialReconnaissance
{
    class GameMap
    {
        protected int _sizeMapX;
        protected int _sizeMapY;
        protected int[,] _map;
        
        public GameMap(int[,] Map, int SizeMapX, int SizeMapY)
        {
            this._map = Map;
            this._sizeMapX = SizeMapX;
            this._sizeMapY = SizeMapY;
            
        }
        public void CreateMap()
        {
            Random random = new Random();
            for (int i = 0; i < _sizeMapX;i++) 
            {
                for (int j = 0; j < _sizeMapY; j++) 
                {
                    _map[i, j] = random.Next(0, 2);
                    Console.Write($"{_map[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
       
    }
}
