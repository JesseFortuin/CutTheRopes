namespace CutTheRopes.BL
{
    public class RopeCutter : IRopeCutter
    {
        public int[] CutTheRopes(int[] a)
        {
            List<int> result = new List<int>();

            int numRopes = a.Length;

            while (numRopes > 0)
            {
                result.Add(numRopes);

                int minRopeLength = GetMinRopeLength(a);

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0)
                    {
                        a[i] -= minRopeLength;
                        if (a[i] == 0)
                        {
                            numRopes--;
                        }
                    }
                }
            }

            return result.ToArray();
        }

        public static int GetMinRopeLength(int[] ropes)
        {
            int minRopeLength = int.MaxValue;

            for (int i = 0; i < ropes.Length; i++)
            {
                if (ropes[i] > 0 && ropes[i] < minRopeLength)
                {
                    minRopeLength = ropes[i];
                }
            }
            return minRopeLength;
        }
    }
}