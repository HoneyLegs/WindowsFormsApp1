using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Classes;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace WinFormsApp1.FileHelper
{
    class ExcelHelper
    {
        public List<People> GetPeoples(string FilePath)
        {
            Debug.WriteLine(FilePath);
            if (FilePath == "")
                return new List<People>();
            var fi = new FileInfo(FilePath);
            List<People> peoples = new List<People>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var p = new ExcelPackage(fi))
            {
                var ws = p.Workbook.Worksheets.First();
                int i = 2;
                while(ws.Cells[i,4].Value != null)
                {
                    var tempPeople = new People();
                    tempPeople.Surname = ws.Cells[i, 4].Value.ToString();
                    tempPeople.Name = ws.Cells[i, 5].Value.ToString();
                    tempPeople.Team = ws.Cells[i, 39].Value.ToString();
                    tempPeople.Age = ws.Cells[i, 15].Value.ToString();
                    peoples.Add(tempPeople);
                    //tempPeople.PrintDebug();
                    i++;
                }
            }
            return peoples;
        }
        public List<People> GetPeoples()
        {
            return GetPeoples(GetPath());
        }

        public void Save(List<People> peoples, string FilePath)
        {
            if (FilePath == "")
                return;
            var fi = new FileInfo(FilePath);
            Debug.WriteLine(fi.IsReadOnly);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var p = new ExcelPackage(fi))
            {
                var ws = p.Workbook.Worksheets.First();
                int i = 2;
                while (ws.Cells[i, 4].Value != null)
                {
                    KeyValuePair<string, int> address = findAddress(peoples,
                                                                    ws.Cells[i, 4].Value.ToString(),
                                                                    ws.Cells[i, 5].Value.ToString());
                    if(address.Value != 0 && address.Key != null)
                    {
                        ws.Cells[i, 17].Value = address.Key;
                        ws.Cells[i, 18].Value = address.Value;
                    }
                    i++;
                }
                p.Save();
            }
        }

        private KeyValuePair<string,int> findAddress(List<People> peoples, string suraname, string name)
        {
            foreach(People people in peoples)
            {
                if (people.Surname == suraname && people.Name == name)
                {
                    return new KeyValuePair<string,int>(people.House,people.RoomID);
                }
            }
            return new KeyValuePair<string, int>(null, 0);
        }
        public string GetPath()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                FilterIndex = 0,
                RestoreDirectory = true,
                InitialDirectory = "%USERPROFILE%/Desktop"
            };
            openFileDialog.ShowDialog();
            Debug.WriteLine(openFileDialog.FileName);
            return openFileDialog.FileName;
        }
    }
}
