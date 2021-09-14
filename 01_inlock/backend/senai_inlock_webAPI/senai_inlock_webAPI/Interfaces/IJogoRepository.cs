using senai_inlock_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();
        Jogo BuscarPorId(int id);
        void Cadastrar(Jogo novoJogo);
        void Atualizar(int id, Jogo jogoAtualizado);
        void Deletar(int id);
        List<Jogo> ListarComEstudio();

    }
}
