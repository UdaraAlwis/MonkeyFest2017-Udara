using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Demo3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SkCanvasView_OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            // Init skcanvas
            SKImageInfo skImageInfo = e.Info;
            SKSurface skSurface = e.Surface;
            SKCanvas skCanvas = skSurface.Canvas;

            skCanvas.Clear(SKColors.White);

            var skCanvasWidth = skImageInfo.Width;
            var skCanvasheight = skImageInfo.Height;

            // move canvas X,Y to center of screen
            skCanvas.Translate((float)skCanvasWidth / 2, (float)skCanvasheight / 2);
            // set the pixel scale of the canvas
            skCanvas.Scale(skCanvasWidth / 200f);
            

        }
    }
}
