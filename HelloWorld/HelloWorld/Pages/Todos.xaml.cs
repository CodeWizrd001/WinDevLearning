using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWorld.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Todos : Page
    {
        private List<string> todos;
        public Todos()
        {
            todos = new List<string> { }; 
            this.InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("[+] Add button clicked");
            string text = title.Text.ToString();
            Debug.WriteLine(text);
            bool? done = isDone.IsChecked;
            if (done == true)
            {
                Debug.WriteLine("Done");
            }
            else
            {
                Debug.WriteLine("Not Done");
            }
            todos.Add(text);
            for (int i = 0; i < todos.Count; i += 1)
            {
                Debug.WriteLine(todos[i]);
            }
        }

    }
}
