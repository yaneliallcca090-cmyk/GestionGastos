using GestionGastos.DAO;
using GestionGastos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionGastos.Controllers
{
    public class GastoController
    {
        private readonly GastoDAO gasDAO;

        public GastoController()
        {
            gasDAO = new GastoDAO();
            gasDAO.CrearTabla();
        }



        public void Registrar(Gastos gasto)
        {
            gasDAO.InsertarGasto(gasto);
        }

        public void Actualizar(Gastos gasto)
        {
            gasDAO.Actualizar(gasto);
        }

        public List<Gastos> ListarGasto()
        {
            return gasDAO.Lista();
        }

        public void Eliminar(int id)
        {
            gasDAO.Eliminar(id);
        }
    }
}
