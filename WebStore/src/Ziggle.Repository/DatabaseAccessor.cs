﻿using Ziggle.ProductDatabase;

namespace Ziggle.Repository
{
    public class DatabaseAccessor
    {
        private static readonly ProductDbEntities entities;

        static DatabaseAccessor()
        {
            entities = new ProductDbEntities();
            entities.Database.Connection.Open();
        }

        public static ProductDbEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}