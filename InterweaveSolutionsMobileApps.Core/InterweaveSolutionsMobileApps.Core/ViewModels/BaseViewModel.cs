using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsMobileApps.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        protected async Task ReloadDataAsync()
        {
            try
            {
                await InitializeAsync();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        protected virtual async Task InitializeAsync()
        {
            return;
        }
    }
}
