using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class TblRefTip
    {
        public TblRefTip()
        {
            Photos = new HashSet<Photo>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public short Vsbl { get; set; }
        public short OrdId { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
