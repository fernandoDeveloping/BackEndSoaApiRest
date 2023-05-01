using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;

namespace Datos
{
    public class datos_autosChevrolet
    {
        ChevroleteEntities _context;
        public datos_autosChevrolet()
        {
            _context = new ChevroleteEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        #region metodos de consulta
        public List<Autos_Chevrolet> SeleccionarAutosChevrolet()
        {
            return _context.Autos_Chevrolet.ToList();
        }

        #endregion
        #region metodos de accion
        public int InsertarAutoChevrolet(Autos_Chevrolet nuevoAutop)
        {
            _context.Autos_Chevrolet.Add(nuevoAutop);
            _context.SaveChanges();
            return nuevoAutop.Id;
        }

        public bool ActualizarAutoChevrolet(Autos_Chevrolet autoActualizado)
        {
            Autos_Chevrolet autoTemp = SeleccionarAutoPorID(autoActualizado.Id);
            if (autoTemp != null)
            {
                autoTemp.Anio_Chevrolet = autoActualizado.Anio_Chevrolet;
                autoTemp.Modelo_Chevrolet = autoActualizado.Modelo_Chevrolet;
                autoTemp.Tipo_Chevrolet = autoActualizado.Tipo_Chevrolet;
                autoTemp.Cilindraje_Chevrolet = autoActualizado.Cilindraje_Chevrolet;
                autoTemp.Concesionario_Chevrolet = autoActualizado.Concesionario_Chevrolet;
                autoTemp.Color__Chevrolet = autoActualizado.Color__Chevrolet;
                autoTemp.Concesionario_Chevrolet = autoActualizado.Concesionario_Chevrolet;
                autoTemp.FechaRegistro_Chevrolet = autoActualizado.FechaRegistro_Chevrolet;
                _context.SaveChanges();
                return true;

            }
            else
                return false;
        }
        public bool EliminarAutoChevrolet(Autos_Chevrolet autoEliminado)
        {
            Autos_Chevrolet autoTemp = SeleccionarAutoPorID(autoEliminado.Id);
            if (autoTemp != null)
            {
                _context.Autos_Chevrolet.Remove(autoTemp);
                _context.SaveChanges();
                return true;

            }
            else
                return false;
        }


        #endregion

        #region métodos auxiliares
        private Autos_Chevrolet SeleccionarAutoPorID(int Idp)
        {
            return _context.Autos_Chevrolet.Where(a => a.Id == Idp).SingleOrDefault();
        }
        #endregion

    }
}
