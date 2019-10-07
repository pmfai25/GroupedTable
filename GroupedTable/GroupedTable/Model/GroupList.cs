using System.Collections.ObjectModel;

namespace GroupedTable.Model
{
    public class GroupList : ObservableCollection<Car>
    {
        public string Header { get; set; }
        public string GroupId { get; set; }
    }
}