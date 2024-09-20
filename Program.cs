namespace SearchingAndSorting
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
    }
    public class Program
    {
        //Linear Search
        #region
        List<int> list = new List<int> { 1, 2, 3 };
        static int Num(List<int> Nums, int x)
        {
            //var length = Nums.Count;
            foreach (var i in Nums)
            {
                if (Nums[i] == x)
                    return i;
            }
            return 0;
        }
        #endregion
        //Binary Search
        #region
        static int BinarySearch(List<int> Numbers, int x)
        {
            var start = 0;
            var end = Numbers.Count - 1;
            var middle = (end + start) / 2;
            while (Numbers[middle] != x && start < end)
            {
                if (x < Numbers[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
                middle = (end + start) / 2;
            }
            return (Numbers[middle] != x) ? -1 : middle;
        }
        #endregion
        //Interpolation Search
        #region
        int Interpolation(int[] arr, int length, int x)
        {
            int low = 0;
            int high = length - 1;
            while (low <= high && x >= arr[low] && x <= arr[high])
            {
                if (low == high)
                {
                    return low;
                }
                else
                {
                    return -1;
                }
            }
            int Position = low + (high - low) / (arr[low]) * (x - arr[low]);
            if (arr[Position] == x)
            {
                return Position;
            }
            if (arr[Position] < x)
            {
                low = Position + 1;
            }
            else
            {
                high = Position - 1;
            }
            return -1;
        }
        #endregion

        //Tree Traversal
        #region
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.WriteLine(root.Data);
                InOrder(root.Right);
            }

        }

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data);
                PreOrder(root.Left);
                PreOrder(root.Right );  
            }
        }

        public void PostOrder(Node root)
        {
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root.Data);
        }


       
        #endregion
        static void Main(string[] args)
        {
            Node leftNode = new Node()
            {
                Data = 1,
                Left = null,
                Right = null
            };

            Node rightNode = new Node()
            {
                Data = 3,
                Left = null,
                Right = null
            };

            Node root = new Node()
            {
                Data = 2,
                Left = leftNode,
                Right = rightNode
            };
           
        }
    }
}
