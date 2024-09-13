using System.Collections.ObjectModel;
using System.ComponentModel;
using ProyectLayout.Models;

namespace ProyectLayout.ViewModels
{
    public class BindableViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Producto> Productos { get; set; }

        public BindableViewModel()
        {
            Productos = new ObservableCollection<Producto>
            {
                new Producto { Nombre = "Manzana", Imagen = "manzana.jpeg", Precio = 1.99m },
                new Producto { Nombre = "Pera", Imagen = "pera.jpeg", Precio = 2.99m },
                new Producto { Nombre = "Naranja", Imagen = "naranja.jpeg", Precio = 3.99m }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
