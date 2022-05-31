public class Pessoa
{
    public int Idade { get; set; }

    public string Nome { get; set; }

    public string Documento { get; set; }
    
    //Clona as propriedades (jeito mais interessante para clonar)
    public Pessoa Clone()
    {
        return new Pessoa()
        {
            Documento = this.Documento,
            Idade = this.Idade,
            Nome = this.Nome
        };
    }
}