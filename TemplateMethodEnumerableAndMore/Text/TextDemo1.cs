namespace TemplateMethodEnumerableAndMore.Text
{
    internal class TextDemo1
    {
        public static void Run()
        {
            var text1 = new Text1(1, 1, "Text1");
            var coloredText1 = new ColoredText1(1, 3, "ColoredText1", ConsoleColor.White, ConsoleColor.DarkBlue);
            var borderedText1 = new BorderedText1(3, 6, "BorderedText1");

            text1.Show();
            coloredText1.Show();
            borderedText1.Show();

            Console.CursorTop = 10;
        }
    }
}
