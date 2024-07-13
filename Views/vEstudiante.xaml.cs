using Newtonsoft.Json;
using Semana6.Modelos;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;


namespace Semana6.Views
{
    public partial class vEstudiante : ContentPage
    {
        private const string Url = "http://192.168.100.66/Semana6/estudiantews.php";
        private readonly HttpClient cliente = new HttpClient();
        private ObservableCollection<Modelos.Estudiante> est;

        public string Codigo { get; internal set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public int Edad { get; internal set; }

        public vEstudiante()
        {
            InitializeComponent();
            Mostrar();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public async void Mostrar()
        {
            var content = await cliente.GetStringAsync(Url);
            List<Modelos.Estudiante> mostrar = JsonConvert.DeserializeObject<List<Modelos.Estudiante>>(content);
            est = new ObservableCollection<Modelos.Estudiante>(mostrar);
            Estudiante.ItemsSource = est;
        }

        private async void OnAgregarEstudianteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdEstudiante());
        }

        private void OnActualizarClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var estudiante = button?.CommandParameter as Modelos.Estudiante;

            if (estudiante != null)
            {

            }
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var estudiante = button?.CommandParameter as Modelos.Estudiante;

            if (estudiante != null)
            {
                bool isConfirmed = await DisplayAlert("Confirmación", "¿Deseas eliminar este estudiante?", "Sí", "No");
                if (isConfirmed)
                {
                    est.Remove(estudiante);
                    Estudiante.ItemsSource = est;
                }
            }
        }
    }
}