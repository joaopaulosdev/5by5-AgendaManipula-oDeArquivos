public class Pessoa
{
    public string Nome { get; set; }
    public string Contato {  get; set; }
    public char Genero { get; set; }
    public Pessoa(string nome, string contato, char genero)
    {
        Nome = nome;
        Contato = contato;
        Genero = genero;

    }

    public string FormatarParaArquivo()
    {
        return Nome + "," + Contato + "," + Genero;
    }
}