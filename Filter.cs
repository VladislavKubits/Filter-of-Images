using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_images
{
    class Filter
    {
        public float k = 1.0f / 10.0f;
        public int[,] matrix = new int[3, 3];

        public void Get_matrix(StreamReader sr)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    string s = "";
                    while (sr.Peek() != 32 && sr.Peek() != 13 && sr.Peek() != 10)
                    {
                        s += Convert.ToChar(sr.Read()).ToString();
                    }
                    if (s != "")
                    {
                        sr.Read();
                        this.matrix[i, j] = Int32.Parse(s);
                    }
                    else
                    {
                        --j;
                        sr.Read();
                    }
                }
            }
            sr.Read();
            sr.Read();
            sr.Read();
            sr.Read();
        }
    }
}
