using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Kutyák
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Dictionary<int,string> kutyaNev = new Dictionary<int,string>();
            Dictionary<int, string> kutyaFajta = new Dictionary<int, string>();
            List<string> kutya = new List<string>();

            List<Kutyak> lista = new List<Kutyak>();

            File.ReadAllLines("KutyaNevek.csv").Skip(1).ToList().ForEach(x => kutyaNev.Add(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1]));
            File.ReadAllLines("KutyaFajtak.csv").Skip(1).ToList().ForEach(x => kutyaFajta.Add(Convert.ToInt32(x.Split(';')[0]), x.Split(';')[1]));
            File.ReadAllLines("Kutyak.csv").Skip(1).ToList().ForEach(x => kutya.Add(x));

            kutya.ForEach(x => lista.Add(new Kutyak(Convert.ToInt32(x.Split(';')[0]), kutyaFajta[Convert.ToInt32(x.Split(';')[1])], kutyaNev[Convert.ToInt32(x.Split(';')[2])], Convert.ToInt32(x.Split(';')[3]), x.Split(';')[4])));
            LBmegjelenites.ItemsSource = lista;

            LBatlag.Content = lista.Average(x => x.KutyaEletkora);

            lbLegidosebb.Content = lista.Max(x => x.KutyaFajtaja);
        }
    }
}
