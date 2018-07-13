using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace MysqlCoreConsole
{
    public class Repository
    {
        public static void InsertData()
        {
            using (var context = new BudgetDataContext())
            {

                var album = new Album()
                {
                    Nome = "Acústico MTV - Legião Urbana",
                    Ano = 1999,
                    Email = "contato@legiaourbana.com.br"
                };

                context.Albuns.Add(album);

                context.Musicas.Add(new Musica
                {
                    Nome = "Índios",
                    Album = album
                });
                context.Musicas.Add(new Musica
                {
                    Nome = "Pais e Filhos",
                    Album = album
                });

                context.Musicas.Add(new Musica
                {
                    Nome = "Eu sei",
                    Album = album
                });

                context.SaveChanges();
            }
        }

        public static void PrintData()
        {
            using (var context = new BudgetDataContext())
            {

                var musicas = context.Musicas.Include(m => m.Album);
                foreach (var musica in musicas)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Musica: {musica.Nome}");
                    data.AppendLine($"Album: {musica.Album.Nome}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}
