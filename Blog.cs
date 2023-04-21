namespace CFDemo
{
    internal partial class Program
    {
        public class Blog
        {
            public int BlogId { get; set; }
            public string? BlogName { get; set; }
            public virtual ICollection<Post>? Posts { get; set; }
        }
    }
}