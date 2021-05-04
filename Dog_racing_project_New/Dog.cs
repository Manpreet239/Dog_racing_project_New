using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_racing_project_New
{
   public class Dog
    {
        Random obj = new Random();
        //this code is used for the runing of the dogs 
        public int jump()
        {

            return obj.Next(1, 50);
        }
    }
}
