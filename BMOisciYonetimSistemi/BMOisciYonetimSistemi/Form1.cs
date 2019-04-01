using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//dosya okuma işlemi için eklendi.
using System.Collections;//arrayList bileşeni için eklendi.
namespace BMOisciYonetimSistemi
{   
    
    public partial class Form1 : Form
    {
        ArrayList calisanlar = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Id,Name,Surname,address,salary
            string line;
            FileStream file = new FileStream("Deneme.txt",FileMode.Open);
            Encoding tr = Encoding.GetEncoding("iso-8859-9");
            StreamReader sr = new StreamReader(file, tr);
            
            while ((line = sr.ReadLine()) != null)
            {
                string[] bilgiler = line.Split(',');
                //lbxIsci.Items.Add(line);
                lbxIsci.Items.Add(bilgiler[0] +'\t'+ bilgiler[1] + '\t' + bilgiler[2] + '\t' + bilgiler[3] + '\t' + bilgiler[4]);
                calisanlar.Add(new Calisan(bilgiler[0], bilgiler[1], bilgiler[2], bilgiler[3], Convert.ToDouble(bilgiler[4])));
                //lbxIsci.Items.Add(bilgiler[0] + '\t' + bilgiler[1] + '\t' + bilgiler[2] + '\t' + bilgiler[3] + '\t' + bilgiler[4]);

            }

            file.Close();

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbMaas_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}
