﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TvPlays.Models
{
    public class Clips
    {
        public int ID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        [Range(typeof(TimeSpan), "00:00:00", "24:00:00")]
        [Display(Name = "Duração do Clip")]
        public TimeSpan TimeClip { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Titulo do  Clip")]
        public string TitleClip { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Upload")]
        public DateTime DateClip { get; set; }

        [Required]
        [Display(Name = "Diretoria do Clip")]
        public string PathClip { get; set; }

        //Foreign Key para a tabela Utilizadores
        [ForeignKey("Utilizadores")]
        public int UtilizadoresFK { get; set; }
        public Utilizadores Utilizadores { get; set; }

        //ICollection de Comentatiros
        public ICollection<Comments> ListComments { get; set; }


    }
}