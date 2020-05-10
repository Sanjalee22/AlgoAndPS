 public class CustomPair:IComparable<CustomPair>
    {
       public int startTime;
       public int finishTime;

        public CustomPair(int s, int f)
        {
            startTime = s;
            finishTime = f;
        }

        public int CompareTo(CustomPair p)
        {            
            return this.finishTime.CompareTo(p.finishTime);
        }

        
    }

    class Program
    {

        public static void Main(string[] args)
        {
            int noOfTC = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < noOfTC; ++t)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                string[] s1 = Console.ReadLine().Split(' ');
                //int[] startArray = Array.ConvertAll(s1, int.Parse);
                string[] s2 = Console.ReadLine().Split(' ');                
                //int[] endArray = Array.ConvertAll(s1, int.Parse);
                List<CustomPair> timingsArray =CreateCustomPairs(s1, s2);
                MeetingRoomSelection(timingsArray);
                
            }
        }
        
        public static void MeetingRoomSelection(List<CustomPair> timingsArray)
        {
            List<CustomPair> scheduledList = new List<CustomPair>();
            scheduledList.Add(timingsArray[0]);

            for(int i=1;i<timingsArray.Count;++i)
            {
                if (timingsArray[i].startTime >= scheduledList[scheduledList.Count - 1].finishTime)
                    scheduledList.Add(timingsArray[i]);
            }

            foreach (CustomPair cp in scheduledList)
                Console.WriteLine(cp.startTime + "-->" + cp.finishTime);
            Console.ReadLine();
        }

        public static List<CustomPair> CreateCustomPairs(string[] start, string[] finish)
        {
            List<CustomPair> timingsArray = new List<CustomPair>();
            for (int i=0;i<start.Length;++i)
            {
                timingsArray.Add(new CustomPair(Convert.ToInt32(start[i]), Convert.ToInt32(finish[i])));
            }
            timingsArray.Sort();
            return timingsArray;
        }
