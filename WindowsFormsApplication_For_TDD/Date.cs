using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_For_TDD
{
   public class Date
    {
        public string cnv_to_jpn(int in_year, int in_month, int in_day)
        {
            long _ymd = in_year * 10000 + in_month * 100 + in_day;
            //1868年9月8日より前は引数範囲例外を投げる。
            if (_ymd < 18680908)
            {
                throw new ArgumentOutOfRangeException();
            }
            //日付が正しくない場合、ArgumentExceptionを発生させる。
            DateTime dateValue;
            if (DateTime.TryParse(in_year+"/"+in_month+"/"+in_day, out dateValue))
            {}
            else{
                throw new ArgumentException();
            }
            //明治
            if (_ymd <= 19120730)
            {
                return "明治" + (in_year - 1867) + "年" + in_month + "月" + in_day + "日";
            }
            //大正
            if (_ymd >= 19120731 && _ymd <= 19261225)
            {
                return "大正" + (in_year - 1911) + "年" + in_month + "月" + in_day + "日";
            }
            //昭和
            if (_ymd >= 19261226 && _ymd <= 19890107)
            {
                return "昭和" + (in_year - 1925) + "年" + in_month + "月" + in_day + "日";
            }
            //平成
            if (_ymd >= 19890108)
            {
                return "平成" + (in_year - 1988) + "年" + in_month + "月" + in_day + "日";
            }
                return string.Empty;
        }
    }
}
