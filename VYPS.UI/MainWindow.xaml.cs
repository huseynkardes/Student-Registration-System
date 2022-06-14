using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VYPS.Domain2.Repository;
using VYPS.Model2.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace VYPS.UI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
           

            Ogrenci ogr = new Ogrenci();
            ogr.ad = ogrenci_ad.Text;
            ogr.tcno = int.Parse(ogrenci_tcno.Text);
            ogr.soyadi = ogrenci_soyad.Text;

            if (ogrenci_cins.Text.ToLower()=="erkek")
                ogr.cinsiyet = true;
            
            else if(ogrenci_cins.Text.ToLower() == "kız")
                ogr.cinsiyet = false;

            ogr.dtar = DateTime.Parse(ogrenci_dt.Text);
            
            ogr.bolumid = int.Parse(ogrenci_bolumıd.Text);
            ogr.adres = ogrenci_adres.Text;
            VYPSRepository<Ogrenci> repository = new VYPSRepository<Ogrenci>();
            repository.Add(ogr);

        }
        private void upd_Click(object sender, RoutedEventArgs e)
        {
            
            Ogrenci ogr = new Ogrenci();
            ogr.ad = ogrenci_ad.Text;
            ogr.tcno = int.Parse(ogrenci_tcno.Text);
            ogr.soyadi = ogrenci_soyad.Text;

            if (ogrenci_cins.Text.ToLower() == "erkek")
                ogr.cinsiyet = true;

            else if (ogrenci_cins.Text.ToLower() == "kız")
                ogr.cinsiyet = false;

            ogr.dtar = DateTime.Parse(ogrenci_dt.Text);

            ogr.bolumid = int.Parse(ogrenci_bolumıd.Text);
            ogr.adres = ogrenci_adres.Text;
            ogr.no = int.Parse(ogrenci_no.Text);
            VYPSRepository<Ogrenci> repository = new VYPSRepository<Ogrenci>();
            repository.update(int.Parse(ogrenci_no.Text),ogr);

        }
        private void del_Click(object sender, RoutedEventArgs e)
        {
            
            Ogrenci ogr = new Ogrenci();

            ogr.no = int.Parse(ogrenci_no.Text);

            VYPSRepository<Ogrenci> repository = new VYPSRepository<Ogrenci>();
            repository.Delete(ogr);

        }
        public void btnGirisYap_Click(object sender, RoutedEventArgs e)
        {
            if (txtKullaniciAdi.Text=="admin" && passwordBox.Password=="admin")
            {
                grid_islem.Visibility = Visibility.Visible;
                grid_login.Visibility = Visibility.Collapsed;
                hosgeldin.Visibility = Visibility.Visible;
                passwordBox.Password = "";

            }
        }
        public void get_single_Click(object sender, RoutedEventArgs e)
        {
            VYPSRepository<Ogrenci> repository = new VYPSRepository<Ogrenci>();
            Ogrenci ogr= repository.SelectSingle(x => x.no == int.Parse(ogrenci_no.Text));
            try
            {
                ogrenci_ad.Text = ogr.ad;
                ogrenci_soyad.Text = ogr.soyadi;
                ogrenci_dt.Text = ogr.dtar.ToString();
                ogrenci_adres.Text = ogr.adres;
                ogrenci_tcno.Text = ogr.tcno.ToString();
                ogrenci_bolumıd.Text = ogr.bolumid.ToString();
                if (ogr.cinsiyet.ToString().ToLower() == "true")
                    ogrenci_cins.Text = "ERKEK";

                else if (ogr.cinsiyet.ToString().ToLower() == "false")
                    ogrenci_cins.Text = "kız";
            }
            catch (Exception)
            {

               
            }

        }
        public void exit_Click(object sender, RoutedEventArgs e)
        {
            
                grid_islem.Visibility = Visibility.Collapsed;
                grid_login.Visibility = Visibility.Visible;
                hosgeldin.Visibility = Visibility.Collapsed;
            
        }
    }
}
