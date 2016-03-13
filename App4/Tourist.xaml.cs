
using App4.Model;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Tourist : Page
    {
        private List<Book> Books;
        public Tourist()

        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            textname.Text = "Name : " + book.Name;
            textID.Text = "ID Card Number : " + book.Id ;
            textEmergency.Text = "Emergency Contact : ";
            textnameE.Text = "Name : " + book.Ename;
            textrelation.Text = "Relation : " + book.Relation;
            textTel.Text = "Tel : " + book.Tel;
            textWhistband.Text = "Whistband ID : " + book.Wid;
        }
    }
}
        

      

    

