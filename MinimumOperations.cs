//You are given a number N. You have to find the number of operations required to reach N from 0. You have 2 operations available:

//Double the number
//Add one to the number

public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < noOfTC; ++t)
            {
                int num = Convert.ToInt32(Console.ReadLine());               
                MinimumOperations(num);                
            }
        }
        
        public static void MinimumOperations(int n)
        {
            int ops = 0;
            while(n>1)
            {
                if(n%2==0)
                {
                    n = n / 2;
                    ops++;
                }
                else
                {
                    n = n - 1;
                    ops++;
                }
            }
            ops++;
            Console.WriteLine(ops);
            Console.ReadLine();
        }        
