namespace CuaHangDienTu.Models
{
    public class OrderDTO
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string DepartmentName { get; set; }
        public int TotalValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
