using System.Linq;
using Final.Repository;

namespace Final.Business
{
    public interface ISchoolManager
    {
        SchoolModel[] ForClass(int classId);
    }

    public class SchoolModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class SchoolManager : ISchoolManager
    {
        private readonly ISchoolRepository schoolRepository;

        public SchoolManager(ISchoolRepository schoolRepository)
        {
            this.schoolRepository = schoolRepository;
        }

        public SchoolModel[] ForClass(int classId)
        {
            return schoolRepository.ForClass(classId).Select(t =>
                            new SchoolModel
                            {
                                Id = t.Id,
                                Name = t.Name,
                                Password = t.Password,
                                Price = t.ClassPrice,
                                Description = t.ClassDescription
                               
                                
                            })
                            .ToArray();
        }
    }
}
