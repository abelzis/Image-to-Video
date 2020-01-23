using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFMediaToolkit.Graphics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Video_Processing__AI__Machine_Learning
{
    static class BitmapHelper
    {
        // Function transforms pixel data to bitmap image
        public static Image<Bgr24> ToBitmap(this ImageData imageData)
        {
            return Image.LoadPixelData<Bgr24>(imageData.Data, imageData.ImageSize.Width, imageData.ImageSize.Height);
        }
    }
}
