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
    public class CD_Empleado
    {
        public int ultimoId()
        {
            int idUltEmp = 0;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    cconexion.Open();
                    string query = "select max(idEmpleado) from Empleados";

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

        public List<Empleado> Listar()
        {
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idEmpleado,Nombre,Telefono,Correo from Empleados");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion)
                    {
                        CommandType = CommandType.Text
                    };

                    cconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(dr["idEmpleado"]),
                                nombreCompleto = dr["Nombre"].ToString(),
                                
                                telefono = dr["Telefono"].ToString(),
                                correo = dr["Correo"].ToString()

                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Empleado>();
                }
            }
            return lista;
        }


        public int RegistrarEmpleado(Empleado obj, out string mensaje)
        {
            int idEmpGene = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_REGISTRAREMPLEADO", cconexion);
                    cmd.Parameters.AddWithValue("idEmpleado", obj.IdEmpleado);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.correo);
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    idEmpGene = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();




                }

            }
            catch (Exception ex)
            {
                idEmpGene = 0;
                mensaje = ex.Message;
            }

            return idEmpGene;

        }


        public bool EditarEmpleado(Empleado obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_EDITAREMPLEADO", cconexion);
                    cmd.Parameters.AddWithValue("IdEmpleado", obj.IdEmpleado);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.nombreCompleto);
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

        public bool EliminarEmpleado(Empleado obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ELIMINAREMPLEADO", cconexion);
                    cmd.Parameters.AddWithValue("idEmpleado", obj.IdEmpleado);
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
