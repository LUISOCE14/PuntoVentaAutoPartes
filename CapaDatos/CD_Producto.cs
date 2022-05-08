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
    public class CD_Producto
    {
        public int obtenerCorrelativo()
        {
            int idUltEmp = 0;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    cconexion.Open();
                    string query = "select max(idProducto) from Producto";

                    SqlCommand cmd = new SqlCommand(query, cconexion);

                    if (cmd.ExecuteScalar() != null)
                    {
                        idUltEmp = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    else
                    {
                        idUltEmp = 0;
                    }
                }
                catch (Exception ex)
                {

                }
            }

            return idUltEmp;

        }
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "select*from Producto";



                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion)
                    {
                        CommandType = CommandType.Text
                    };

                    cconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                idProducto = Convert.ToInt32(dr["idProducto"]),
                                nombre = dr["NombreProducto"].ToString(),
                                modelo = dr["Modelo"].ToString(),
                                descripcion = dr["Descripcion"].ToString(),
                                valorCompra = Convert.ToInt32(dr["valorCompra"]),
                                valorVenta = Convert.ToDecimal(dr["ValorVenta"]),
                                existencias = Convert.ToInt32(dr["Existencias"])
                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }


        public int RegistrarProductos(Producto obj, out string mensaje)
        {
            int respuesta = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", cconexion);
                    cmd.Parameters.AddWithValue("idProducto ", obj.idProducto);
                    cmd.Parameters.AddWithValue("NombreProducto", obj.nombre);
                    cmd.Parameters.AddWithValue("Modelo", obj.modelo);
                    cmd.Parameters.AddWithValue("Descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("ValorVenta", obj.valorVenta);
                    cmd.Parameters.AddWithValue("ValorCompra", obj.valorCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
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

        public bool ModificarProducto(Producto obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_MODIFICARPRODUCTO", cconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.idProducto);
                    cmd.Parameters.AddWithValue("NombreProducto", obj.nombre);
                    cmd.Parameters.AddWithValue("Modelo", obj.modelo);
                    cmd.Parameters.AddWithValue("Descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("ValorCompra", obj.valorCompra);
                    cmd.Parameters.AddWithValue("ValorVenta", obj.valorVenta);
                    cmd.Parameters.AddWithValue("Existencias", obj.existencias);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
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


        public bool EliminarProducto(Producto obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", cconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.idProducto);
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
