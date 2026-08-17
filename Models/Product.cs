namespace _241230711_PSD_Ung_dung_net_core_dau_tien.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
