using SinglePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace SinglePage.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    public class MyService
    {
        private UsuariosData oUsuariosData = new UsuariosData();

        [OperationContract]

        public IEnumerable<Usuario> GetUsuario()
        {
            return oUsuariosData.GetUsuario();
        }
    }
}
