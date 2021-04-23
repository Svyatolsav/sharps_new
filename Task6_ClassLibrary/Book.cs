namespace Task6_ClassLibrary
{
    public abstract class Book : IEdition
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Raiting { get; set; }

        public string Read()
        {
            return "Read book...";
        }

        public abstract string Open();

        public abstract string Close();
    }
}
