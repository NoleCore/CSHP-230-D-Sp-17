using System.Linq;

namespace Final.Repository
{
    public interface ISchoolRepository
    {
        SchoolModel[] ForClass(int classId);
    }

    public class SchoolModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }
    }

    public class SchoolRepository:ISchoolRepository
    {
        public SchoolModel[] ForClass(int classId)
        {
            return DatabaseAccessor.Instance.Classes.First(t => t.ClassId == classId)
                                  .Users.Select(t =>
                                        new SchoolModel
                                        {
                                            Id = t.UserId,
                                            Name = t.UserEmail,
                                            Password = t.UserPassword,
                                            Admin = t.UserIsAdmin
                                        })
            .ToArray();
        }
    }
}
