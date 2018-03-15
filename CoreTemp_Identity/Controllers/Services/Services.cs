using CoreTemp_Identity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTemp_Identity.Controllers.Services
{
    public class Services
    {
        public interface IDBManage
        {
            void CreateData<TModel>(TModel model);
        }
        public class DBm
        {
            private IDBManage _IDBManage;
            public DBm(IDBManage dBManage) => this._IDBManage = dBManage;

            public void Use<TDBManage>(Action<IDBManage> config)
                where TDBManage : class, IDBManage
            {
                config(this._IDBManage);
            }
        }

        public class DBAction : IDBManage
        {
            private readonly CoreContext db;
            public DBAction(CoreContext _db)
            {
                this.db = _db;
            }
            public void CreateData<TModel>(TModel model)
            {
                
                db.UpdateRange(model);
                db.SaveChanges();
            }
        }
    }
}
