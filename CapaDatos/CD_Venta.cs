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
    public class CD_Venta
    {
        public int obtenerCorrelativo()
        {
            int folio = 0;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "select max(idVenta) from Ventas";

                    SqlCommand cmd = new SqlCommand(query, cconexion);
                    cmd.CommandType = CommandType.Text;

                    cconexion.Open();
                    folio = (int)cmd.ExecuteScalar() ;

                }
                catch (Exception ex)
                {
                    folio = 0;
                }
            }
            return folio;
        }
        public int RegistrarVenta(Venta obj, DataTable DetalleVentas, out string mensaje)
        {
            int respuesta = 0;
            mensaje = string.Empty;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "SP_REGISTRARVENTA";
                    SqlCommand cmd = new SqlCommand(query, cconexion);
                    cmd.Parameters.AddWithValue("IdVendedor", obj.idVendedor.IdEmpleado);
                    cmd.Parameters.AddWithValue("IdCliente", obj.idCliente.idCliente);
                    cmd.Parameters.AddWithValue("Detalle_Venta", DetalleVentas);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();



                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }


        public Venta obtenerVenta(int idventa)
        {
            Venta obj = new Venta();
            string mensaje = string.Empty;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    cconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.idVenta,");
                    query.AppendLine("ve.idEmpleado,ve.Nombre,");
                    query.AppendLine("c.idCliente,c.Nombre,c.Telefono,c.Correo,");
                    query.AppendLine("convert(char(10),v.FechaRegistro,103)[FechaRegistro]");
                    query.AppendLine("from Ventas v");
                    query.AppendLine("inner join Empleados ve on ve.idEmpleado = v.IdVendedor");
                    query.AppendLine("inner join Clientes c on c.idCliente = v.idCliente");
                    query.AppendLine("where v.idVenta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion);
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    cmd.CommandType = CommandType.Text;



                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            obj = new Venta()
                            {
                                idVenta = Convert.ToInt32(dr["idVenta"]),
                                idVendedor = new Empleado() { IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]), nombreCompleto = dr.GetString(2) },
                                idCliente = new Cliente()
                                {
                                    idCliente = dr.GetInt32(3),
                                    nombre = dr.GetString(4),
                                    telefono = dr["Telefono"].ToString(),
                                    correo = dr["Correo"].ToString(),
                                },

                                fechaRegistro = dr["FechaRegistro"].ToString(),
                            };
                        }

                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    obj = new Venta();
                }
            }

            return obj;
        }



        public List<DetallesVenta> DetallesVenta(int idventa)
        {
            List<DetallesVenta> olista = new List<DetallesVenta>();
            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {
                    cconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.idProducto,p.NombreProducto,p.Modelo,dv.Cantidad,dv.PrecioVenta");
                    query.AppendLine("from Detalle_Venta dv");
                    query.AppendLine("inner join Producto p on p.idProducto = dv.IdProducto");
                    query.AppendLine("where dv.IdVenta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion);
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            olista.Add(new DetallesVenta()
                            {
                                idProducto = new Producto()
                                {
                                    idProducto = Convert.ToInt32(dr["idProducto"].ToString()),
                                    nombre = dr["NombreProducto"].ToString(),
                                    modelo = dr["Modelo"].ToString(),
                                },
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"])
                            });
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                olista = new List<DetallesVenta>();
            }
            return olista;

        }
    }
}
