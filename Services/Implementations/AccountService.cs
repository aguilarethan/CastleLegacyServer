using Database.Model;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class AccountService : IAccount
    {
        public int AddAccount(Account account)
        {
            int band = 0;

            try
            {
                using (var context = new CastleLegacyEntities())
                {
                    context.Account.Add(account);
                    context.SaveChanges();
                }
                band = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar la cuenta" + ex.Message);
            }

            return band;
        }

        public Account GetAccount(string username)
        {
            try
            {

                using (var context = new CastleLegacyEntities())
                {
                    var account = context.Account.FirstOrDefault(a => a.Username == username);
                    return account;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la cuenta" + ex.Message);
                return null;

            }
        }
    }
}
