using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AceesoDatos;
using Logica;

namespace SOA
{
    /// <summary>
    /// Descripción breve de ServiciosWebAutosChevrolet
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiciosWebAutosChevrolet : System.Web.Services.WebService
    {
        logica_autosChevrolet operaciones = new logica_autosChevrolet();



        #region metodos de consulta
        [WebMethod]
        public List<Autos_Chevrolet> SeleccionarAutosChevrolet()
        {
            return operaciones.SeleccionarAutosChevrolet();
        }

        [WebMethod]
        public Autos_Chevrolet SeleccionarAutoPorID(int idp)
        {
            return SeleccionarAutosChevrolet().Where(a => a.Id == idp).SingleOrDefault();
        }

        #endregion

        #region metodos de accion
        [WebMethod]
        public int InsertarAutoChevrolet(Autos_Chevrolet nuevoAutop)
        {
            return operaciones.InsertarAutoChevrolet(nuevoAutop);
        }

        [WebMethod]
        public bool ActualizarAutoChevrolet(Autos_Chevrolet autoActualizado)
        {
            return operaciones.ActualizarAutoChevrolet(autoActualizado);
        }


        [WebMethod]
        public bool EliminarAutoChevrolet(Autos_Chevrolet autoEliminado)
        {
            return operaciones.EliminarAutoChevrolet(autoEliminado);
        }

        #endregion
       
    }
}
