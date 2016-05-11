using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryBrainGame
{
    class Memory
    {
        public int n, m; 
        public int[,] mat;
        public Dictionary<int, int> mapForRandom;
        public Random r;

        public Memory(int lvl)
        {
            if (lvl == 0)
            {
                //mat = new int[3, 4];
                n = 3;
                m = 4;
            }
            else if (lvl == 1)
            {
                //mat = new int[4, 5];
                n = 4;
                m = 5;
            }
            else if (lvl == 2)
            {
                //mat = new int[5, 6];
                n = 5;
                m = 6;
            }

            mat = new int[5, 6];

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    mat[i, j] = -1;
                }
            }

            mapForRandom = new Dictionary<int, int>();
        }

        public void fill()
        {
            int count = 0;

            if (n == 3 && m ==4)
                count = 6;
            else if (n == 4 && m == 5)
                count = 10;
            else
                count = 15;

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    while (true)
                    {
                        int random = r.Next(1, count + 1);
                        int check = 0;



                        if (mapForRandom.ContainsKey(random))
                        {
                            mapForRandom.TryGetValue(random, out check);

                            if (check+1 <= 2)
                            {
                                mapForRandom.Remove(random);
                                mapForRandom.Add(random, check + 1);
                                mat[i, j] = random;
                                break;
                            }
                        }
                        else
                        {
                            mapForRandom.Add(random, 1);
                            mat[i, j] = random;
                            break;
                        }
                    }
                }
            }
                
            

        }



    }
}
