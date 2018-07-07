namespace Food
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Size")]
    public partial class Size
    {
        public int ID { get; set; }

        [StringLength(1)]
        public string Description { get; set; }
    }
}
