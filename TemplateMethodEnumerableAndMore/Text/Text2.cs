namespace TemplateMethodEnumerableAndMore.Text
{
    internal abstract class Text2
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _text;
        private readonly ConsoleColor _foregroundColor;
        private readonly ConsoleColor _backgroundColor;
        private ConsoleColor? _savedForegroundColor = null;
        private ConsoleColor? _savedBackgroundColor = null;
        private readonly string _border;

        protected Text2(int x, int y, string text)
        {
            _x = x;
            _y = y;
            _text = text;
            var borderLength = text.Length + 2;
            _border = string.Empty.PadLeft(borderLength, '*');
        }

        protected Text2(int x, int y, string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        :this(x, y, text)
        {
            _foregroundColor = foregroundColor;
            _backgroundColor = backgroundColor;
        }

        public void Show()
        {
            SetColor();
            ShowBorder();
            ShowText();
            ResetColor();
        }

        protected virtual void ResetColor()
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


        protected virtual void ShowText()
        {
            Write(_text);
        }

        protected virtual void ShowBorder()
        {
            Write(_border, -1, -1);
            Write(_border, -1, 0);
            Write(_border, -1, 1);
        }

        protected virtual void SetColor()
        {
            _savedForegroundColor = Console.ForegroundColor;
            _savedBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = _backgroundColor;
        }

        protected void Write(string text, int deltaX = 0, int deltaY = 0)
        {
            Console.CursorLeft = _x + deltaX;
            Console.CursorTop = _y + deltaY;
            Console.Write(text);
        }
    }
}
