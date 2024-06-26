using System.ComponentModel.DataAnnotations.Schema;





namespace Trabalho_so2.Model
{
    [Table("person")]
    [Table("address")]

    public class Person
    {

        [Column("id")]

        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
    }
}
