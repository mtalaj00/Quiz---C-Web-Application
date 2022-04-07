using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Service
{
    public class RandomNumbers
    {            
        public int[] getRandom()
        {
            int[] arrayID = new int[2];
            Random random = new Random();
            List<int> randomNumbers = new List<int>();
    
            for (int i = 0; i < 2; i++)
            {
                int number;

                do number = random.Next(1, 2 + 1);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            for (int i = 0; i < 2; i++)
            {
                arrayID[i] = randomNumbers[i];
            }
            return arrayID;
        }
         
     }
}