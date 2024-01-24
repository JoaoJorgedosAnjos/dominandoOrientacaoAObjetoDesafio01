using dominandoOrientacaoAObjetoDesafio01.Alura.Filmes;


Filme filme1 = new Filme("Senhor dos Anéis 1", 350, new List<Artista>());



Console.WriteLine();

List<Filme> meusFilmesFavoritos = new List<Filme>();
//meusFilmesFavoritos.Add(filme1);
//meusFilmesFavoritos.Add(filme2);
//meusFilmesFavoritos.Add(filme3);


foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}