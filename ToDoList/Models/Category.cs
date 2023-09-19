using system.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public int ID { get; }
    public List<Item> Items { get; set; }
  }
}