using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.Domain.Entities.Anime
{
    public class Reviews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Review_Id { get; set; }

        public float Rating { get; set; }

        [DataType(DataType.Date)]
        public string Review_Date { get; set; }

        // Foreign key către AnimeList
        public int Anime_Id { get; set; }

        // Relația cu AnimeList
        [ForeignKey("Anime_Id")]
        public virtual AnimeList Anime { get; set; }

        public int User_id { get; set; }
    }

}
