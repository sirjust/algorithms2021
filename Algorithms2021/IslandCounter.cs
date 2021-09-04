namespace Algorithms2021
{
    public class IslandCounter
    {
        public int CountIslands(int[,] map)
        {
            // example
            // 0 0 1 0 1
            // 0 0 1 0 0
            // 1 1 0 0 1
            // 1 0 0 1 1
            // 1 0 0 0 1 should be 4
            var count = 0;

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if(map[i,j] == 1)
                    {
                        if (CheckAbove(map, i, j))
                        {
                            continue;
                        }
                        if (CheckRight(map, i, j))
                        {
                            continue;
                        }
                        else
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        
        public bool CheckRight(int[,] map, int i, int j)
        {
                if (j >= map.GetLength(0) - 1) return false;
            if (map[i, j + 1] == 1) return true;
            return false;
        }

        public bool CheckAbove(int[,] map, int i, int j)
        {
            if (i == 0) return false;
            if (map[i - 1, j] == 1) return true;
            return false;
        }
    }
}
