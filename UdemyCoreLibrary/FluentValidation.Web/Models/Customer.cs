using System.ComponentModel.DataAnnotations;

namespace FluentValidation.Web.Models
{
    public class Customer
    {
        public int ID { get; set; }

        //[Required(ErrorMessage ="Name Alanı Boş Geçilemez ")]
        public string Name { get; set; }

        public string EMail { get; set; }

        public int Age { get; set; }

        public DateTime? BirthdayDate { get; set; }

        public IList<Address> Addresses { get; set; }
        //for one - many relation. This is many field.

        public Gender Gender { get; set; }

    }
}
