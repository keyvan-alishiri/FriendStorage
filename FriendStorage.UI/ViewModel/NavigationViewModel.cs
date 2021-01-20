﻿using System;
using System.Collections.ObjectModel;
using System.Security.Permissions;
using FriendStorage.DataAccess;
using FriendStorage.Model;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {

        public NavigationViewModel()
        {
               Friends = new ObservableCollection<Friend>(); 
        }   
        public void Load()
        {
           var dataService = new FileDataService();
           foreach (var friend in dataService.GetAllFriends())
           {
               Friends.Add(friend);
           }
        }

        public ObservableCollection<Friend> Friends { get; private set; } 
    }
}
