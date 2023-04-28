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
    }
}
