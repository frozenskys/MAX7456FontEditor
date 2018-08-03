using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MaxFontEditor.Data
{
    public class VersionInfo 
    {
        public VersionInfo()
        {
            Info = new ObservableCollection<InfoPair>();
        }

        public ObservableCollection<InfoPair> Info { get; }
    }

    public class InfoPair
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

}

