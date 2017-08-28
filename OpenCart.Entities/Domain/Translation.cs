namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_translation")]
    public class Translation
    {
        [Key]
        public int translation_id { get; set; }

        public int store_id { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(64)]
        public string route { get; set; }

        [Required]
        [StringLength(64)]
        public string key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }
    }
}