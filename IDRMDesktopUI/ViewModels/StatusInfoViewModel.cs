﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDRMDesktopUI.ViewModels
{
    public class StatusInfoViewModel : Screen
    {
        public string Header { get; private set; }
        public string Message { get; private set; }

        public void UpdateMesage(string header, string message)
        {
            Header = header;
            Message = message;

            NotifyOfPropertyChange(() => Header);
            NotifyOfPropertyChange(() => Message);
        }

        public void Close()
        {
            TryClose();
        }
    }
}
