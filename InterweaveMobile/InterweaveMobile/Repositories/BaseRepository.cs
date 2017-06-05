using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveMobile.Repositories
{
    public class BaseRepository
    {
        protected async Task<T> GetAsync<T>(string url) where T : new()
        {
            // TODO actually go and get the stuff, deserialize that JSON, return the sucker
            throw new NotImplementedException();
        }
    }
}
