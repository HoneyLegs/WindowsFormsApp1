using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.ListView;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        object SelectedRoom;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lisрtView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomClicked(object sender, EventArgs e)
        {
            //((ListBox)sender).Visible = !((ListBox)sender).Visible;
            SelectedRoom = sender;
        }


        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            var item = this.Controls.Cast<Control>().Where(x => x.Location.X >= e.X && x.Location.Y >= e.Y
            && x.Location.X + x.Width > e.X && x.Location.Y + x.Height > e.Y).FirstOrDefault();
            if (item is ListView listView)
            {
                listView.Enabled = !listView.Enabled;
            }
        }

        private void listViewPeople_DoubleClick(object sender, EventArgs e)
        {
            // ((ListBox)SelectedRoom).Items.Add(((SelectedListViewItemCollection)listViewPeople.SelectedItems).ToString());                         //

           // (ListViewItem)

                ((ListBox)SelectedRoom).Items.Add(S)

            //((ListBox)SelectedRoom).Visible = false;
        }
    }
}