using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktek_Form_3
{
    public partial class berandagk1 : Form
    {
        string TeksLantai1 = "101", TeksLantai2 = "201", TeksLantai3 = "301", TeksLantai4 = "401", TeksLantai5 = "501";
        public berandagk1()
        {
            InitializeComponent();
        }

        private void Lantai1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeksLantai1 = Lantai1.Text;
            displayTeks1();
        }
        private void Lantai2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeksLantai2 = Lantai2.Text;
            displayTeks2();
        }

        private void Lantai3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeksLantai3 = Lantai3.Text;
            displayTeks3();
        }

        private void Lantai4_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeksLantai4 = Lantai4.Text;
            displayTeks4();
        }

        private void Lantai5_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeksLantai5 = Lantai5.Text;
            displayTeks5();
        }


        public void berandagk1_Load(object sender, EventArgs e)
        {
            displayTeks1();
            displayTeks2();
            displayTeks3();
            displayTeks4();
            displayTeks5();
        }

        //Deskripsi Lantai1
        private void displayTeks1()
        {
            if (TeksLantai1 == "101")
            {
                label1.Text = "Deskripsi 1";
            }
            else if (TeksLantai1 == "102")
            {
                label1.Text = "Deskripsi 2";
            }
            else if (TeksLantai1 == "103")
            {
                label1.Text = "Deskripsi 3";
            }
            else if (TeksLantai1 == "104")
            {
                label1.Text = "Deskripsi 4";
            }
            else if (TeksLantai1 == "105")
            {
                label1.Text = "Deskripsi 5";
            }
            else if (TeksLantai1 == "106")
            {
                label1.Text = "Deskripsi 6";
            }
            else if (TeksLantai1 == "107")
            {
                label1.Text = "Deskripsi 7";
            }
        }

        //Deskripsi Lantai2
        private void displayTeks2()
        {
            if (TeksLantai2 == "201")
            {
                label2.Text = "Deskripsi 1";
            }
            else if (TeksLantai2 == "202")
            {
                label2.Text = "Deskripsi 2";
            }
            else if (TeksLantai2 == "203")
            {
                label2.Text = "Deskripsi 3";
            }
            else if (TeksLantai2 == "204")
            {
                label2.Text = "Deskripsi 4";
            }
            else if (TeksLantai2 == "205")
            {
                label2.Text = "Deskripsi 5";
            }
            else if (TeksLantai2 == "206")
            {
                label2.Text = "Deskripsi 6";
            }
            else if (TeksLantai2 == "207")
            {
                label2.Text = "Deskripsi 7";
            }
        }

        //Deskripsi Lantai3
        private void displayTeks3()
        {
            if (TeksLantai3 == "301")
            {
                label3.Text = "Deskripsi 1";
            }
            else if (TeksLantai3 == "302")
            {
                label3.Text = "Deskripsi 2";
            }
            else if (TeksLantai3 == "303")
            {
                label3.Text = "Deskripsi 3";
            }
            else if (TeksLantai3 == "304")
            {
                label3.Text = "Deskripsi 4";
            }
            else if (TeksLantai3 == "305")
            {
                label3.Text = "Deskripsi 5";
            }
            else if (TeksLantai3 == "306")
            {
                label3.Text = "Deskripsi 6";
            }
            else if (TeksLantai3 == "307")
            {
                label3.Text = "Deskripsi 7";
            }
        }

        //Deskripsi Lantai4
        private void displayTeks4()
        {
            if (TeksLantai4 == "401")
            {
                label4.Text = "Deskripsi 1";
            }
            else if (TeksLantai4 == "402")
            {
                label4.Text = "Deskripsi 2";
            }
            else if (TeksLantai4 == "403")
            {
                label4.Text = "Deskripsi 3";
            }
            else if (TeksLantai4 == "404")
            {
                label4.Text = "Deskripsi 4";
            }
            else if (TeksLantai4 == "405")
            {
                label4.Text = "Deskripsi 5";
            }
            else if (TeksLantai4 == "406")
            {
                label4.Text = "Deskripsi 6";
            }
            else if (TeksLantai4 == "407")
            {
                label4.Text = "Deskripsi 7";
            }
        }

        //Deskripsi Lantai5
        private void displayTeks5()
        {
            if (TeksLantai5 == "501")
            {
                label6.Text = "Deskripsi 1";
            }
            else if (TeksLantai5 == "502")
            {
                label6.Text = "Deskripsi 2";
            }
            else if (TeksLantai5 == "503")
            {
                label6.Text = "Deskripsi 3";
            }
            else if (TeksLantai5 == "504")
            {
                label6.Text = "Deskripsi 4";
            }
            else if (TeksLantai5 == "505")
            {
                label6.Text = "Deskripsi 5";
            }
            else if (TeksLantai5 == "506")
            {
                label6.Text = "Deskripsi 6";
            }
            else if (TeksLantai5 == "507")
            {
                label6.Text = "Deskripsi 7";
            }
        }
    }
}
