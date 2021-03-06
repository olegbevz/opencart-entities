namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_download_description")]
    public class DownloadDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("download_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DownloadId { get; set; }

        public virtual Download Download { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }
    }
}
