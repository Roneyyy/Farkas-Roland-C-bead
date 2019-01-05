using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;


namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        private String MyConnectionString = "Server=localhost;Database=cs_harcosok;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();
            harcosokbetolt();

        }

        private void harcoscreate_Click(object sender, EventArgs e)
        {
            if (harcosNeveTextbox.Text!="")
            {                
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM harcosok WHERE nev=?nev;";
                    cmd.Parameters.AddWithValue("?nev", harcosNeveTextbox.Text);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                }
                catch (Exception)
                {

                    throw;
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Ezen a néven már létezik harcos!");
                }
                else
                {
                    try
                    {
                        cmd = connection.CreateCommand();
                        cmd.CommandText = "INSERT INTO harcosok(`nev`, `letrehozas`) VALUES(?nev,?datum);";
                        string date;
                        DateTime dt1 = DateTime.Now;
                        date = dt1.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.AddWithValue("?nev", harcosNeveTextbox.Text);
                        cmd.Parameters.AddWithValue("?datum", date);
                        cmd.ExecuteNonQuery();
                        harcosokbetolt();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Add meg a harcos nevét!");
            }
        }

        private void kepessegCreate_Click(object sender, EventArgs e)
        {
            if (hasznaloComboBox.SelectedItem!=null)
            {
                if (kepessegNeveTextBox.Text !="" && leirasTextBox.Text !="")
                {
                    MySqlConnection connection = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd = connection.CreateCommand();
                    connection.Open();
                    try
                    {
                        cmd = connection.CreateCommand();
                        cmd.CommandText = "INSERT INTO kepessegek(`nev`, `leiras`, `harcos_id`) VALUES(?nev,?leiras,?harcos_id);";
                        cmd.Parameters.AddWithValue("?nev", kepessegNeveTextBox.Text);
                        cmd.Parameters.AddWithValue("?leiras", leirasTextBox.Text);
                        int harcosid = Selectharcosid(hasznaloComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?harcos_id", harcosid);
                        cmd.ExecuteNonQuery();
                        harcosokbetolt();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Add meg a képesség nevét és leirását");
                }
            }
            else
            {
                MessageBox.Show("Válasz harcost!");
            }
        }
        private void harcosokbetolt()
        {
            hasznaloComboBox.Items.Clear();
            harcosokListBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            try
            {
                cmd.CommandText = "SELECT nev FROM harcosok;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hasznaloComboBox.Items.Add(reader.GetString("nev"));
                        harcosokListBox.Items.Add(reader.GetString("nev"));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            hasznaloComboBox.SelectedItem = null;
            hasznaloComboBox.Text = "";
        }
        private int Selectharcosid(string nev)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = "SELECT id FROM harcosok WHERE nev=?nev;";
                cmd.Parameters.AddWithValue("?nev", nev);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
        private void harcosokListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            kepessegekListBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = connection.CreateCommand();            
            connection.Open();
            try
            {
                cmd.CommandText = "SELECT nev FROM kepessegek WHERE harcos_id=?harcos_id;";
                int harcos_id = Selectharcosid(harcosokListBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?harcos_id", harcos_id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kepessegekListBox.Items.Add(reader.GetString("nev"));
                    }
                }
            }
            catch (Exception)
            {

                
            }
            kepessegLeirasaTextBox.Text = "";
            if (kepessegekListBox.SelectedItem != null)
            {
                modosit.Enabled = true;
                kepessegLeirasaTextBox.Enabled = true;
            }
            else
            {
                modosit.Enabled = false;
                kepessegLeirasaTextBox.Enabled = false;
            }
        }

        private void kepessegekListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = "SELECT leiras FROM kepessegek WHERE nev=?kepesseg_nev;";
                cmd.Parameters.AddWithValue("?kepesseg_nev", kepessegekListBox.SelectedItem.ToString());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                kepessegLeirasaTextBox.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                               
            }
            if (kepessegekListBox.SelectedItem!=null)
            {
                modosit.Enabled = true;                
                kepessegLeirasaTextBox.Enabled = true;
            }
            else
            {
                modosit.Enabled = false;
                kepessegLeirasaTextBox.Enabled = false;
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "DELETE FROM kepessegek WHERE nev=?kepessegnev AND harcos_id=?harcos_id";
            cmd.Parameters.AddWithValue("?kepessegnev", kepessegekListBox.SelectedItem.ToString());
            int harcos_id = Selectharcosid(harcosokListBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?harcos_id", harcos_id);
            cmd.ExecuteNonQuery();
            kepessegekListBox.Items.Clear();  
            try
            {
                cmd.CommandText = "SELECT nev FROM kepessegek WHERE id=?harcos;";               
                cmd.Parameters.AddWithValue("?harcos", harcos_id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kepessegekListBox.Items.Add(reader.GetString("nev"));
                    }
                }
            }            
            catch (Exception)
            {

                throw;
            }
            kepessegLeirasaTextBox.Text = "";

        }

        private void modosit_Click(object sender, EventArgs e)
        {
            if (kepessegLeirasaTextBox.Text!="")
            {
                string modositott = kepessegLeirasaTextBox.Text;
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                cmd.CommandText = "UPDATE kepessegek SET `leiras`=?leiras WHERE nev=?nev AND harcos_id=?harcos_id";
                cmd.Parameters.AddWithValue("?leiras", modositott);
                cmd.Parameters.AddWithValue("?nev", kepessegekListBox.SelectedItem.ToString());
                int harcos_id = Selectharcosid(harcosokListBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?harcos_id", harcos_id);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Adj meg leirást a képességnek!");
            }

        }
    }
}
