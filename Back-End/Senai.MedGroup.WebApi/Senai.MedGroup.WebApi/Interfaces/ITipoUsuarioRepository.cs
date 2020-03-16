using Senai.MedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedGroup.WebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TTipoUsuario> Listar();

        TTipoUsuario BuscarPorId(int id);

        void Cadastrar(TTipoUsuario novoTipoUsuario);

        void Deletar(int id);

        void Atualizar(int id, TTipoUsuario usuarioTipoNovo);
    }
}
