namespace GenericsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = MaximumInteger.FindMaxInt(22, 45, 60);
            Console.WriteLine("Maximum Integer number is:" +result);

            float result1 = MaximumFloat.FindMaxFloat(22.4f, 44.6f, 63.6f);
            Console.WriteLine("Maximum Float Number is: " + result1);

            string Result2 = MaximumString.FindMaxString("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String is:" + Result2);


        }
    }
}