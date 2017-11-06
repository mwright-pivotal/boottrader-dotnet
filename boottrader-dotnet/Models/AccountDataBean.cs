using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace boottrader_dotnet
{
    [DataContractAttribute]
    public class AccountDataBean
    {
        private int accountID; /* accountID */


        private int loginCount; /* loginCount */

        private int logoutCount; /* logoutCount */

        private DateTime lastLogin; /* lastLogin Date */

        private DateTime creationDate; /* creationDate */

        private Double balance; /* balance */
        private Double openBalance; /* open balance */

        public AccountDataBean(DateTime creationDate, int accountID, int loginCount, int logoutCount, DateTime lastLogin, double balance, double openBalance)
        {
            CreationDate = creationDate;
            AccountID = accountID;
            LoginCount = loginCount;
            LogoutCount = logoutCount;
            LastLogin = lastLogin;
            Balance = balance;
            OpenBalance = openBalance;
        }

        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public int LoginCount { get => loginCount; set => loginCount = value; }
        public int LogoutCount { get => logoutCount; set => logoutCount = value; }
        public DateTime LastLogin { get => lastLogin; set => lastLogin = value; }
        public double Balance { get => balance; set => balance = value; }
        public double OpenBalance { get => openBalance; set => openBalance = value; }
    }
}