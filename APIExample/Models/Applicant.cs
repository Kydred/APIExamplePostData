namespace APIExample.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string RightProperty { get; set; }

        public List<CompetencyCategory> Competencies { get; set; } = new List<CompetencyCategory> { };
    }

    public class CompetencyCategory
    {
        public string CategoryName { get; set; }

        public string CategoryLevel { get; set; }

        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory> { };
    }

    public class SubCategory
    {
        public string SubCategoryName { get; set; }

        public string SubCategoryLevel { get; set; }

        public List<Competency> Competencies { get; set; } = new List<Competency> { };
    }

    public class Competency
    {
        public string CompetencyName { get; set; }
        public string CompetencyLevel { get; set; }
    }
}