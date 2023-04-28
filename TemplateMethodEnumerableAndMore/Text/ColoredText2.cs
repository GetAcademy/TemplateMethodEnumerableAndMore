namespace TemplateMethodEnumerableAndMore.Text
{
    internal class ColoredText2 : Text2
    {
        private ConsoleColor _foregroundColor;
        private ConsoleColor _backgroundColor;
        private ConsoleColor? _savedForegroundColor = null;
        private ConsoleColor? _savedBackgroundColor = null;

        public ColoredText2(int x, int y, string text,
            ConsoleColor foregroundColor, ConsoleColor backgroundColor)
            : base(x, y, text)
        {
            _backgroundColor = backgroundColor;
            _foregroundColor = foregroundColor;
        }

        protected override void SetColor()
        {
            _savedForegroundColor = Console.ForegroundColor;
            _savedBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = _backgroundColor;
        }

        protected override void ResetColor()
        {
            if (_savedForegroundColor != null)
            {
                Console.ForegroundColor = _savedForegroundColor.Value;
            }
            if (_savedBackgroundColor != null)
            {
                Console.BackgroundColor = _savedBackgroundColor.Value;
            }
        }
    }
}
