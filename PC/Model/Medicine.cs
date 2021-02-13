using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace PC.Model
{

    [Table("Information")]
    public class Medicine : INotifyPropertyChanged
    {
        
        #region Fields
        [Key]
        public int ID { get; set; }
        private string _name;
        private int _frequency;
        private string _startDate;
        private string _endDate;

        #endregion

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Frequency
        {
            get { return _frequency;}
            set
            {
                _frequency = value;
                OnPropertyChanged("Frequency");
            }
        }

        public string Start_Date
        {
            get { return  _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged("Start date");
            }
        }

        public string End_Date
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged("End date");
            }
        }


        public Medicine() {}

        public Medicine(string name, int frequency, string startDate, string endDate)
        {
            this._name = name;
            this._frequency = frequency;
            this._startDate = startDate;
            this._endDate = endDate;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}