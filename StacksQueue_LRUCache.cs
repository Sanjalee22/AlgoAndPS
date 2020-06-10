 public class Node
    {
        public int value;
        public int key;
        public Node next;
        public Node prev;
        public Node(int key,int value)
        {
            this.value = value;
            this.key = key;
            this.prev = null;
            this.next = null;
        }

    }

    //Create the LRU Cache class

    public class LRUCache
    {
        public int capacity;
        Node head;
        Node tail;
        public Dictionary<int, Node> cache;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new Dictionary<int, Node>();
            head = null;
            tail = null;
        }


       public int get(int key)
        {
            return cache[key].value;
        }

        public void set(int key, int value)
        {
            Node newNode = new Node(key, value);
            //if key exists, set that and move it to front
            if (cache.ContainsKey(key))
            {
                deleteNode(cache[key]);
                cache[key] = newNode;                
            }

            else //key doesn't exist
            {
                //check for capacity. If capacity is full, remove from back and add this new node to front
                if(cache.Count==capacity)
                {
                    cache.Remove(tail.key);
                   
                    deleteNode(tail);
                    
                    
                }
                //if capacity is available, add this one to front.
                cache.Add(key, newNode);                
            }
            addFront(newNode);
        }

        private void addFront(Node newnode)
        {

            if (head == null && tail==null)
                head = tail = newnode;
            else
            {
                newnode.next = head;
                head.prev = newnode;
                head = newnode;
            }
                //add at the begining of LL
                
            
        }

        private void deleteNode(Node node)
        {            
            if (cache.Count==1)
            {
                head = tail = null;
                return;
            }
            if (node == tail)
                tail = tail.prev;
            if (node.prev != null)
            {
                node.prev.next = node.next;
            }
            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
        }

    }


    class Program
    {

        public static void Main(string[] args)
        {
           
            int noOfTC = Convert.ToInt32(Console.ReadLine());
             
            for (int t = 0; t < noOfTC; ++t)
            {
                ////int num = Convert.ToInt32(Console.ReadLine());
                //string[] s1 = Console.ReadLine().Split(' ');
                ////int[] arr = Array.ConvertAll(s1, int.Parse);
                ////string str = Console.ReadLine();
                //int i = 0;
                LRUCache lru = new LRUCache(3);
                lru.set(1, 3);
                lru.set(2, 4);
                Console.WriteLine(lru.get(2));
                lru.set(5, 6);
                lru.set(1, 8);
                Console.WriteLine(lru.get(1));
                lru.set(12, 14);
                Console.WriteLine(lru.get(2));
            
               

            }
            Console.ReadLine();
        }

     
       
    }
