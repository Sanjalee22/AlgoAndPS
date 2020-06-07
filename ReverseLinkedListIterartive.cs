public static Node reverseList(Node head)
        {
            // add code here
            Node nextnode = null, tmp = null;
            while (head != null)
            {
                nextnode = head.next;     // Take the head next as nextnode
                head.next = tmp;          // Make the head next as tmp node
                tmp = head;               // Update tmp node to store the head node
                head = nextnode;          // Make head next move to the next node
            }
            return tmp;
        }
