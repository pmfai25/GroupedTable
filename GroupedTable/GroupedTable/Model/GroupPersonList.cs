using System.Collections.ObjectModel;

namespace GroupedTable.Model
{
    public class GroupPersonList : ObservableCollection<Car>
    {
        public string Header { get; set; }
    }
}