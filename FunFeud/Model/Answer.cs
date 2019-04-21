using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunFeud.Model
{
    public class Answer : INotifyPropertyChanged
    {
        public Answer() { }

        public Answer(string description, int points)
        {
            _description = description;
            _points = points;
        }

        private string _description = "Answer";
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

        private int _points = 0;
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                if (_points != value)
                {
                    _points = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _revealed = false;
        public bool Revealed
        {
            get
            {
                return _revealed;
            }
            set
            {
                if (_revealed != value)
                {
                    _revealed = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
