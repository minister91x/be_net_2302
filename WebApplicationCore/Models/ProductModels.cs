namespace WebApplicationCore.Models
{

    public class ProductModels
    {
        public string? MaSP { get; set; }
        public string? TenSP { get; set; }
        public string? DonViTinh { get; set; }
        public int DonGia { get; set; }
    }

    public class ShoppingCartModel
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quality { get; set; }
        public int CustomPrice { get; set; }
    }
}
