using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.Domain.Entities.Anime
{
    public class AnimeList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Anime_Id { get; set; }

        [Required]
        public string Anime_Name { get; set; }

        [Required]
        public string Anime_Author { get; set; }

        [Required]
        public string Anime_Description { get; set; }

        [Required]
        public string Anime_Type { get; set; }

        public string Anime_Studios { get; set; }

        [DataType(DataType.Date)]
        public string Anime_Date { get; set; }

        public string Anime_Status { get; set; }

        [Required]
        public string Anime_Genre { get; set; }

        public int Anime_Views { get; set; }

        public int Anime_Comment { get; set; }

        [Required]
        public string Anime_Poster { get; set; }

        [Required]
        public string Anime_Image { get; set; } 

        [Required]
        public string Anime_Video { get; set; }

        // Relația cu Comment
        public virtual ICollection<Comment> Comments { get; set; }

        // Relația cu Review
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
