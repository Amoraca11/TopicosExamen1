using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LogicaDeNegocio;

namespace BingoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Usuario getUser(int id)
        {
            Usuario user =ListaUsuarios.getUser(id);
            return user;
        }
    }
}
