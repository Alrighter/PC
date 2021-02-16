using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Emit;
using PC.Model;

namespace PC.ViewModel
{
    public class ApplicationViewModel : BaseViewModel
    {
        private Medicine _medicine = new Medicine();
        private RelayCommand _addCommand;
        public Medicine Medicine
        {
            get { return _medicine; }
            set { _medicine = value; }
        }



        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                       (_addCommand = new RelayCommand(obj =>
                       {

                           using (ApplicationContext db = new ApplicationContext())
                           {
                               db.Information.Load();
                               db.Information.Add(new Medicine(Medicine.Name, Medicine.Frequency, Medicine.Start_Date,
                                   Medicine.End_Date));
                               db.SaveChanges();
                           }

                       }));
            }
        }
    }
}