using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Composition;
using Windows.UI.Xaml.Hosting;
using System.Threading.Tasks;
using System.Numerics;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CustomPageSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void myBtn_Click(object sender, RoutedEventArgs e)
        {
            Compositor _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            Visual _targetVisual = ElementCompositionPreview.GetElementVisual(this);
            var animation = _compositor.CreateScalarKeyFrameAnimation();
            animation.Duration = new TimeSpan(0, 0, 0, 0, 3000);
            animation.InsertKeyFrame(0.0f, 1.0f);
            animation.InsertKeyFrame(1.0f, 0.0f);
            
            _targetVisual.StartAnimation("Opacity", animation);
            await Task.Delay(3000);//Give some time for the animation to start
            Frame.Navigate(typeof(NewPage));
        }
        
    }
}
