using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class EmployeeManager : Person, IEmployee, ICheckIn
    {
        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void HienThiThongTin()
        {
            throw new NotImplementedException();
        }

        public void NhapthongTin()
        {
            throw new NotImplementedException();
        }
    }
}
