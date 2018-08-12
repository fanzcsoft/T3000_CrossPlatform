using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svg
{
  public  interface IImageViewControl
    {
        //bool Visible { get; set; }
        //int Width { get; set; }
        //int Height { get; set; }
        string ImageFilePath { get; set; }
        bool Is_LocalImage{ get; set; }
    }
}
