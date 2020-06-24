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
using System.Windows.Shapes;
using System.Data.SQLite;
using System.IO;
using Microsoft.Win32;

namespace WorthVisit
{
    /// <summary>
    /// Logika interakcji dla klasy miejsca.xaml
    /// </summary>
    public partial class miejsca : Window
    {
        string KONT { get; set; }
        public miejsca(string kontynent)
        {
            
            InitializeComponent();
            
            this.KONT = kontynent;
            txtkontynent.Text=KONT;
            fill_combo();
           
        }

    
        SQLiteConnection sqlite_conn;

        
        void fill_combo()
        {
            sqlite_conn = new SQLiteConnection("Data Source= ciekawemiejsca.db;");
            try
            {
                sqlite_conn.Open();

                string Querry = "select * from '" + txtkontynent.Text + "'";
                SQLiteCommand createcommand = new SQLiteCommand(Querry, sqlite_conn);
                SQLiteDataReader dr = createcommand.ExecuteReader();
                while (dr.Read())
                {
                    string Nazwamiejsca = dr.GetString(3);
                    listbox1.Items.Add(Nazwamiejsca);
                }

                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }

        }


        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=  ciekawemiejsca.db;");
            try
            {
                sqlite_conn.Open();
                string Querry = "select * from  '" + txtkontynent.Text + "' where Nazwamiejsca='" + listbox1.SelectedValue.ToString() + "' ";

                SQLiteCommand createcommand = new SQLiteCommand(Querry, sqlite_conn);
                SQLiteDataReader dr = createcommand.ExecuteReader();

                while (dr.Read())
                {
                    string Nazwamiejsca = dr.GetString(3);
                    string Kraj = dr.GetString(1);
                    string Opis = dr.GetString(2);

                    txtkraj.Text = Kraj;
                    txtmiejsce.Text = Nazwamiejsca;
                    txtopis.Text = Opis;




                    byte[] blob = (byte[])(dr["zdjecie"]);
                    MemoryStream stream = new MemoryStream(blob);
                    BitmapImage bitmap = new BitmapImage();

                    bitmap.BeginInit();
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();

                    picturebox.Source = bitmap;
                    textpath.Text = string.Empty;
                }

                sqlite_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            if(txtmiejsce.Text == "" || textpath.Text=="" ){

                MessageBox.Show("Wprowadz nazwę miejsca lub dodaj zdjęcie");

            }

            else {
                byte[] imagebyte = null;
                FileStream fstream = new FileStream(this.textpath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagebyte = br.ReadBytes((int)fstream.Length);


                sqlite_conn = new SQLiteConnection("Data Source=  ciekawemiejsca.db;");
                string Querry = "insert into '" + txtkontynent.Text + "'(Kraj,Opis,Nazwamiejsca,zdjecie) values ('" + this.txtkraj.Text + "','" + this.txtopis.Text + "','" + this.txtmiejsce.Text + "',@IMG) ;";
                SQLiteCommand createcommand = new SQLiteCommand(Querry, sqlite_conn);
                SQLiteDataReader dr;
                try
                {
                    sqlite_conn.Open();
                    createcommand.Parameters.Add(new SQLiteParameter("@IMG", imagebyte));
                    dr = createcommand.ExecuteReader();
                    MessageBox.Show("Zapisane");
                    while (dr.Read())
                    {

                    }
                   
                    sqlite_conn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                
            }
        }

        private void usun_click(object sender, RoutedEventArgs e)
        {
           
            sqlite_conn = new SQLiteConnection("Data Source=  ciekawemiejsca.db;");
            string Querry = "delete from '" + txtkontynent.Text + "'where Nazwamiejsca ='" + this.txtmiejsce.Text + "' ;";
            SQLiteCommand createcommand = new SQLiteCommand(Querry, sqlite_conn);
            SQLiteDataReader dr;
            try
            {
                sqlite_conn.Open();
                dr = createcommand.ExecuteReader();
                MessageBox.Show("Usunięte");
                while (dr.Read())
                {

                }
               
                sqlite_conn.Close();
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void dodajobraz(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg) |*.jpg| PNG Files(*.png)|*.png";

            if (dlg.ShowDialog() == true)
            {
                string pictpath = dlg.FileName.ToString();
                BitmapImage bitmap = new BitmapImage();

                bitmap.BeginInit();
                bitmap.UriSource = new Uri(dlg.FileName, UriKind.Absolute);
                bitmap.EndInit();
                textpath.Text = pictpath;
                picturebox.Source = bitmap;

        }
            else
            {
                MessageBox.Show("brak obrazka");
            }

        }
    }

}
  


