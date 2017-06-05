using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.ViewModels
{
    public class BaseViewModel
    {
        virtual protected async Task InitializeAsync()
        {
        }
    }
}
