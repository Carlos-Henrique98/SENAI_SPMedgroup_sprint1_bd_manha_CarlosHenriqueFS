using Senai.MedGroup.WebApi.Domains;
using Senai.MedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedGroup.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        MedGroupContext ctx = new MedGroupContext();

        public void Atualizar(int id, TTipoUsuario usuarioTipoNovo)
        {
            TTipoUsuario tipoUsuarioBuscado = ctx.TTipoUsuario.Find(id);

            tipoUsuarioBuscado.IdTipoUsuario = usuarioTipoNovo.IdTipoUsuario;

            ctx.TTipoUsuario.Update(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public TTipoUsuario BuscarPorId(int id)
        {
            return ctx.TTipoUsuario.FirstOrDefault(tu => tu.IdTipoUsuario == id);

        }

        public void Cadastrar(TTipoUsuario novoTipoUsuario)
        {
            ctx.TTipoUsuario.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.TTipoUsuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<TTipoUsuario> Listar()
        {
            return ctx.TTipoUsuario.ToList();
        }
    }
}
