using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] paths, files;  //Songs paths&files

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = paths[songListBox.SelectedIndex];    //Find songs paths & save UML
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();                      //Object OpenFileDialog ofd
            ofd.Multiselect = true;                                         //Multi Select OK
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    songListBox.Items.Add(files[i]);                        //save files name to List Box
                }
            }
        }
    }
}
