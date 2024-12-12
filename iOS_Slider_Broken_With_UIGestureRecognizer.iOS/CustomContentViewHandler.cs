using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Handlers;
using UIKit;
using ContentView = Microsoft.Maui.Platform.ContentView;

namespace iOS_Slider_Broken_With_UIGestureRecognizer.iOS
{
	public class CustomContentViewHandler : ContentViewHandler
	{
		protected override void ConnectHandler(ContentView platformView)
		{
			var gesture = new UIGestureRecognizer();
			platformView.AddGestureRecognizer(gesture);

			base.ConnectHandler(platformView);
		}
	}
}
