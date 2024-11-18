using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friperies_2
{
    public static class dbConfig
    {
        public static string ConnectionString => "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=friperiesfix";
    }
}
