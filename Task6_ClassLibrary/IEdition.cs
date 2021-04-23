namespace Task6_ClassLibrary
{
    public interface IEdition
    {
        string Name { get; set; }

        string Open();

        string Close();
    }
}
