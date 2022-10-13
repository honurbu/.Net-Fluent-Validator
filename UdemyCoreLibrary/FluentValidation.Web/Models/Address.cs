namespace FluentValidation.Web.Models
{
    public class Address
    {
        public int ID { get; set; }

        public string Content { get; set; }

        public string Province { get; set; }

        public string Postcode { get; set; }

        public virtual Customer Customer { get; set; }
        //for one - many relation. This is one field.
    }
}
