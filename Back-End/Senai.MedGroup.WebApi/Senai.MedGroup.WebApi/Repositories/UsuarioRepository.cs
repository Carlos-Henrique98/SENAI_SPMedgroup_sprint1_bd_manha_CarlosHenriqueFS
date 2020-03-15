using Senai.MedGroup.WebApi.Domains;
using Senai.MedGroup.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedGroup.WebApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        MedGroupContext ctx = new MedGroupContext();

        public TUsuario BuscarPorId(int id)
        {
            return ctx.TUsuario.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(TUsuario novoUsuario)
        {
            ctx.TUsuario.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Atualizar(int id, TUsuario usuarioAtualizado)
        {
            TUsuario usuarioMedicoBuscado = ctx.TUsuario.Find(id);

            usuarioMedicoBuscado.IdUsuario = usuarioAtualizado.IdUsuario;

            ctx.TUsuario.Update(usuarioMedicoBuscado);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.TUsuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<TUsuario> Listar()
        {
            return ctx.TUsuario.ToList();
        }
    }
}
