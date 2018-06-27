using System;
using System.Windows;
using GalaSoft.MvvmLight;

namespace evonGuiWorkshop.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
             
            if (IsInDesignMode)
            {
                Title = "Hello DesignWorld";
            }
            else
            {
                Title = "Hello World";
            }
            MessengerInstance.Register<string>(this,"gui", SearchViewModelChanged);
        }

        private void SearchViewModelChanged(string obj)
        {
            MessageBox.Show(obj.ToString());
        }

        public string Title { get; set; }
    }
}