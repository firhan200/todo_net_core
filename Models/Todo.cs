namespace Todov2.Models
{
    public class Todo
    {
        public Todo(int? id, string title)
        {
            Id = id;
            Title = title;
        }

        public int? Id { get; set; }
        public string Title { get; set; }
    }
}
