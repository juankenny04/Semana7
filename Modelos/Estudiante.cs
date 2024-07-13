using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6.Modelos
{
    public class Estudiante
    {
        internal static ObservableCollection<Estudiante> ItemsSource;

        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad {  get; set; }
    }
}
