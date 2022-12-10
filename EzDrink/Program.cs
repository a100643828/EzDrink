using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    class Program
    {
        //程式進入點
        [STAThread]
        static void Main(string[] args)
        {
            EzDrinkModel ezDrinkModel = new EzDrinkModel();
            EzDrinkPresentationModel ezPresentationModel = new EzDrinkPresentationModel(ezDrinkModel);
            EzDrinkForm form = new EzDrinkForm(ezDrinkModel, ezPresentationModel);
            Application.Run(form);
        }
    }
}
