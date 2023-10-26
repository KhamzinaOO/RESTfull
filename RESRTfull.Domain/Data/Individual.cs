namespace RESRTfull.Domain
{
    public class Individual
    {
        public Guid ID { get; set; }

        public Info Information { get; set; } = new Info();
        public List<Job> Jobs { get; set; } = new List<Job>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<Document> Documents { get; set; } = new List<Document>();
        public DocForeignPassport? ForeignPassport { get; set; } = new DocForeignPassport();
        public DocInternationalPassport? InternationalPassport { get; set;} = new DocInternationalPassport();
        public DocRussianPassport? RussianPassport { get;set; } = new DocRussianPassport();
        public Address PersonAddress { get; set; } = new Address();

    }
}
