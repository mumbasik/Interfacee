namespace Interfacee
{ 

    //N1
    public interface IShow
    {
        void Show();
        void Info(int[] arr);
    }

    public interface IMath
    {
        void Max(int[] arr);
        void Min(int[] arr);
        void Average(int[] arr);
        bool Search(int valueToSearch);
    }

    public interface ISort
    {
        void SortAsc(int[] arr);
        void SortDesc(int[] arr);
        void SortByParam(bool IsAsc);
    }

    class Aray : IShow, IMath, ISort
    {
        public int[] arr { get; set; }

        public Aray(int[] ar)
        {
            arr = ar;
        }

        public void Info(int[] ar)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public void Max(int[] ar)
        {
            int max = arr.Max();
            Console.WriteLine("Max: " + max);
        }

        public void Min(int[] ar)
        {
            int min = arr.Min();
            Console.WriteLine("Min: " + min);
        }

        public void Average(int[] ar)
        {
            double average = ar.Average();
            Console.WriteLine("Average: " + average);
        }

        public bool Search(int valueToSearch)
        {
            foreach (int i in arr)
            {
                if (valueToSearch == i)
                {
                    Console.WriteLine("Match found");
                    return true;
                }
            }
            return false;
        }

        public void SortAsc(int[] ar)
        {
            Array.Sort(ar);  
        }
        public void SortDesc(int[] ar)
        {
            System.Array.Sort(ar, (a, b) => b.CompareTo(a));
        }

        public void SortByParam(bool asc)
        {
            if(asc)
            {
                SortAsc(arr);
            }
            else
            {
                SortDesc(arr);
            }
        }

       

        public void Show()
        {
            Console.WriteLine("Array of length: " + arr.Length);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            Aray obj = new Aray(new int[] { 1, 4, 2, 5, 3 });
            int[] arr = obj.arr;
            obj.Info(arr);
            obj.Show();

            //N2
            obj.Max(arr);
            obj.Min(arr);
            obj.Average(arr);
            obj.Search(5);

            //N3
            obj.SortAsc(arr);  
            obj.Info(arr);  
            obj.SortDesc(arr);
            obj.Info(arr);
            obj.SortByParam(true);  
            obj.Info(arr);

            
        }
    }
}

