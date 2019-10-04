using DevExpress.Mvvm;
using MailWPF.Controller;
using MailWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MailWPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel() : base()
        {
            Signatures = new ObservableCollection<Signature>();
            this.User = new User(); 

        }
        
        public ICommand FindUserCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    IsClientLoaded = RequestsController.SearchUser(User, Signatures);
                    SelectedSignature = new Signature();
                    if (IsClientLoaded)
                    {
                        SelectedSignature = Signatures.SingleOrDefault(x => x.Id == User.SignatureId);
                    }
                });
            }
        }
        public ICommand RenderCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    RequestsController.SearchSingatureHTML(SelectedSignature);
                });
            }
        }
        public Signature SelectedSignature
        {
            get { return GetValue<Signature>(); }
            set
            {
                SetValue(value);
                RaisePropertyChanged(() => SelectedSignature);
            }
        }
        public User User
        {
            get { return GetValue<User>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<Signature> Signatures
        {
            get { return GetValue<ObservableCollection<Signature>>(); }
            set
            {
                SetValue(value);
                RaisePropertyChanged(() => Signatures);
            }
        }
        public bool IsClientLoaded
        {
            get { return GetValue<bool>(); }
            set
            {
                SetValue(value);
                RaisePropertyChanged(() => IsClientLoaded);
            }
        }
    }
    
}
