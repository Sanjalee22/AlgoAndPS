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
                MinIntHeap minHeap = new MinIntHeap();
                minHeap.add(10);
                minHeap.add(20);
                minHeap.add(15);
                minHeap.add(12);
                minHeap.add(16);
                int x=minHeap.peek();
                minHeap.poll();
            }
            Console.ReadLine();
        }      


    }

    public class MinIntHeap
    {
        

        List<int> items = new List<int>();

        private int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        private int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private bool hasLeftChild(int index)
        {
            return getLeftChildIndex(index) < items.Count;
        }

        private bool hasRightChild(int index)
        {
            return getRightChildIndex(index) < items.Count;
        }

        private bool hasParent(int index)
        {
            return getParentIndex(index) >= 0;
        }

        private int leftChild(int index)
        {
            return items[getLeftChildIndex(index)];
        }

        private int rightChild(int index)
        {
            return items[getRightChildIndex(index)];
        }

        private int parent(int index)
        {
            return items[getParentIndex(index)];
        }

        private void swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        //get the first element from heap which is the minimum element
        public int peek()
        {
            if (items.Count == 0)
                throw new Exception("Heap is empty");
            return items[0];
        }

        //remove the first element from heap
        public int poll()
        {
            int totalElements = items.Count;
            if (totalElements == 0)
                throw new Exception("Heap is empty");
            int item = items[0];
            items[0] = items[totalElements-1];
            items.RemoveAt(totalElements-1);
            heapifyDown();
            return item;
        }

        public void add(int item)
        {
            
            items.Add(item);
            heapifyUp();
        }

        public void heapifyUp()
        {
            int index = items.Count - 1;
            while(hasParent(index) && parent(index)>items[index])
            {
                swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }
        }

        public void heapifyDown()
        {
            int index = 0;
            while(hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if(hasRightChild(index) && rightChild(index)<leftChild(index))
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (items[index] < items[smallerChildIndex])
                    break;
                else
                {
                    swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }

    }
