using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalstudyroomMangement
{
    public class Registration
    {
        public int registerNum { get; set; }
        public string userId { get; set; }
        public int roomNum { get; set; }
        public int seatNum { get; set; }
        public DateTime takeDay { get; set; }
        public int pay { get; set; }

        public DateTime startday { get; set; }
        public DateTime endday { get; set; }

        public string Description { get; set; }

        public int refundpay { get; set; }

    }
}
