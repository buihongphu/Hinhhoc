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

namespace HÌNH_HỌC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dem = 0;
     
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        {
            HinhCN hcn = new HinhCN(4, 3);
            hcn.chuvi();
            hcn.dientich();
            MessageBox.Show("chu vi: " + hcn.ChuVi.ToString()
                            + "\ndien tich: " + hcn.DienTich.ToString());
        }
        }
             private void btnhv_Click(object sender, RoutedEventArgs e)
             {
        {
            Hìnhvuông hv = new Hìnhvuông(3);
            hv.chuvi();
            hv.dientich();
            MessageBox.Show("Chu vi Hinh Vuong: " + hv.ChuVi.ToString()
                            + "\nDien Tich Hinh Vuong: " + hv.DienTich.ToString());
            Hìnhvuông[] hv = new Hìnhvuông[5];
            hv[0] = new Hìnhvuông(3);
            hv[1] = new Hìnhvuông(4);
            hv[2] = new Hìnhvuông(5);
            hv[3] = new Hìnhvuông(6);
            hv[4] = new Hìnhvuông(7);
            for (int i = 0; i < 5; i++)
            {
                hv[i].chuvi();
                hv[i].dientich();
                dem += 1;
                lbxsothutu.Items.Add(dem.ToString());
                lbxcanh.Items.Add(hv[i].Canh);
                lbxchuvi.Items.Add(hv[i].chuvi.ToString());
                lbxdientich.Items.Add(hv[i].dientich.ToString());
            }
        }
    }
}

        }
 
            private Hinhtron btnht_Click(object sender, RoutedEventArgs e)
            {
        {
            Hinhtron ht = new  Hinhtron(3);
            ht.chuvi();
            ht.dientich();
            MessageBox.Show("chu vi: " + ht.ChuVi.ToString()
                            + "\ndien tich: " + ht.DienTich.ToString());



          
        }
            }
        }
        
    }