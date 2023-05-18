Task
You are given N ropes, where the length of each rope is a positive integer. At each step, you have to reduce all the ropes by the length of the smallest rope.

The step will be repeated until no ropes are left. Given the length of N ropes, print the number of ropes that are left before each step.

Example
For a = [3, 3, 2, 9, 7], the result should be [5, 4, 2, 1]

 You have 5 ropes:                           3 3 2 9 7   ( 5 left) step 1:          1 1 0 7 5   ( 4 left) step 2:          0 0 0 6 4   ( 2 left) step 3:          0 0 0 0 2   ( 1 left) step 4:          0 0 0 0 0     Hence the result is [5, 4, 2, 1]

Input/Output
[input] integer array a
length of each rope.

3 <= a.length <= 2000

1 <= a[i] <= 100

[output] an integer array
number of ropes before each step.

------------------------------------------------
solutions

public int[] CutTheRopes(int[] a){
          var list=new List<int>();
          while(a.Sum()>0)         
          {
            list.Add(a.Count(x=>x>0));
            var min =a.Where(x=>x>0).Min();            
            a=a.Select(x=>x==0?0:x-min).ToArray();
          }
          return list.ToArray();

--------------

int length = a.Length;
            return new[] { length }
                .Concat(a
                    .GroupBy(x => x)
                    .OrderBy(x => x.Key)
                    .Select(x => length -= x.Count())
                    .SkipLast(1)
                ).ToArray();

--------------

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

---------------------

List<int> sourceArray = new List<int>(a);
            List<int> result = new List<int>();

            while (sourceArray.Count != 0)
            {
                result.Add(sourceArray.Count());
                int min = sourceArray.Min();

                sourceArray = sourceArray.Select(x => x - min).Where(f => f > 0).ToList();
            }

            return result.ToArray();








-

List<int> res = new List<int>() { a.Length };
          Array.Sort(a);
          while (true)
          {
            a = a.Select(x => x - a[0]).Where(x => x > 0).ToArray();
            if (a.Count() > 0)
              res.Add(a.Length);
            else
              return res.ToArray();

-












