using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewSample 
{
    public class ContactsViewModel
    {
        #region Properties
        public ObservableCollection<Contacts> Items { get; set; }

        #endregion

        #region Constructor
        public ContactsViewModel()
        {
            Items = new ObservableCollection<Contacts>();
            Random r = new Random(123456789);
            for (int i = 0; i < 25; i++)
            {
                var contact = new Contacts(CustomerNames[i], r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
                Items.Add(contact);
            }
        }

        #endregion

        #region Fields

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Josiah",
            "Oscar",
            "Hudson",
            "Nathaniel",
            "Bryson",
            "Ryder",
            "Justin",
            "Bryson",
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Ryder",
            "Justin",
            "Bryson",
            "Ryder",
            "Justin",
            "Bryce"
        };

        #endregion
    }
}