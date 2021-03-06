﻿using System;
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
    public interface I_cmmoneycash
    {

        [OperationContract]

        Correspon ObtenerCorrespon(string Cor_Nombre, int Cor_ID);
        Oficinas ObtenerOficinas(string Ofi_nombre, int Ofi_ID);

        // TODO: agregue aquí sus operaciones de servicio
    }


    [DataContract]
    public class Correspon:CorresponRespuesta

    {
        [DataMember]
        public string Cor_nombre { get; set; }
        [DataMember]
        public int Cor_ID { get; set; }

    }

    [DataContract]
    public class CorresponRespuesta
    {
        public string RespuestaCorrespon { get; set; }
        public string ErrorCorrespon { get; set; }
    }


    [DataContract]

    public class Oficinas : OficinaRespuesta
    {
        [DataMember]
        public string Ofi_nombre { get; set; }
        [DataMember]
        public int Ofi_ID { get; set; }

    }

    [DataContract]

    public class OficinaRespuesta
    {
        public string RespuestaOficina { get; set; }
        public string ErrorOficina { get; set; }
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
