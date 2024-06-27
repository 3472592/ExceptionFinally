using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ExcuseManager
{

    [DataContract(Namespace = "http://www.headfirstlabs.com/ExcuseManager")]
    class Excuse : INotifyPropertyChanged
    {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Results { get; set; }

        [DataMember]
        public DateTimeOffset LastUsedDate { get; set; }

        public Excuse()
        {
            LastUsedDate = DateTimeOffset.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}