using Datos;
using Entity;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class EstampillaService
    {
        private readonly ConnectionManager _conexion;
        private readonly EstampillaRepository _repositorio;
        public EstampillaService(string connectionString)
        {
            _conexion = new ConnectionManager(connectionString);
            _repositorio = new EstampillaRepository(_conexion);
        }
        public GuardarEstampillaResponse Guardar(Estampilla estampilla)
        {
            try
            {
                estampilla.CalcularVrEstampilla();
                _conexion.Open();
                _repositorio.Guardar(estampilla);
                _conexion.Close();
                return new GuardarEstampillaResponse(estampilla);
            }
            catch (Exception e)
            {
                return new GuardarEstampillaResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { _conexion.Close(); }
        }
        public List<Estampilla> ConsultarTodos()
        {
            _conexion.Open();
            List<Estampilla> estampillas = _repositorio.ConsultarTodos();
            _conexion.Close();
            return estampillas;
        }
        public string Eliminar(int nContrato)
        {
            try
            {
                _conexion.Open();
                var estampilla = _repositorio.BuscarPornContrato(nContrato);
                if (estampilla != null)
                {
                    _repositorio.Eliminar(estampilla);
                    _conexion.Close();
                    return ($"El registro {estampilla.nContrato} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {nContrato} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { _conexion.Close(); }

        }

        public int Totalizar()
        {
            return _repositorio.Totalizar();
        }


        public class GuardarEstampillaResponse
        {
            public GuardarEstampillaResponse(Estampilla estampilla)
            {
                Error = false;
                Estampilla = estampilla;
            }
            public GuardarEstampillaResponse(string mensaje)
            {
                Error = true;
                Mensaje = mensaje;
            }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Estampilla Estampilla { get; set; }
        }
    }
}