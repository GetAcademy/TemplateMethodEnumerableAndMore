namespace TemplateMethodEnumerableAndMore.Text
{
    internal class BorderedText2 : Text2
    {
        private readonly string _border;

        public BorderedText2(int x, int y, string text) : base(x, y, text)
        {
            var borderLength = text.Length + 2;
            _border = string.Empty.PadLeft(borderLength, '*');
        }

        protected override void ShowBorder()
        {
            Write(_border, -1, -1);
            Write(_border, -1, 0);
            Write(_border, -1, 1);
        }
    }
}
