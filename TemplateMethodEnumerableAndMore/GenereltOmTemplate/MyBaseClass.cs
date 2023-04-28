namespace TemplateMethodEnumerableAndMore.GenereltOmTemplate
{
    internal class MyBaseClass
    {

        public virtual void DoIt()
        {
            MainThing1();
            MainThing2();
            MainThing3();
        }

        protected virtual void MainThing1()
        {
            Console.WriteLine("Main thing 1");
        }
        protected virtual void MainThing2()
        {
            Console.WriteLine("Main thing 2");
        }
        protected virtual void MainThing3()
        {
            Console.WriteLine("Main thing 3");
        }

        //public virtual void DoIt()
        //{
        //    Console.WriteLine("Main thing 1");
        //    Console.WriteLine("Main thing 2");
        //    Console.WriteLine("Main thing 3");
        //}
    }
}
