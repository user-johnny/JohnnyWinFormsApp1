using ClosedXML.Excel;
using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace JohnnyWinFormsApp1
{

    public partial class FormInternet : Form
    {

        List<StockData> stockDatas = new List<StockData>();
        List<School> schoolDatas = new List<School>();
        public FormInternet()
        {
            InitializeComponent();
            textBoxURL.Text = @"https://stats.moe.gov.tw/files/detail/112/112_ab111_S.csv";

        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text;
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(url).Result;
                List<string> lines = new List<string>();
                lines = data.Replace("\"", "").Split("\r\n").ToList();
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
                foreach (string line in lines)
                {
                    if (line.StartsWith("學年度") || line == "")
                    {
                        continue;
                    }
                    string[] items = line.Split(",");
                    School school = new School();
                    school.Year = Convert.ToInt32(items[0]);
                    school.SchoolType = items[1];
                    school.SchoolID = items[2];
                    school.SchoolName = items[3];
                    school.S1 = Convert.ToInt32(items[4]);
                    school.S2 = Convert.ToInt32(items[5]);
                    school.S3 = Convert.ToInt32(items[6]);
                    school.S4 = Convert.ToInt32(items[7]);
                    school.S5 = Convert.ToInt32(items[8]);
                    school.S6 = Convert.ToInt32(items[9]);
                    school.S7 = Convert.ToInt32(items[10]);
                    school.S8 = Convert.ToInt32(items[11]);
                    school.S9 = Convert.ToInt32(items[12]);
                    schoolDatas.Add(school);

                }
                dataGridView1.DataSource = schoolDatas;

            }
        }
        public string ConvertNumber(string source)
        {
            string result = "";
            if (source == "")
            {
                result = "0";
            }
            else
            {

            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("School");
                worksheet.Cell("A1").Value = "學年度";
                worksheet.Cell("B1").Value = "學校類別";
                worksheet.Cell("C1").Value = "學校代碼";
                worksheet.Cell("D1").Value = "學校名稱";
                worksheet.Cell("E1").Value = "學位生_正式修讀學位外國生";
                worksheet.Cell("F1").Value = "學位生_僑生(含港澳)";
                worksheet.Cell("G1").Value = "學位生_正式修讀學位陸生";
                worksheet.Cell("H1").Value = "非學位生_外國交換生";
                worksheet.Cell("I1").Value = "非學位生_外國短期研習及個人選讀";
                worksheet.Cell("J1").Value = "非學位生_大專附設華語文中心學生";
                worksheet.Cell("K1").Value = "非學位生_大陸研修生";
                worksheet.Cell("L1").Value = "非學位生_馬來西亞華裔青年來台就學輔導及技職研習專班";
                worksheet.Cell("M1").Value = "境外專班";
                //schoolDatas的資料寫入到Excel
                for (int i = 0; i < schoolDatas.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = schoolDatas[i].Year;
                    worksheet.Cell(i + 2, 2).Value = schoolDatas[i].SchoolType;
                    worksheet.Cell(i + 2, 3).Value = schoolDatas[i].SchoolID;
                    worksheet.Cell(i + 2, 4).Value = schoolDatas[i].SchoolName;
                    worksheet.Cell(i + 2, 5).Value = schoolDatas[i].S1;
                    worksheet.Cell(i + 2, 6).Value = schoolDatas[i].S2;
                    worksheet.Cell(i + 2, 7).Value = schoolDatas[i].S3;
                    worksheet.Cell(i + 2, 8).Value = schoolDatas[i].S4;
                    worksheet.Cell(i + 2, 9).Value = schoolDatas[i].S5;
                    worksheet.Cell(i + 2, 10).Value = schoolDatas[i].S6;
                    worksheet.Cell(i + 2, 11).Value = schoolDatas[i].S7;
                    worksheet.Cell(i + 2, 12).Value = schoolDatas[i].S8;
                    worksheet.Cell(i + 2, 13).Value = schoolDatas[i].S9;
                }

                //排序schoolDatas by S1
                List<School> schoolData2 = schoolDatas.Where(x => x.S1 > 0).OrderByDescending(x => x.S1).ToList();

                var worksheet2 = workbook.Worksheets.Add("學位生_正式修讀學位外國生");
                worksheet2.Cell("A1").Value = "學年度";
                worksheet2.Cell("B1").Value = "學校類別";
                worksheet2.Cell("C1").Value = "學校代碼";
                worksheet2.Cell("D1").Value = "學校名稱";
                worksheet2.Cell("E1").Value = "人數";
                //schoolDatas的資料寫入到Excel
                for (int i = 0; i < schoolData2.Count; i++)
                {
                    worksheet2.Cell(i + 2, 1).Value = schoolData2[i].Year;
                    worksheet2.Cell(i + 2, 2).Value = schoolData2[i].SchoolType;
                    worksheet2.Cell(i + 2, 3).Value = schoolData2[i].SchoolID;
                    worksheet2.Cell(i + 2, 4).Value = schoolData2[i].SchoolName;
                    worksheet2.Cell(i + 2, 5).Value = schoolData2[i].S1;
                }


                string FileName = @"d:\School.xlsx";
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
    }
}
