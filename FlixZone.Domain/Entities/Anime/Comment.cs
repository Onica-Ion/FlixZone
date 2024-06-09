using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.Domain.Entities.Anime
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Comment_Id { get; set; }

        public string Content { get; set; }

        [DataType(DataType.Date)]
        public string Comment_Date { get; set; }

        // Foreign key către AnimeList
        public int Anime_Id { get; set; }

        // Relația cu AnimeList
        [ForeignKey("Anime_Id")]
        public virtual AnimeList Anime { get; set; }

        public int User_id { get; set; }
    }

}
