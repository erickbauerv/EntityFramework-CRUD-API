using System.ComponentModel.DataAnnotations;

namespace CRUD_API.Entities
{
  public class Student
  {
    [Key]
    public int Id { get; init; }
    public string Name { get; private set; }
    public bool active { get; private set; }

    public Student() { 
      
    }
  }
}
