using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Svg
{
    public partial class TImageViewControl : UserControl, IImageViewControl
    {
        public TImageViewControl()
        {
            InitializeComponent();
        }
        private string _strImagefilepath = "";
        public string ImageFilePath
        {
            get
            {
                return _strImagefilepath;
            }
            set
            {
                _strImagefilepath = value;
                ShowImage();

            }
        }
        private bool _isLocal = true;
        public bool Is_LocalImage
       {  get
            {
                return _isLocal;
            }
            set
            {
                _isLocal = value;
            }
        }
        private void ShowImage()
        {
          if(_strImagefilepath.Length<2)
          {
                pictureBox1.Image = null;
                return; 
          }
            string strextend = Path.GetExtension(_strImagefilepath);
            //不是svg格式
            if(_isLocal && 
             strextend.ToLower().CompareTo("svg")!=0
             )
          {
                pictureBox1.Image = Image.FromFile(_strImagefilepath);
          }
          else if(_isLocal && strextend.ToLower().CompareTo("svg") == 0)
          {
                MessageBox.Show("11");
                var doc = new SvgDocument();
                try
                {
                       
                       pictureBox1.Image = null;
                       doc = SvgDocument.Open(_strImagefilepath);
                       pictureBox1.Image = doc.Draw();
                    MessageBox.Show("22");
                }
                catch (Exception ex)
                {
                    pictureBox1.Image = null;
                }
            }

        }
    }
}
