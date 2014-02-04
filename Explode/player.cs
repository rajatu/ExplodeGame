using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Explode
{   
   class player
    {
      public int [ , ]  pos = new int[8,8];
      public  player()
        {
            for(int i=0;i<8;i++)
            for(int j=0;j<7;j++)
               pos[i,j]=0;
        }
    }
}
