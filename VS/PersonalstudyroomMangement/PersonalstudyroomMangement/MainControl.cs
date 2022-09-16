using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
            
            label_all_now.Text = DataManage.registrations.Count.ToString();
            label_all_empty.Text = (int.Parse(label_all_total.Text) - int.Parse(label_all_now.Text)).ToString();
            label_all_expired.Text = DataManage.registrations.Find((x)=>x.endday >= DateTime.Now).ToString(); 
        }
    }
}
