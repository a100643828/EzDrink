using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EzDrink
{
    public class LoadFile
    {
        OpenFileDialog _file = new OpenFileDialog();
        StreamReader _readFile;
        const string TITLE = "Select file";
        const string DIRECTORY = ".\\";
        const string FILTER = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        const string BIG5 = "big5";

        //取得檔案路徑
        public string GetLoadFilePath(string extension)
        {
            SetLoadFile();
            try
            {
                if (_file.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(_file.FileName) == extension)
                    {
                        SetFileReader();
                        return _file.FileName;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return null; //開檔失敗
            }
        }

        //從檔案取得飲料資料
        public Drink GetDrinkAndPrice()
        {
            if (_file.FileName != null)
            {
                string _commodityAndPirce = _readFile.ReadLine();
                if (_commodityAndPirce == null)
                    return null; //檔案無資料
                else
                {
                    const char SPACE = ' ';
                    string[] _commodityAndPirceSplit = _commodityAndPirce.Split(SPACE);
                    return new Drink(_commodityAndPirceSplit[0], Convert.ToInt32(_commodityAndPirceSplit[1]));
                }
            }
            else
                return null; //無檔案
        }

        //從檔案取得加料資料
        public DrinkAddition GetAdditionAndPrice()
        {
            if (_file.FileName != null)
            {
                string _commodityAndPirce = _readFile.ReadLine();
                if (_commodityAndPirce == null)
                    return null; //檔案無資料
                else
                {
                    const char SPACE = ' ';
                    string[] _commodityAndPirceSplit = _commodityAndPirce.Split(SPACE);
                    return new DrinkAddition(_commodityAndPirceSplit[0], Convert.ToInt32(_commodityAndPirceSplit[1]));
                }
            }
            else
                return null; //無檔案
        }

        //設定讀檔
        private void SetLoadFile()
        {
            _file.Title = TITLE;
            _file.InitialDirectory = DIRECTORY;
            _file.Filter = FILTER;
        }

        //設定檔案reder
        private void SetFileReader()
        {
            System.Text.Encoding _encode = System.Text.Encoding.GetEncoding(BIG5);//BIG5編碼開檔
            _readFile = new StreamReader(_file.FileName, _encode);
        }

        //假的開檔，for test
        public string TestGetLoadFilePath(string path)
        {
            if (path != null && path != "")
                return path;
            else
                return null;
        }
    }
}
