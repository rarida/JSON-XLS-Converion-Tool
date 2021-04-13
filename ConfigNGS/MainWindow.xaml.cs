using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace ConfigNGS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //jsonObject jsonObject;

        jsonObject.Root root;



        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            CreateSpreadSheet();


        }

        private void FolderButton_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader(@"C:\Users\jimja\Desktop\SpreadSheets\new.json"))
            {
                string json = r.ReadToEnd();

                //string json = @"{'Email': 'james@example.com','Active': true,'CreatedDate': '2013-01-20T00:00:00Z','Roles': ['User','Admin']}";

                //jo = JsonConvert.DeserializeObject<jsonObject>(json);

                //DateInfo.Text = jo.Email;

                root = JsonConvert.DeserializeObject<jsonObject.Root>(json);

                //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

                //jsonObject obj = JsonConvert.DeserializeObject<jsonObject>(json);

                DateInfo.Text = root.kits[0].loci.




                //List<jsonObject> items = JsonConvert.DeserializeObject<List<jsonObject>>(json);
                //jsonObject item = JsonConvert.DeserializeObject<jsonObject>(json);


                //DateInfo.Text = item.testString;
            }

            //string json = @"{'Email': 'james@example.com','Active': true,'CreatedDate': '2013-01-20T00:00:00Z','Roles': ['User','Admin']}";

            //jsonObject jo = JsonConvert.DeserializeObject<jsonObject>(json);

            //DateInfo.Text = jo.Email;
        }
        

        void CreateSpreadSheet()
        {
            string spreadsheetPath = "C:\\Users\\jimja\\Desktop\\SpreadSheets\\New.xlsx";

            ExcelPackage ExcelPkg = new ExcelPackage();
            ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");
            ExcelWorksheet wsSheet2 = ExcelPkg.Workbook.Worksheets.Add("Sheet2");


            //wsSheet1.Cells[4, 1].Value = jo.Email;

            ExcelPkg.SaveAs(new FileInfo(spreadsheetPath));
        }

    }
}
