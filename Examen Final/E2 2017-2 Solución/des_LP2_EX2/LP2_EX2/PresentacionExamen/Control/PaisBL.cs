using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class PaisBL
    {
        private static ProyWebServ.exWServiceClient cli = new ProyWebServ.exWServiceClient();
        public BindingList<ProyWebServ.pais> getGrupos(String grupo)
        {

            BindingList<ProyWebServ.pais> temp = new BindingList<ProyWebServ.pais>(cli.getPaises(grupo));
            return temp;
        }
    }
}
