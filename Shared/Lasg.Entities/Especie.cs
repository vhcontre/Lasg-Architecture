using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;


namespace Lasg.Entities
{
    
    [Serializable]
    [DataContract]
    public partial class Especie : EntityBase
    {
        private string _nombre;

        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }

        [DataMember]
        [DisplayName("Nombre")]
        [Required]
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }
    }
}
