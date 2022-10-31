using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Informatica.Dal
{
  public class UtilDal
  {
    public static string WhereOrAnd(string query)
    {
      return query.ToUpper().Contains(" WHERE ") ? " AND " : " WHERE ";
    }
  }
}
