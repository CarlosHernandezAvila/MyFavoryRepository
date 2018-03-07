using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarlosHernandez_WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Icmmoneycash
    {

        [OperationContract]

        Correspon ObtenerCorrespon(string Cor_Nombre);
        Oficinas ObtenerOficinas(string Ofi_nombre);

        // TODO: agregue aquí sus operaciones de servicio
    }


    [DataContract]
    public class Correspon

    {
        [DataMember]
        public string Cor_nombre { get; set; }
        [DataMember]
        public int Cor_ID { get; set; }

    }


    [DataContract]

    public class Oficinas
    {
        [DataMember]
        public string Ofi_nombre { get; set; }
        [DataMember]
        public string Ofi_ID { get; set; }

    }



    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
