using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text
using System.Data;

namespace KsrExplorerLib.db
{
    [Serializable]
    public class KsrExplorerDefaultPagingEntity
    {
        public int total_count { get; set; }
        public DataTable dt_list { get; set; }
    }
}
