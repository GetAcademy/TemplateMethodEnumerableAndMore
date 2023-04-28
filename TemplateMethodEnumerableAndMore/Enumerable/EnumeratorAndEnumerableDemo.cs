namespace TemplateMethodEnumerableAndMore.Enumerable
{
    internal class EnumeratorAndEnumerableDemo
    {
        public static void Run()
        {
            var myEnumerator = new MyNumbers();
            foreach (var element in myEnumerator)
            {
                Console.WriteLine(element);
            }

            foreach (var element in myEnumerator)
            {
                Console.WriteLine(element);
            }

            var otherNumbers = myEnumerator.Select(n => n + 1);


            var numbers = new int[] {1, 2, 3};
            var enumerator = numbers.GetEnumerator();
        }
    }
}
