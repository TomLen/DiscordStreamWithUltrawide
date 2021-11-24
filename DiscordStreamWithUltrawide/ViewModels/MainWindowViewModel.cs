using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace DiscordStreamWithUltrawide.ViewModels
{
    internal class MainWindowViewModel
    {
        private string _title = "Test Title";
        public MainWindowViewModel()
        {
            
        }
        public string Title
        {
            get { return _title; } 
            set { _title = value; } 
        }
    }
}
