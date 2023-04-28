namespace TemplateMethodEnumerableAndMore.Text
{
    internal class Text1
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _text;

        public Text1(int x, int y, string text)
        {
            _x = x;
            _y = y;
            _text = text;
        }

        public virtual void Show()
        {
            Write(_text);
        }

        protected void Write(string text, int deltaX = 0, int deltaY = 0)
        {
            Console.CursorLeft = _x + deltaX;
            Console.CursorTop = _y + deltaY;
            Console.Write(text);
        }
    }
}
