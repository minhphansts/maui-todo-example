namespace TODO.Model;

public class TodoItem
{
    public string Title { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? CompleteDate { get; set; }
}