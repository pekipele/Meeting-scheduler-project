﻿using MeetingShedulerUI.Commands;
using MeetingShedulerUI.Services;
using MeetingShedulerUI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MeetingShedulerUI.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand NavigateProfile { get; }

        public LoginViewModel(NavigationStore navigationStore)
        {
            NavigateProfile = new NavigateCommand<ProfileViewModel>
                (new NavigationService<ProfileViewModel>(navigationStore, () => new ProfileViewModel(navigationStore)));
        }
    }
}
