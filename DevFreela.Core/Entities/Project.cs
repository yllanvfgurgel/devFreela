using DevFreela.Core.Enums;

namespace DevFreela.Core.Entities
{
    public class Project : Entity
    {
        public Project(string title, string description, int idClient, int idFreelancer, decimal? totalCost, List<ProjectComment> comments)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal? TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; set; }
        public List<ProjectComment> Comments { get; set; }
    }
}