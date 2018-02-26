using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListsPage : ContentPage
	{
		public ListsPage ()
		{
			InitializeComponent ();


            listView.ItemsSource = new List<Contact>
            {   


                new Contact { Name = "Mosh", ImageUrl ="http://lorempixel.com/100/100/people/1", Status="lets talk!"},
                new Contact { Name = "Dan", ImageUrl ="http://lorempixel.com/100/100/people/2", Status="lets talk!"},
                new Contact { Name = "Mob", ImageUrl ="http://lorempixel.com/100/100/people/3", Status="lets talk!"}
            };
		}
	}
}