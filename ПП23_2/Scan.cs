using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AerialReconnaissance
{
    class Scan:GameMap
    {
        public Scan(int[,] Map,int SizeMapX, int SizeMapY) : base(Map,SizeMapX, SizeMapY )
        {
            this._map = Map;
            this._sizeMapX = SizeMapX;
            this._sizeMapY = SizeMapY;
            Thread thread = new Thread(Unit1);
            Thread thread1 = new Thread(Unit2);
            thread.Name = "1 поток";
            Console.WriteLine(thread.Name);
            thread.Start();

            thread.Join();
            thread1.Name = "2 поток";
            Console.WriteLine(thread1.Name);
            thread1.Start();
        }
    
        public void Unit1() 
        {
            int countunit1=0;
            for (int i = 0; i < _sizeMapX; i++)
            {
                for (int j = 0; j < _sizeMapY; j++)
                {
                    if (_map[i, j] == 1) 
                    {
                        countunit1++;
                    }
                }   
                Console.WriteLine(countunit1);
            }
            
        }
        public void Unit2() 
        {
            int countunit2=0;
            for (int i = _sizeMapX - 1; i >= 0; i--)
            {

                for (int j = _sizeMapY - 1; j >= 0; j--)
                {
                    if (_map[i, j] == 1)
                    {
                        countunit2++;

                    }
                }
                Console.WriteLine(countunit2);
            }
            
        }
    }
}
