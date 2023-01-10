namespace AdminPanelCRUD.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int SliderId { get; set; }
        public string ImgUrl { get; set; }
        public string ImgFile { get; set; }
        public Slider Slider { get; set; }

    }
}
