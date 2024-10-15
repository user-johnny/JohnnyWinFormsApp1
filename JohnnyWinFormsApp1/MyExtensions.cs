using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnnyWinFormsApp1
{
    static internal class MyExtensions
    {
        public static bool IsValidEmail(this string mailadd)
        {
            bool result = false;
            //判斷該字串是否符合電子郵件格式,@前後至少要有一個字元,且@後至少要有一個點和一個字元
            if (mailadd != null)
            {
                result = mailadd.Contains("@");
                result = result && mailadd.IndexOf("@") > 0;
                result = result && mailadd.IndexOf("@") < mailadd.Length - 1;
                result = result && mailadd.IndexOf(".") > mailadd.IndexOf("@");
                result = result && mailadd.IndexOf(".") < mailadd.Length - 1;
            }






                return result;
        }
    }
}
