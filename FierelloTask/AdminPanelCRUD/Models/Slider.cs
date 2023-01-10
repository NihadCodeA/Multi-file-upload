using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanelCRUD.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [StringLength(maximumLength:25)]
        public string FirstTitle { get; set; }
        [StringLength(maximumLength:25)]
        public string SecondTitle { get; set; }
        [StringLength(maximumLength:250)]
        public string Description { get; set; }
       
        public List<Image>? ImgUrls { get; set; }

        [NotMapped]
        public List<IFormFile> ImgFiles { get; set; }
    }
}
