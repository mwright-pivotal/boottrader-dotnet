using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace boottrader_dotnet.Controllers
{
    public class AccountController : ApiController
    {
        AccountDataBean[] accounts = new AccountDataBean[10];
        // GET: api/Account
        public IEnumerable<AccountDataBean> Get()
        {
            return accounts;
        }

        // GET: api/Account/5
        [ResponseType(typeof(AccountDataBean))]
        public AccountDataBean Get(int id)
        {
            return accounts[id];
        }

        // POST: api/Account
       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// 
       [HttpPost]
        public void Post([FromBody]AccountDataBean value)
        {
            if (value.AccountID > 9)
                throw new Exception("can't do it, only 10 accounts in this system");
            accounts[value.AccountID] = value;
        }

        // PUT: api/Account/5
        [HttpPut]
        public void Put(int id, [FromBody]AccountDataBean value)
        {
            if (id > 9)
                throw new Exception("can't do it, only 10 accounts in this system");
            accounts[id] = value;
        }

        // DELETE: api/Account/5
        public void Delete(int id)
        {
            if (id > 9)
                throw new Exception("can't do it, only 10 accounts in this system");
            accounts[id] = null ;
        }
    }
}
