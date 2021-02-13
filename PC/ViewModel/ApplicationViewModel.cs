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
                return _addCommand??
                       (_addCommand = new RelayCommand(obj =>
                       {

                           //SQLiteConnection db = new SQLiteConnection("Data Source =.\\database.db; Version = 3; New = True; Compress = True;");
                           //db.Open();
                           //    SQLiteCommand command =
                           //        new SQLiteCommand(
                           //            "INSERT INTO Information (NAME, START_DATE, END_DATE, FREQUENCY) VALUES('asdasd', 'startdate', 'enddate', 3);",
                           //            db);
                           //    command.ExecuteNonQuery();


                           using (ApplicationContext db = new ApplicationContext())
                           {
                               db.Information.Load();
                               db.Information.Add(new Medicine(Medicine.Name, 2, Medicine.Start_Date, "1231,1323,2"));
                               db.SaveChanges();
                           }

                       }));
            }
        }
    }
}