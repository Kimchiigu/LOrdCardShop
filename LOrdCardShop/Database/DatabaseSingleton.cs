using LOrdCardShop.Model;

namespace LOrdCardShop.Database
{
    public class DatabaseSingleton
    {
        public static LordCardShopDatabaseEntities db = null;

        private DatabaseSingleton() { }

        public static LordCardShopDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new LordCardShopDatabaseEntities();
            }
            return db;
        }
    }
}