namespace CuaHangDienTu.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string DepartmentId { get; set; }
        public int TotalValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
