using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1
{
    public class DataClass
    {
        public string [] GetBlocksDate()
        {
            var title1 = "7500";
            var title2 = "1247";
            var title3 = "120";

            string [] blocksdata = new string[] { title1, title2, title3 };
            return blocksdata;
        }
    }
}
