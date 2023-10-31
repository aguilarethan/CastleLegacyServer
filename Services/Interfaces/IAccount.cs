using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Database.Model;

namespace Services.Interfaces
{
    [ServiceContract]
    public interface IAccount
    {
        [OperationContract]
        int AddAccount(Account account);
        [OperationContract]
        Account GetAccount(string username);

    }
}
