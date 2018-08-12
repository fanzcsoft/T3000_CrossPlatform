using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlakEssentials.SVG;
namespace SVGViewer
{
    public partial class SVGControlTest : Form
    {
        public SVGControlTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             FlakEssentials.SVG.SvgCommon.ConvertSvgFileToImageSource
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                try
                {
                   string pathname = file.FileName;   //获得文件的绝对路径
                                                      // this.pictureBox1.Load(pathname);
                    tImageViewControl1.ImageFilePath = pathname;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
