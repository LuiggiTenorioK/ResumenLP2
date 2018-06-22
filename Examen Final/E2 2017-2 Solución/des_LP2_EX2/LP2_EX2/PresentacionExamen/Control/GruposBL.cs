using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class GruposBL
    {
        public BindingList<String> getGrupos()
        {
            //Fills ComboBox
            ProyWebServ.exWServiceClient cli = new ProyWebServ.exWServiceClient();
            return new BindingList<String>(cli.getGrupos());
        }
    }
}
