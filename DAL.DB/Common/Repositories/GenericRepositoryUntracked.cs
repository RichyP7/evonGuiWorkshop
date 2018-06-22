using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMManufacturing.DB.Model;

namespace XAMManufacturing.DB.Common.Repositories.Base
{
    public class GenericRepositoryUntracked<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public GenericRepositoryUntracked(X4ManufacturingContainer context) : base(context)
        {
        }
        protected override IQueryable<TEntity> SetQuery()
        {
            return base.dbSet.AsNoTracking();
        }
    }
}
