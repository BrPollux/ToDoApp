using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Projeler : MetroFramework.Forms.MetroForm
    {
        public Projeler()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=todoproje;Integrated Security=True";//sql bağlantı kodu.

        DataSet daset = new DataSet();//gridviewı doldurmak için dataset.
        static public string aktifId;// seçilen rowdaki id yi tutabilmek için değişken.
        private void Projeler_Load(object sender, EventArgs e)
        {
            Guncelle();          
        }

        private void Guncelle()// işlemlerden sonra gridviewı güncellemek için metod.
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tbl_proje", con);
            adtr.Fill(daset, "tbl_proje");
            dtg_projeler.DataSource = daset.Tables["tbl_proje"];
            con.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)// seçilen rowdaki projeyi siler.
        {
            string b = dtg_projeler.CurrentRow.Cells["kartNo_id"].Value.ToString();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand komut2 = new SqlCommand("delete from tbl_task where task_fk_kartNo='" + b + "'", con);//silinecek projenin tasklarını siler. 
            komut2.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_proje where kartNo_id='" + dtg_projeler.CurrentRow.Cells["kartNo_id"].Value.ToString() + "'", con);//projeyi siler.
            komut.ExecuteNonQuery();
            con.Close();
            daset.Tables["tbl_proje"].Clear();
            
            
            daset.Tables["tbl_proje"].Clear();
            if (daset.Tables["tbl_task"] != null)
            {
                daset.Tables["tbl_task"].Clear();
            }
            

            Guncelle();
            MessageBox.Show("Proje panelden silindi.");
            
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            Main ma = new Main(); //ana ekrana döner
            ma.Show();
            this.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            aktifId = dtg_projeler.CurrentRow.Cells["kartNo_id"].Value.ToString(); // seçilen rowun idsini değişkene atar.
            Güncelle gn = new Güncelle();//güncelleme ekranına gönderir.
            gn.Show();
            this.Close();
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            aktifId = dtg_projeler.CurrentRow.Cells["kartNo_id"].Value.ToString(); // seçilen rowun idsini değişkene atar.
            Panel pn = new Panel();//panele göderir.
            pn.Show();
            this.Close();
        }
    }
}
