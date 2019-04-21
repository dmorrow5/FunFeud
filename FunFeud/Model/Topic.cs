using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunFeud.Model
{
    public class Topic : INotifyPropertyChanged
    {
        public Topic()
        {
            Answer1 = new Answer();
            Answer2 = new Answer();
            Answer3 = new Answer();
            Answer4 = new Answer();
            Answer5 = new Answer();
            Answer6 = new Answer();
            Answer7 = new Answer();
            Answer8 = new Answer();
        }

        private string _description = "Name";
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!_description.Equals(value))
                {
                    _description = value;
                    OnPropertyChanged();

                }
            }
        }

        public Answer Answer1 { get; set; }
        public Answer Answer2 { get; set; }
        public Answer Answer3 { get; set; }
        public Answer Answer4 { get; set; }
        public Answer Answer5 { get; set; }
        public Answer Answer6 { get; set; }
        public Answer Answer7 { get; set; }
        public Answer Answer8 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
