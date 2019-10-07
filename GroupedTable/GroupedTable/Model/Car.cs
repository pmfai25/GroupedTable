namespace GroupedTable.Model
{
    public class Car
    {
        public string Model { get; set; }
        public string EngineCapacity { get; set; }
        public string GroupId { get; internal set; }
    }
}