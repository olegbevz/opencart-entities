namespace OpenCart.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_attribute")]
    public class Attribute
    {
        [Key, Column("attribute_id")]
        public int Id { get; protected set; }

        [Column("attribute_group_id")]
        public int AttributeGroupId { get; set; }

        public virtual AttributeGroup AttributeGroup { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        public virtual ICollection<AttributeDescription> Descriptions { get; set; } = new HashSet<AttributeDescription>();
    }
}
