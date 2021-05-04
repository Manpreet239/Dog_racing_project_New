using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_racing_project_New
{
   public class Player
    {
        public String plName;
        public int betAmount;
        public int dogNo;
        public int Balance;

        // different functions working of player in players class

        public Player(String name, int bet,int dog,int blnce) {
            plName = name;
            betAmount = bet;
            dogNo = dog;
            Balance = blnce;
        }
        public int restResult(int win) {
            if (dogNo == win)
            {
                return Balance + betAmount;
            }
            else {
                return Balance - betAmount;
            }
        }
        Random obj = new Random();
        //this code is used for the runing of the dogs 
        public int jump() {
            
            return obj.Next(1, 50);
        }

        public int jump2()
        {
            
            return obj.Next(1, 50);
        }

        public int jump3()
        {
            
            return obj.Next(1, 45);
        }
        public int jump4()
        {
            
            return obj.Next(1, 50);
        }


    }
}
