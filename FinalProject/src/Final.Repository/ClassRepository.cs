using System.Linq;

namespace Final.Repository
{
    public interface IClassRepository
    {
        ClassModel[] Classes { get; }
        ClassModel Class(int classId);
    }

    public class ClassModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ClassRepository : IClassRepository
    {
        public ClassModel[] Classes
        {
            get
            {
                return DatabaseAccessor.Instance.Classes
                                               .Select(t => new ClassModel { Id = t.ClassId, Name = t.ClassName })
                                               .ToArray();
            }
        }

        public ClassModel Class(int classId)
        {
            var classes = DatabaseAccessor.Instance.Classes // if ERROR rename classes to something else
                                                   .Where(t => t.ClassId == classId)
                                                   .Select(t => new ClassModel { Id = t.ClassId, Name = t.ClassName })
                                                   .First();
            return classes; // AND THEN also rename this classes to the same thing
        }
    }
}