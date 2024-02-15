namespace KitapEvi.Models
{
    public class KitapKategori
    {
        public int kategoriId { get; set; }
        public string kategoriName { get; set; }
        List<KitapModel>kitapListesi = new List<KitapModel>();
    }
}
