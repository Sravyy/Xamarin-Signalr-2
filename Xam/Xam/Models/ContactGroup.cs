using System;
using System.Collections.Generic;
using System.Text;

namespace Xam.Models
{
    class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitile { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitile = shortTitle;
        }
    }
}
