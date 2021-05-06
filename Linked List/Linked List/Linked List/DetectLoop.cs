using LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
  public  class DetectLoop
    {

        public int LoopCount(LinkedList linkedList)
        {

            if (linkedList == null)
            {
                return 0;
            }

            if (linkedList.Head == linkedList.Head.Next)
            {
                return 1;
            }
            int count = 0;
            Node pointer = linkedList.Head;
            Node pointer1 = linkedList.Head.Next;
            bool hasLoop = false;
            while (pointer != pointer1 && pointer1 != null && pointer1.Next != null)
            {
                pointer = pointer.Next;
                pointer1 = pointer1.Next.Next;

                if (pointer == pointer1)
                {
                    hasLoop = true;
                    break;

                }
            }
            if (!hasLoop) return 0;

            do
            {
                pointer = pointer.Next;
                count++;
            } while (pointer != pointer1);

            return count;
        }
    }
}
