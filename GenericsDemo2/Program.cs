namespace GenericsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int result = MaximumInteger.FindMaxInt(22, 45, 60);
            //Console.WriteLine("Maximum Integer number is:" +result);

            //float result1 = MaximumFloat.FindMaxFloat(22.4f, 44.6f, 63.6f);
            //Console.WriteLine("Maximum Float Number is: " + result1);

            //string Result2 = MaximumString.FindMaxString("Apple", "Peach", "Banana");
            //Console.WriteLine("Maximum String is:" + Result2);

            //GenericsMaximum<int> obj = new GenericsMaximum<int>(23, 50, 5);
            //int result = obj.FindMaxUsingGenerics(23, 50, 5);
            //Console.WriteLine("Maximum Integer is:" + result);
            //Console.WriteLine(result);



            //GenericsMaximum<float> obj1 = new GenericsMaximum<float>(23.25f, 50.25f, 50.3f);
            //float result2 = obj1.FindMaxUsingGenerics(23.25f, 50.25f, 50.3f);
            //Console.WriteLine("Maximum Float is :" + result2);
            //Console.WriteLine(result2);


            //GenericsMaximum<string> obj2 = new GenericsMaximum<string>("Apple", "Peach", "Banana");
            //string result3 = obj2.FindMaxUsingGenerics("Apple", "Peach", "Banana");
            //Console.WriteLine("Greatest String is :" + result3);
            //Console.WriteLine(result3);

            //extend max method for more than theree parameter
            ExtendMaxMethod<string> max = new ExtendMaxMethod<string>("Apple", "Peach", "Banana", "Mango");
            string maxString = max.GetMax();
            Console.WriteLine(maxString);




        }
    }


}
    
