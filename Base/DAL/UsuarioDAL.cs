using Model;
using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"User ID=SA;
                Initial Catalog=Loja;
                Data Source=.\SQLEXPRESS2019;
                Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirUsuario";

                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(pativo);

                SqlParameter pnomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                pnomeUsuario.Value = _usuario.NomeUsuario;
                cmd.Parameters.Add(pnomeUsuario);


                SqlParameter psenha = new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);

                cn.Open();
                _usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"User ID=SA;
                Initial Catalog=Loja;
                Data Source=.\SQLEXPRESS2019;
                Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarUsuario";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                throw new Exception("" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarUsuario";
                
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pnomeUsuario = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                pnomeUsuario.Value = _usuario.NomeUsuario;
                cmd.Parameters.Add(pnomeUsuario);
                
                SqlParameter psenha= new SqlParameter("@Senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);
                
                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit);
                pativo.Value = _usuario.Ativo;
                cmd.Parameters.Add(pativo);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _usuario;
            }

            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL erro:" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"User ID=SA;
                Initial Catalog=Loja;
                Data Source=.\SQLEXPRESS2019;
                Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirUsuario";
                SqlParameter pid = new SqlParameter("@Id",SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o usuário: " +
                        _id.ToString());
                }
            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}