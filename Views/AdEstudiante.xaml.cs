namespace Semana6.Views
{
    public partial class AdEstudiante : ContentPage
    {
        public AdEstudiante()
        {
            InitializeComponent();
        }

        private async void OnAgregarClicked(object sender, EventArgs e)
        {
            var estudiante = new vEstudiante
            {
                Codigo = codigoEntry.Text,
                Nombre = nombreEntry.Text,
                Apellido = apellidoEntry.Text,
                Edad = int.Parse(edadEntry.Text)
            };


            await Navigation.PopAsync();
        }
    }
}