using System;
using System.Collections.Generic;
using curso.dominio;

namespace curso {
    class Program {
        static void Main(string[] args) {

            List<Artista> artistas = new List<Artista>();
            List<Filme> filmes = new List<Filme>();

            int opcao = 0;

            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

            while (opcao != 5) {
                Console.Clear();
                Tela.mostrarMenu();
                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1) {
                    Tela.mostrarArtistas(artistas);
                }
                else if (opcao == 2) {
                    try {
                        Artista A = Tela.lerArtista();
                        artistas.Add(A);
                        artistas.Sort();
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 3) {
                    try {
                        Filme F = Tela.lerFilme(artistas);
                        filmes.Add(F);
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4) {
                    try {
                        Tela.mostrarFilme(filmes);
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5) {
                    Console.WriteLine("Fim do programa!");
                }
                else {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
