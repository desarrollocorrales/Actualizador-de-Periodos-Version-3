using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace ActualizadorDePeriodos3.DAL
{
    public class FBDAL
    {
        FbCommand Comando;
        FbConnection Conexion;        
        FbDataAdapter Adapter;

        public FBDAL()
        {
            InicializarObjetos();
        }

        private string obtenerStringDeConexion()
        {
            FbConnectionStringBuilder fbcsb = new FbConnectionStringBuilder();
            fbcsb.DataSource = Properties.Settings.Default.Servidor;
            fbcsb.Database = Properties.Settings.Default.BaseDeDatos;
            fbcsb.UserID = Properties.Settings.Default.Usuario;
            fbcsb.Password = Properties.Settings.Default.Password;
            fbcsb.Port = Properties.Settings.Default.Puerto;

            string StringDeConexion = fbcsb.ConnectionString;

            return StringDeConexion;
        }
        private void InicializarObjetos()
        {
            Conexion = new FbConnection(obtenerStringDeConexion());
            Comando = new FbCommand();
            Comando.Connection = Conexion;

            Adapter = new FbDataAdapter();
        }

        public DateTime obtenerFechaDelServidor()
        {
            Conexion.Open();
            Comando.CommandText = "Select Cast('NOW' As timestamp) From rdb$database";
            object oTiempo = Comando.ExecuteScalar();
            DateTime FechaHora = Convert.ToDateTime(oTiempo);

            Conexion.Close();

            return FechaHora;
        }

        public void ActualizarPeridoInicio(DateTime Fecha, String Modulo)
        {
            string Consulta = string.Format(
                       @"UPDATE
                             REGISTRY
                         SET
                             VALOR = '{0}'
                         WHERE
                             ELEMENTO_ID IN (
                                SELECT R1.ELEMENTO_ID
                                  FROM REGISTRY R2
                                       INNER JOIN REGISTRY R1 ON (R2.ELEMENTO_ID = R1.PADRE_ID)
                                       INNER JOIN REGISTRY R3 ON (R3.ELEMENTO_ID = R2.PADRE_ID)
                                       INNER JOIN REGISTRY R4 ON (R4.ELEMENTO_ID = R3.PADRE_ID)
                                 WHERE
                                       R3.NOMBRE = '{1}') 
                             AND NOMBRE = 'FechaInicial'",
                                           Fecha.ToString("dd/MM/yyyy"), 
                                           Modulo);

            Conexion.Open();
            Comando.CommandText = Consulta;
            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public void ActualizarPeridoFin(DateTime Fecha, String Modulo)
        {
            string Consulta = string.Format(
                       @"UPDATE
                             REGISTRY
                         SET
                             VALOR = '{0}'
                         WHERE
                             ELEMENTO_ID IN (
                                SELECT R1.ELEMENTO_ID
                                  FROM REGISTRY R2
                                       INNER JOIN REGISTRY R1 ON (R2.ELEMENTO_ID = R1.PADRE_ID)
                                       INNER JOIN REGISTRY R3 ON (R3.ELEMENTO_ID = R2.PADRE_ID)
                                       INNER JOIN REGISTRY R4 ON (R4.ELEMENTO_ID = R3.PADRE_ID)
                                 WHERE
                                       R3.NOMBRE = '{1}') 
                             AND NOMBRE = 'FechaFinal'",
                                           Fecha.ToString("dd/MM/yyyy"),
                                           Modulo);

            Conexion.Open();
            Comando.CommandText = Consulta;
            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public void ActualizarPeridos(DateTime Fecha, String Modulo)
        {
            string Consulta = string.Format(
                       @"UPDATE
                             REGISTRY
                         SET
                             VALOR = '{0}'
                         WHERE
                             ELEMENTO_ID IN (
                                SELECT R1.ELEMENTO_ID
                                  FROM REGISTRY R2
                                       INNER JOIN REGISTRY R1 ON (R2.ELEMENTO_ID = R1.PADRE_ID)
                                       INNER JOIN REGISTRY R3 ON (R3.ELEMENTO_ID = R2.PADRE_ID)
                                       INNER JOIN REGISTRY R4 ON (R4.ELEMENTO_ID = R3.PADRE_ID)
                                 WHERE
                                       R3.NOMBRE = '{1}')",
                                           Fecha.ToString("dd/MM/yyyy"),
                                           Modulo);

            Conexion.Open();
            Comando.CommandText = Consulta;
            Comando.ExecuteNonQuery();

            Conexion.Close();
        }
    }
}
