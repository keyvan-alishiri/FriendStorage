using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendStorage.UI.ViewModel;
using Xunit;

namespace FriendStorage.UITests.ViewModel
{
   public class NavigationViewModelTests
    {

        [Fact]
        public void shouldLoadFriends()
        {
            var viewModel = new NavigationViewModel();
            viewModel.Load();

            Assert.Equal(5, viewModel.Friends.Count); 

        }




    }
}
