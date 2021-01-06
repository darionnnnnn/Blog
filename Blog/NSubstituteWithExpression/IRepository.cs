using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NSubstituteWithExpression
{
    public interface IRepository<T>
    {
        IQueryable<T> Query(Expression<Func<T, bool>> filter = null);
    }

}
