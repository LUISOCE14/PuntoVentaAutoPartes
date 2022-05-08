using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
   public  class CD_Cliente
    {
        public int obtenerCorrelativo()
        {
            int idUltClie = 0;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    cconexion.Open();
                    string query = "select max(idCliente) from Clientes";

                    SqlCommand cmd = new SqlCommand(query, cconexion);

                    if (cmd.ExecuteScalar() != null)
                    {
                        idUltClie = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    else
                    {
                        idUltClie = 0;
                    }
                }
                catch (Exception ex)
                {
                    idUltClie = 0;
                }
            }

            return idUltClie;

        }



        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "select * from Clientes";

                    SqlCommand cmd = new SqlCommand(query, cconexion);
                    cmd.CommandType = CommandType.Text;

                    cconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                idCliente = Convert.ToInt32(dr["idCliente"]),
                                nombre = dr["Nombre"].ToString(),
                                telefono = dr["Telefono"].ToString(),
                                correo = dr["Correo"].ToString()
                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }
            return lista;

        }


        public int RegistrarClientes(Cliente obj, out string mensaje)
        {
            int respuesta = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCLIENTE", cconexion);
                    cmd.Parameters.AddWithValue("idCliente ", obj.idCliente);
                    cmd.Parameters.AddWithValue("Nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("Telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.correo);
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;

        }


        public bool ModificarCliente(Cliente obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_MODIFICARCLIENTE", cconexion);
                    cmd.Parameters.AddWithValue("IdCliente", obj.idCliente);
                    cmd.Parameters.AddWithValue("Nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("Telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.correo);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;


                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;

        }


        public bool EliminarCliente(Cliente obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCLIENTE", cconexion);
                    cmd.Parameters.AddWithValue("IdCliente", obj.idCliente);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;

        }
    }
}
