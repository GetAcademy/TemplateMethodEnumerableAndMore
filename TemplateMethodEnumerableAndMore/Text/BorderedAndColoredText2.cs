namespace TemplateMethodEnumerableAndMore.Text
{
    internal class BorderedAndColoredText2 : Text2
    {
        private readonly ConsoleColor _foregroundColor;
        private readonly ConsoleColor _backgroundColor;
        private ConsoleColor? _savedForegroundColor = null;
        private ConsoleColor? _savedBackgroundColor = null;
        private readonly string _border;

        public BorderedAndColoredText2(
            int x, int y, string text,
            ConsoleColor foregroundColor, ConsoleColor backgroundColor) 
            : base(x, y, text)
        {
            _backgroundColor = backgroundColor;
            _foregroundColor = foregroundColor;
            var borderLength = text.Length + 2;
            _border = string.Empty.PadLeft(borderLength, '*');

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
        protected override void ShowBorder()
        {
            Write(_border, -1, -1);
            Write(_border, -1, 0);
            Write(_border, -1, 1);
        }
    }
}
