using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio3_LP2;
using AccesoDatos;

namespace LogicaNegocio {
    public class MedicamentoBL {
        private MedicamentoDA accesoDatos;

        public MedicamentoBL() {
            accesoDatos = new MedicamentoDA();
        }

        public BindingList<Medicamento> listarMedicamentos() {
            return accesoDatos.listarMedicamentos();
        }
    }
}
