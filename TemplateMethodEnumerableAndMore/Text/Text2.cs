namespace TemplateMethodEnumerableAndMore.Text
{
    internal class Text2
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _text;

        public Text2(int x, int y, string text)
        {
            _x = x;
            _y = y;
            _text = text;
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
        }

        protected virtual void ShowText()
        {
            Write(_text);
        }

        protected virtual void ShowBorder()
        {
        }

        protected virtual void SetColor()
        {
        }

        protected void Write(string text, int deltaX = 0, int deltaY = 0)
        {
            Console.CursorLeft = _x + deltaX;
            Console.CursorTop = _y + deltaY;
            Console.Write(text);
        }
    }
}
