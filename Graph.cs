using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adHoc
{

    public class Graph
    {
        private float deg;

        private const int inf = 100000;
        private int n;
        public Graph(int vertexCount)
        {
            n = vertexCount;
        }
        //заменить на ф-цию определения числа компонент связности
        public float AverageDegree(int[][] G)
        {

            deg = 0;
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        deg += G[i][j];
                    }
                }
            
            return (deg / n);
        }
    }
}
