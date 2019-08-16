using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Lasg.Entities
{

    [Serializable]
    [DataContract]
    public abstract class EntityBase : INotifyPropertyChanged
    {
        public abstract int Id { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Dispara el evento ProperChanged cuando cambia el valor de la propiedad.
        /// </summary>
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Muestra los valores de las propiedades para fines de depuracion.
        /// </summary>
        public override string ToString()
        {
            return this.GetType().Name + ": " +
                string.Join(",", this.GetType().GetProperties()
                .Where(p => !p.PropertyType.IsGenericType && !p.PropertyType.IsArray)
                .Select(p => string.Format("{0}={1}", p.Name, p.GetValue(this, null))));
        }

        

        
    }
}
