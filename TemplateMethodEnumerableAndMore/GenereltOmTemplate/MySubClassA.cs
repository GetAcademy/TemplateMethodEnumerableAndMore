namespace TemplateMethodEnumerableAndMore.GenereltOmTemplate
{
    internal class MySubClassA : MyBaseClass
    {
        public override void DoIt()
        {
            Console.WriteLine("A thing before");
            base.DoIt();
            Console.WriteLine("A thing after");
        }

        protected override void MainThing2()
        {
            //base.MainThing2();
            Console.WriteLine("A version of thing 2");
            // base.MainThing2();
        }
    }
}
