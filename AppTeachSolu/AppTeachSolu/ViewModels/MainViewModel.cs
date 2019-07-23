

namespace AppTeachSolu.ViewModels
{
    public class MainViewModel
    {
        public ProyectsViewModel Proyects { get; set; }

        public MainViewModel() {

            this.Proyects = new ProyectsViewModel();

        }

    }
}
