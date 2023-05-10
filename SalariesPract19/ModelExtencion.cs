using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesPract19
{
        public partial class SalariesPr19Entities : DbContext
        {
            public static SalariesPr19Entities context;
            public static SalariesPr19Entities GetContext()
            {
                if (context == null)
                    context = new SalariesPr19Entities();
                return context;
            }

        }
}
