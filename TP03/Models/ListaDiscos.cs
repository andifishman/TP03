namespace TP03.Models;

internal class ListaDiscos
{
public List<Disco> Discos { get; private set; }
public ListaDiscos()
{
this.Discos = new List<Disco>();
}
public void verificar()
{
for(int i = 0; i<Discos.Count; i++)
    {
        for(int j = 0; j<Discos.Count; j++)
        {
            if(j!=i)
            {
                if(Discos[i].ID == Discos[j].ID)
                {
                    Discos.RemoveAt(j);
                }
            }
        }
    }
}
public void InicializarLista()
{
    Discos.Add(new Disco("Thriller", "Michael Jackson", "Quincy Jones", "Pop", new List<string> { "Billie Jean", "Thriller", "Beat It" }, 1, "thriller.jpg"));
    Discos.Add(new Disco("Abbey Road", "The Beatles", "George Martin", "Rock", new List<string> { "Hey Jude", "Come Together", "Let It Be" }, 2, "abbeyroad.jpg"));
    Discos.Add(new Disco("21", "Adele", "Adele Adkins", "Pop/Soul", new List<string> { "Rolling in the Deep", "Someone Like You", "Set Fire to the Rain" }, 3, "21.jpg"));
    Discos.Add(new Disco("Nevermind", "Nirvana", "Butch Vig", "Grunge", new List<string> { "Smells Like Teen Spirit", "Come as You Are", "Lithium" }, 4, "nevermind.jpg"));
    Discos.Add(new Disco("The Wall", "Pink Floyd", "Pink Floyd", "Progressive Rock", new List<string> { "Comfortably Numb", "Another Brick in the Wall", "Time" }, 5, "thewall.jfif"));
    Discos.Add(new Disco("Bday", "Beyoncé", "Beyoncé Knowles", "R&B/Pop", new List<string> { "Crazy In Love", "Single Ladies", "Irreplaceable" }, 6, "bday.png"));
    Discos.Add(new Disco("Afterhours", "The Weeknd", "Max Martin", "R&B/Pop", new List<string> { "Blinding Lights", "Save Your Tears", "In the Night" }, 7, "afterhours.jfif"));
    Discos.Add(new Disco("Legend", "Bob Marley", "Bob Marley", "Reggae", new List<string> { "No Woman, No Cry", "Redemption Song", "Buffalo Soldier" }, 8, "legend.jpeg"));
    Discos.Add(new Disco("Damn", "Kendrick Lamar", "Top Dawg Entertainment", "Hip-Hop", new List<string> { "HUMBLE.", "DNA.", "Alright" }, 9, "damn.jfif"));
    Discos.Add(new Disco("Random access memories", "Daft Punk", "Daft Punk", "Electronic", new List<string> { "Get Lucky", "One More Time", "Harder, Better, Faster, Stronger" }, 10, "randomaccessmemories.jfif"));
}
}