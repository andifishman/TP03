namespace TP03.Models;

internal class Disco
{
    public string Nombre {get; private set; }
    public string Artista { get; private set; }
    public string Productor { get; private set; }
    public string Genero { get; private set;}
    public List<string> Temas { get; private set; }
    public int ID { get; private set; }
    public string Foto { get; private set; }
    public Disco(string N, string A, string P, string G, List<string> T, int ID, string F)
    {
        this.Nombre=N;
        this.Artista = A;
        this.Productor = P;
        this.Genero = G;
        this.Temas = T;
        this.ID = ID;
        this.Foto = F;
    }


}