using AllInone.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AllInone.ViewModel
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
            ScrumMaster = GetDataFromZhiHu();//new Contact { LastName = "Zheng", FirstName = "Silong" };
            MyContacts();
        }

        public Contact ScrumMaster { get; set; }

        public ObservableCollection<Contact> Contacts { get; set; }

        public void MyContacts()
        {
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(GetDataFromZhiHu());
            Contacts.Add(new Contact { LastName = "Zheng", FirstName = "Silong" });
        }
        public Contact GetDataFromZhiHu()
        {
            return new Contact { LastName = "Zhi", FirstName = "hu" ,PhoneNumber="10086"};
        }

        private ICommand _addContactCommand;
        public ICommand AddContactCommand
        {
            get
            {
                return _addContactCommand ?? (_addContactCommand = new RelayCommand(AddContactImp));
            }
        }

        void AddContactImp()
        {
            AddContact();
        }

        public void AddContact()
        {
            Contacts.Add(new Contact { LastName=ScrumMaster.LastName,FirstName=ScrumMaster.FirstName,PhoneNumber=ScrumMaster.PhoneNumber});
        }
    }
}