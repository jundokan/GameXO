using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameXO.Views;

using Xamarin.Forms;

namespace GameXO
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
		    MainPage = new MainGamePage();
		}
	}
}
