namespace TemplateMethodEnumerableAndMore.Text
{
    internal class BorderedText1 : Text1
    {
        private readonly string _border;

        public BorderedText1(int x, int y, string text) : base(x, y, text)
        {
            var borderLength = text.Length + 2;
            _border = string.Empty.PadLeft(borderLength, '*');
        }

        public override void Show()
        {
            Write(_border, -1, -1);
            Write(_border, -1, 0);
            Write(_border, -1, 1);
            base.Show();
        }
    }
}
