using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace formsql2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =
        //new SqlConnection("Data Source= DESKTOP-UT3UUPH\\SQLEXPRESS;Initial Catalog=Futbolotomasyonu;Integrated Security=true");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandType = CommandType.StoredProcedure;//store procudere kullanacığını söyledim
            ekle.CommandText = "TakımEkle";
            ekle.Parameters.AddWithValue("TakımUlke", textBox2.Text);
            ekle.Parameters.AddWithValue("TakımAdı",textBox1.Text);
            ekle.Parameters.AddWithValue("TakımŞehri", textBox3.Text);
            ekle.Parameters.AddWithValue("TakımTeknikDirektör", textBox4.Text);
            ekle.Parameters.AddWithValue("TakımBaskan", textBox5.Text);
            ekle.Parameters.AddWithValue("TakımStadı", textBox6.Text);
            ekle.Parameters.AddWithValue("LigID", textBox7.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "Takımlistelecombo";
            SqlDataReader dr;//Verileri okumak için gereken komut
            baglanti.Open();
            dr = komut.ExecuteReader();//var olan okunan değerleri çalıştır.
            while (dr.Read())//kaç tane ıd varsa tek tek okuyorum
            {
                comboBox1.Items.Add(dr["TakımID"]);
        
            }
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "Takımlistele";
            SqlDataAdapter goruntule = new SqlDataAdapter(komut);//verileri çekmek için gereken sınıf
            DataTable doldur = new DataTable();//Bilgileri düzenli bir şekilde tutar.
            goruntule.Fill(doldur);//Bu aşamda data table a dolduruluyor bu bilgiler.
            dataGridView1.DataSource = doldur;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
