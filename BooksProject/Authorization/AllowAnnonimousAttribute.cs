namespace BooksProject.Authorization
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AllowAnnonimousAttribute : Attribute
    {
    }
}
