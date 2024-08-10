namespace BlazorDynamicComponents2
{
    public class ProductState
    {
        public Action<Dictionary<string, object>>? ActionWithProduct { get; set; }
    }
}
