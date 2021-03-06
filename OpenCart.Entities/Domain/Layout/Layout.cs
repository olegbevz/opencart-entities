using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_layout")]
    public class Layout : IEntityWithName
    {
        [Key, Column("layout_id")]
        public int Id { get; protected set; }

        [Required, StringLength(64), Column("name")]
        public string Name { get; set; }

        public virtual ICollection<BlogToLayout> Blogs { get; set; } = new HashSet<BlogToLayout>();

        public virtual ICollection<CategoryToLayout> Categories { get; set; } = new HashSet<CategoryToLayout>();

        public virtual ICollection<InformationToLayout> Informations { get; set; } = new HashSet<InformationToLayout>();

        public virtual ICollection<LayoutModule> Modules { get; set; } = new HashSet<LayoutModule>();

        public virtual ICollection<LayoutRoute> Routes { get; set; } = new HashSet<LayoutRoute>();

        public virtual ICollection<ProductToLayout> Products { get; set; } = new HashSet<ProductToLayout>();
    }
}
