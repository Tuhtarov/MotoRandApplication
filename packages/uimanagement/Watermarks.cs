using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MotoRandApplication.packages.uimanagement
{
    public class Watermarks
    {
        private ImageBrush placeholder;

        public Watermarks(string url)
        {
            placeholder = new ImageBrush();
            placeholder.ImageSource = new BitmapImage(
                new Uri(@url, UriKind.Absolute)
                );
            placeholder.AlignmentX = AlignmentX.Center;
            placeholder.Stretch = Stretch.None;
        }

        public ImageBrush GetPlaceholder()
        {
            return placeholder;
        }
    }
}
