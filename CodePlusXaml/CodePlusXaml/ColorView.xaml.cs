using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CodePlusXaml
{
    public partial class ColorView : ContentView
    {
        string colorName;
        ColorTypeConverter colorTypeCon = new ColorTypeConverter();

        public ColorView()
        {
            InitializeComponent();
        }

        public string ColorName
        {
            set
            {
                // set the name
                colorName = value;
                colorNamelabel.Text = value;

                // get the actual Color object from the text
                Color color = (Color)colorTypeCon.ConvertFromInvariantString(colorName);
                boxView.Color = color;
                colorValueLabel.Text = string.Format("{0:X2}-{1:X2}-{2:X2}",
                                                     (int)(255 * color.R),
                                                     (int)(255 * color.G),
                                                     (int)(255 * color.B));
            }

            get
            {
                return colorName;
            }
        }
    }
}
