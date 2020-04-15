using System;
using Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class EstampillaRepository

    {

private readonly SqlConnection _connection;
        private readonly List<Estampilla> _estampillas = new List<Estampilla>();
public EstampillaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
public void Guardar(Estampilla estampillas)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Estampilla (nContrato,oContrato,vrContrato, apoyoEmergenciaCovid19, vrEstampilla) 
                                        values (@nContrato,@oContrato,@vrContrato,@apoyoEmergenciaCovid19,@vrEstampilla)";
                command.Parameters.AddWithValue("@nContrato", estampillas.nContrato);
                command.Parameters.AddWithValue("@oContrato", estampillas.oContrato);
                command.Parameters.AddWithValue("@vrContrato", estampillas.vrContrato);
                command.Parameters.AddWithValue("@poyoEmergenciaCovid19", estampillas.apoyoEmergenciaCovid19);
                command.Parameters.AddWithValue("@vrEstampilla", estampillas.vrEstampilla);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Estampilla estampillas)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from persona where Identificacion=@nContrato";
                command.Parameters.AddWithValue("@Identificacion", estampillas.nContrato);
                command.ExecuteNonQuery();
            }
        }
        public List<Estampilla> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Estampilla> estampillas = new List<Estampilla>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from estampilla ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estampilla estampilla = DataReaderMapToPerson(dataReader);
                        estampillas.Add(estampilla);
                    }
                }
            }
            return estampillas;
        }
        public Estampilla BuscarPornContrato(int nContrato)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from estampilla where nContrato=@nContrato";
                command.Parameters.AddWithValue("@nContrato", nContrato);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }
        private Estampilla DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if(!dataReader.HasRows) return null;
            Estampilla estampilla = new Estampilla();
            estampilla.nContrato = (string)dataReader["NumContrato"];
            estampilla.oContrato = (string)dataReader["Obj Contrato"];
            estampilla.vrContrato = (string)dataReader["Valor Contrato"];
            estampilla.apoyoEmergenciaCovid19 = (int)dataReader["apoyo"];
            return estampilla;
        }
        public int Totalizar()
        {
            return _estampillas.Count();
        }
        
    }

    
}






                
        