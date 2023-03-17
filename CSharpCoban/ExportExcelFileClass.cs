using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    internal class ExportExcelFileClass : IExportData
    {
        public string Export()
        {
            return "Export Excel File";
        }

        public int Import()
        {
            throw new NotImplementedException();
        }
    }
}
