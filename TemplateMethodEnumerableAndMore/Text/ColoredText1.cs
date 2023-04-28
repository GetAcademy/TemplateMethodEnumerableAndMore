using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodEnumerableAndMore.Text
{
    internal class ColoredText1 : Text1
    {
        private readonly ConsoleColor _foregroundColor;
        private readonly ConsoleColor _backgroundColor;

        public ColoredText1(int x, int y, string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor) 
            : base(x, y, text)
        {
            _foregroundColor = foregroundColor;
            _backgroundColor = backgroundColor;
        }

        public override void Show()
        {
            var savedForegroundColor = Console.ForegroundColor;
            var savedBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = _backgroundColor;
            base.Show();
            Console.ForegroundColor = savedForegroundColor;
            Console.BackgroundColor = savedBackgroundColor;
        }
    }
}
