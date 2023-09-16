using System;
namespace LinkedList
{
	public class Node
	{
        public Students_System SystemData;
        public Node Next;

        public Node(Students_System system)
        {
            SystemData = system;
            Next = null;
        }
    }
}

