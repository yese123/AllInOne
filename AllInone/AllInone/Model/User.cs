using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInone.Model
{
    public class User
    {
        private string user { get; set; }
        private ObservableCollection<string> companyCodes { get; set; }
        private string password { get; set; }
    }
}
