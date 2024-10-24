using ClosedXML.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace JohnnyWinFormsApp1
{
    public class ReleaseInfo
    {
        public List<TaiwanCalendar> CalendarList { get; set; }
    }

    public partial class FormTaiwanCalendar : Form
    {
        public FormTaiwanCalendar()
        {
            InitializeComponent();
            textBoxUrl.Text = @"https://cdn.jsdelivr.net/gh/ruyut/TaiwanCalendar/data/2023.json";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TaiwanCalendar> jsonList = DownloadJson(textBoxUrl.Text);
            ExportExcel(jsonList);
        }

        public string converDate(string date)
        {
            return date.Substring(0, 4) + "/" + date.Substring(4, 2) + "/" + date.Substring(6, 2);
        }
        public string coverHoliday(string date, string description)
        {
            if (!string.IsNullOrEmpty(description) && description != "補假")
            {
                return "國定假日";
            }
            DateTime dt = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                return "例假日";
            }
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                return "休息日";
            }
            else
            {
                return "國定假日";
            }
        }

        public void ExportExcel(List<TaiwanCalendar> CalendarList)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("工作表1");
                worksheet.Cell("A1").Value = "date";
                worksheet.Cell("B1").Value = "chinese";
                worksheet.Cell("C1").Value = "isHoliday";
                worksheet.Cell("D1").Value = "Holiday";
                worksheet.Cell("E1").Value = "Description";
                worksheet.Cell("F1").Value = "休息日例假日";
                worksheet.Cell("G1").Value = "星期";
                int row = 0;
                for (int i = 0; i < CalendarList.Count; i++)
                {
                    if (CalendarList[i].isHoliday == true)
                    {
                        worksheet.Cell(row + 2, 1).Value = converDate(CalendarList[i].date);
                        worksheet.Cell(row + 2, 2).Value = CalendarList[i].description;
                        worksheet.Cell(row + 2, 3).Value = CalendarList[i].isHoliday == true ? "是" : "否";
                        worksheet.Cell(row + 2, 6).Value = coverHoliday(CalendarList[i].date, CalendarList[i].description);
                        worksheet.Cell(row + 2, 7).Value = CalendarList[i].week;
                        row++;
                    }
                }



                string FileName = @"d:\Calendar.xlsx";
                //刪除舊檔案
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }
                workbook.SaveAs(FileName);


                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = FileName,
                    UseShellExecute = true
                };
                Process.Start(psi);

            }
        }

        public List<TaiwanCalendar> DownloadJson(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(textBoxUrl.Text).Result;
                return JsonConvert.DeserializeObject<List<TaiwanCalendar>>(json);
            }
        }
    }
}
