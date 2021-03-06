namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_blog")]
    public class Blog : IEntityWithStatus
    {
        [Key]
        [Column("blog_id")]
        public int Id { get; protected set; }

        [StringLength(255)]
        [Column("image")]
        public string Image { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        [Column("date_available", TypeName = "date")]
        public DateTime DateAvailable { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public virtual ICollection<Store> Stores { get; set; } = new HashSet<Store>();

        public virtual ICollection<BlogDescription> Descriptions { get; set; } = new HashSet<BlogDescription>();

        public virtual ICollection<BlogToLayout> Layouts { get; set; } = new HashSet<BlogToLayout>();
    }
}
