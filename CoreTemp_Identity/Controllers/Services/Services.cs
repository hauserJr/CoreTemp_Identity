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
            void UpdateData<TModel>(TModel model);
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
            public void UpdateData<TModel>(TModel model)
            {
                throw new NotImplementedException();
            }
        }
    }
}
