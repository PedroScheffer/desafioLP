public class Livro
{
    public string? Titulo;
    public Autor? AutorLivro;
    public double Preço;

    public Livro (string titulo, Autor autorlivro)
    {
        this.Titulo = titulo;
        this.AutorLivro = autorlivro;
    }
    public Livro (string titulo, Autor autorlivro, double preço)
    {
        this.Titulo = titulo;
        this.AutorLivro = autorlivro;
        this.Preço = preço;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Título: {this.Titulo}\nAutor do Livro: {this.AutorLivro}\nPreço: {this.Preço}");
    }
    public void AplicarDesconto(double valor)
    {
        Preço -= Preço *(valor / 100);
    }
    public void AplicarDesconto(int valor)
    {
        Preço = Preço - valor;
    }
}