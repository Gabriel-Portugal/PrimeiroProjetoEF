public class Categoria
{
    public int Id { get;set; }
    public required string Nome { get; set;}
    public List<Tarefas> Tarefas { get;set;} = [];
}