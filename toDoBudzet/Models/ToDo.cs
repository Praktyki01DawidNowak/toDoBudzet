namespace toDoBudzet.Models
{
    public class ToDo
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string? ToDoName { get; set; }
    }
}
