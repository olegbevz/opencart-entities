namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_voucher_theme")]
    public class VoucherTheme
    {
        [Key]
        [Column("voucher_theme_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(255)]
        [Column("image")]
        public string Image { get; set; }

        public virtual ICollection<OrderVoucher> Orders { get; set; } = new HashSet<OrderVoucher>();

        public virtual ICollection<Voucher> Vouchers { get; set; } = new HashSet<Voucher>();

        public virtual ICollection<VoucherThemeDescription> Descriptions { get; set; } = new HashSet<VoucherThemeDescription>();
    }
}
