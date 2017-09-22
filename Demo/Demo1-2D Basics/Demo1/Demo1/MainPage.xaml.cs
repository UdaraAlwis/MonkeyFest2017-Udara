using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Demo1
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
            var skCanvasHeight = skImageInfo.Height;


            // move canvas X,Y to center of screen
            skCanvas.Translate((float)skCanvasWidth / 2, (float)skCanvasHeight / 2);

            // move canvas X,Y to center of screen
            skCanvas.Scale((float)skCanvasWidth / 200);


            // Draw any kind of Shape
            SKPaint strokePaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Black,
                StrokeWidth = 10,
                IsAntialias = true,
            };

            // Create the path
            SKPath path = new SKPath();

            // Define the drawing path points
            path.MoveTo(+50, 0); // start point
            path.LineTo(+50, -50); // first move to this point
            path.LineTo(-30, -80); // move to this point
            path.LineTo(-70, 0); // then move to this point
            path.LineTo(-10, +90); // then move to this point
            path.LineTo(+50, 0); // end point

            path.Close(); // make sure path is closed
            // Fill and stroke the path
            skCanvas.DrawPath(path, strokePaint);


        }
    }
}
