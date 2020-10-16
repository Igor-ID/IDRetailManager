using Caliburn.Micro;
using IDRMDesktopUI.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {        
        private IEventAggregator _events;
        private SalesViewModel _salesVM;

        // All ViewModels and Views that was included to constructor to provide and implement Dependency Injection
        // are stored for a long term. E.g. we don't need Login ViewModel stored for a long term
        // in that case we removed it from the constructor and placed inside the ActivateItem
        // Now with ActivateItem when we activate it we get the clean ViewModel every time as new instance per request, 
        // and when deactivate the LoginViewModel will go away.
        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM)
        {
            _events = events;
            _salesVM = salesVM;            
            _events.Subscribe(this);            
            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }        
    }
}
