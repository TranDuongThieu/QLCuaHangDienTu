namespace CuaHangDienTu.Models
{
    public class ImportOrderModel
    {
        public string ImportOrderId { get; set; }
        public string DistributorId { get; set; }
        public string DepartmentId { get; set; }
        public int TotalValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
