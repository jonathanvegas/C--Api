namespace Services;

public interface iTodoServices{
  List<Todo> GetAll();
  Todo Create(string title);
}
public class TodoServices : iTodoServices
{
  private List<Todo> _todos = new List<Todo>();
  public Todo Create(string title)
  {
    var todo = new Todo {Title = title, IsCompleted = false};
    _todos.Add(todo);
    return todo;
  }

  public List<Todo> GetAll()
  {
    return _todos;
  }
}