using Senai.MedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedGroup.WebApi.Interface
{
    interface IUsuarioRepository
    { 
        List<TUsuario> Listar();

        TUsuario BuscarPorId(int id);

        void Cadastrar(TUsuario novoUsuario);

        void Deletar(int id);

        void Atualizar(int id, TUsuario usuarioNovo);
    }
}
