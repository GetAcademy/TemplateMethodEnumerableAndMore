namespace TemplateMethodEnumerableAndMore.Text
{
    internal class ColoredText2 : Text2
    {
        public ColoredText2(int x, int y, string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor) 
            : base(x, y, text, foregroundColor, backgroundColor)
        {
        }

        protected override void ShowBorder()
        {
        }
    }
}
