using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;
using Datos;

namespace Logica
{
    public class logica_autosChevrolet
    {
        datos_autosChevrolet operaciones = new datos_autosChevrolet();
        #region metodos de consulta
        public List<Autos_Chevrolet> SeleccionarAutosChevrolet()
        {
            return operaciones.SeleccionarAutosChevrolet();
        }

        public Autos_Chevrolet SeleccionarAutoPorID(int idp)
        {
            return SeleccionarAutosChevrolet().Where(a => a.Id == idp).SingleOrDefault();
        }

        #endregion
        #region metodos de accion
        public int InsertarAutoChevrolet(Autos_Chevrolet nuevoAutop)
        {
            return operaciones.InsertarAutoChevrolet(nuevoAutop);
        }

        public bool ActualizarAutoChevrolet(Autos_Chevrolet autoActualizado)
        {
            return operaciones.ActualizarAutoChevrolet(autoActualizado);
        }
        public bool EliminarAutoChevrolet(Autos_Chevrolet autoEliminado)
        {
            return operaciones.EliminarAutoChevrolet(autoEliminado);
        }


        #endregion
    }
}
