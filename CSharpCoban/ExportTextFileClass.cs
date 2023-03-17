using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class ExportTextFileClass : IExportData
    {
        public string Export()
        {
            return "export text file";
        }

        public int Import()
        {
            throw new NotImplementedException();
        }
    }
}
