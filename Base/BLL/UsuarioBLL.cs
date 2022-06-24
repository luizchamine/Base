using Model;
using System.Collections.Generic;
using DAL;
using System.Data;
using System;

namespace BLL
{
    public class UsuarioBLL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length == 0)
                throw new Exception("Informe o nome de usuário.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Inserir(_usuario);
        }
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
        }
        public Usuario Alterar(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
    }
}
