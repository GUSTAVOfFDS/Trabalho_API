using System.ComponentModel.DataAnnotations.Schema;

namespace Tabalho_so2.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
