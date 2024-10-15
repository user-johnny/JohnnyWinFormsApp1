using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnnyWinFormsApp1
{
    enum MyEnum
    {
        Info,
        Warning,
        Error
    }
    internal class MyMessage
    {
        public void PrintInClassMessage()
        {
            MessageBox.Show("My Class");
        }

        public void PrintInClassMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public void PrintInClassMessage(string msg,bool ShowTime, MyEnum level)
        {
            string datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); 
            if(ShowTime)
            {
                msg = datetime + "\n" + msg;
            }
            if (level == MyEnum.Info)
            {
                msg = "Info:\n" + msg;
            }
            else if (level == MyEnum.Warning)
            {
                msg = "Warning:\n" + msg;
            }
            else if (level == MyEnum.Error)
            {
                msg = "Error:\n" + msg;
            }
            MessageBox.Show(msg);
        }

    }
}
