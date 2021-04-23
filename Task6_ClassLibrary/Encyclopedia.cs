namespace Task6_ClassLibrary
{
    public class Encyclopedia : Book
    {
        public string EncyclopediaType { get; set; }
        public string EncyclopediaGenre { get; set; }

        public override string Open()
        {
            return "Open Encyclopedia...";
        }

        public override string Close()
        {
            return "Close Encyclopedia...";
        }

        public string Comment()
        {
            return "Comment Encyclopedia...";
        }

        public string Review()
        {
            return "Review Encyclopedia...";
        }
    }
}
