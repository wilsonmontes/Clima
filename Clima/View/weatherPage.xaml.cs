﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clima.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class weatherPage : ContentPage
	{
		public weatherPage ()
		{
			InitializeComponent ();
		}
	}
}