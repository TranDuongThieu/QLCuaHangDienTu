namespace CuaHangDienTu.Models
{
    public class OrderDetailsDTO
    {
        public string OrderId { get; set; }
        public string ProductItemId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ProductImagePath { get; set; }
    }
}
