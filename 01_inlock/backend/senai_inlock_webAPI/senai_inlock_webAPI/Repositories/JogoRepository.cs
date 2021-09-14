using Microsoft.EntityFrameworkCore;
using senai_inlock_webAPI.Contexts;
using senai_inlock_webAPI.Domains;
using senai_inlock_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        InLockContext ctx = new InLockContext();
        public void Atualizar(int id, Jogo jogoAtualizado)
        {
            Jogo jogoBuscado = new Jogo();

            if (jogoAtualizado.NomeJogo != null || jogoAtualizado.Descricao != null || jogoAtualizado.DataLancamento != null || jogoAtualizado.Valor < 0)
            {
                jogoBuscado.NomeJogo = jogoAtualizado.NomeJogo;
                jogoBuscado.Descricao = jogoAtualizado.Descricao;
                jogoBuscado.DataLancamento = jogoAtualizado.DataLancamento;
                jogoBuscado.Valor = jogoAtualizado.Valor;

                ctx.Jogos.Update(jogoBuscado);

                ctx.SaveChanges();
            }
        }

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogos.FirstOrDefault(j => j.IdJogo == id;
        }

        public void Cadastrar(Jogo novoJogo)
        {
            ctx.Jogos.Add(novoJogo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Jogos.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Jogo> Listar()
        {
            return ctx.Jogos.ToList();
        }

        public List<Jogo> ListarComEstudio()
        {
            return ctx.Jogos.Include(j => j.IdEstudioNavigation).ToList();
        }
    }
}
