using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recp_18_ok
{
    public class pass
    {
        public string username {  get; set; }
        public string password { get; set; }
        public List<pass> managers { get; set; }
        public pass()
        {
            managers = new List<pass>();
        }
        public bool RightInloggning(string username, string password)
        {
            foreach (var admin in managers)
            {
                if (admin.username == username && admin.password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }


}
