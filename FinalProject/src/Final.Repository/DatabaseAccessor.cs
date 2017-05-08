using Final.ProductDatabase;

namespace Final.Repository
{
    public class DatabaseAccessor
    {
        private static readonly minicstructorEntities entities;

        static DatabaseAccessor()
        {
            entities = new minicstructorEntities();
            entities.Database.Connection.Open();
        }

        public static minicstructorEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}