namespace AldeloInfileFel.Domain
{
    public class OrderDetail
    {
        public long OrderId { get; set; }
        public long ItemId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountTaxable { get; set; }
        public string ItemText { get; set; }
        public string ItemDescription { get; set; }
        public bool Bar {  get; set; }
    }
}
