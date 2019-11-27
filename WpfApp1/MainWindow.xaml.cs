using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Datos> datos = new ObservableCollection<Datos>();

        public MainWindow()
        {
            InitializeComponent();

            Series serie1 = new Series("American Horror Story", "Terror", "Diferentes temas dependiendo la serie, circo, casa del terror, asilo, coven, etc", "Ryan Murphy, Brad Falchuk", 2011, 9, 5);
            Series serie2 = new Series("Greys Anatomy", "Drama", "La vida de cirujanos  que laboran en el Hospital de Seattle", "Shonda Rhimes", 2005, 16, 5);
            Series serie3 = new Series("The Big Bang Theory", "Comedia", "La vida de Leonard y Sheldon son dos cerebros privilegiados que no tienen ni la menor idea de cómo relacionarse socialmente", " Chuck Lorre, Bill Prady", 2007, 12, 4);

            Peliculas pelicula1 = new Peliculas("La Sirenita","Fantasia", "La historia de una sirena que quiere conocer el mundo fuera del mar", " Ron Clements, John Musker", 1989, 5);
            Peliculas pelicula2 = new Peliculas("Guillermo Del Toro", "Drama fantastico sobre la Guerra Civil Española", "Drama", "El Laberinto del Fauno", 2006, 5);
            Peliculas pelicula3 = new Peliculas("Alejandro G. Iñarritu", "Comedia Negra de superheroes", "Drama", "Birdman", 2014, 4);

            datos.Add(serie1);
            datos.Add(serie2);
            datos.Add(serie3);
            datos.Add(pelicula1);
            datos.Add(pelicula2);
            datos.Add(pelicula3);


            listview.ItemsSource = datos;





        


    }
    }
}