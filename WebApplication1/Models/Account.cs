namespace WebApplication1.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string Tuoi { get; set; }
        public string TieuSu { get; set; }
        public string VaiTro { get; set; }
        public bool SoThich { get; set; }
    }
}
