using PropertyManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Business.Interface
{
    public interface IAuthorizationService
    {
        bool Regsiter(RegisterVM obj);
        string Login(RegisterVM obj);
        UserVM UserDetails(int UId);
        bool checkAccessKey(string keyValue);
    }
}
