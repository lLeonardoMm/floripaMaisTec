namespace Aula02.Models;

public abstract class Pessoa : BaseModel
{

    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }

}

public abstract class BaseModel
{

    public int Id { get; set; }
    public DateTime DataDeInclusao { get; set; }
    public DateTime? DataDeAlteracao { get; set; }
}