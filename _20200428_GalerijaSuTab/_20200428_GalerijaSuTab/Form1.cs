using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20200428_GalerijaSuTab
{
    public partial class Form1 : Form
    {

        readonly Dictionary<TabPage, PaveiksliukoInformacija> informacijosZodynas;
        public Form1()
        {
            InitializeComponent();
            informacijosZodynas = new Dictionary<TabPage, PaveiksliukoInformacija>();
        }

        private void UzkrautiFoto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string kelias = null;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                kelias = folder.SelectedPath;
            }
            if (kelias != null)
            {
                UzkrautuVisasNuotraukasFolderyje(kelias);
            }
        }

        private void UzkrautuVisasNuotraukasFolderyje(string path)
        {
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(path);
            int i = 0;
            foreach (var item in info.GetFiles())
            {
                if (item.Extension == ".jpg" || item.Extension == ".jpeg" || item.Extension == ".png")
                {
                    TabPage page = new TabPage();
                    page.BackgroundImage = Image.FromFile(item.FullName);
                    page.Text = (i++).ToString();
                    Galerija.TabPages.Add(page);
                    PaveiksliukoInformacija infor = new PaveiksliukoInformacija();
                    informacijosZodynas.Add(page, infor);
                    infor.Pavadinimas = item.Name.TrimEnd(item.Extension.ToCharArray());
                    infor.Pletinys = item.Extension;

                    informacijosZodynas.Add(page, infor);
                }
            }
        }

        private void Galerija_SelectedIndexChanged(object sender, EventArgs e)
        {
            PavadinimasTextBox.Text = informacijosZodynas[Galerija.SelectedTab].Pavadinimas;
            PletinysTextBox.Text = informacijosZodynas[Galerija.SelectedTab].Pletinys;
        }
    }

    class PaveiksliukoInformacija
    {
        public string Pavadinimas { get; set; }
        public string Pletinys { get; set; }

    }
}
