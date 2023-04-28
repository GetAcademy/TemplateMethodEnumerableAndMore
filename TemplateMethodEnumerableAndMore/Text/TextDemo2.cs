using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodEnumerableAndMore.Text
{
    internal class TextDemo2
    {
        public static void Run()
        {
            var text = new SimpleText2(1, 1, "Text1");
            var coloredText = new ColoredText2(1, 3, "ColoredText1", ConsoleColor.White, ConsoleColor.DarkBlue);
            var borderedText = new BorderedText2(3, 6, "BorderedText1");
            var borderedAndColoredText = new BorderedAndColoredText2(3, 10, "ColoredText1", ConsoleColor.White, ConsoleColor.DarkBlue);


            text.Show();
            coloredText.Show();
            borderedText.Show();
            borderedAndColoredText.Show();

            Console.CursorTop = 15;
        }
    }
}
