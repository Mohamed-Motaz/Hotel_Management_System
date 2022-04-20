using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Database
{
    using Backend.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Data.SQLite;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AjnaWindowsClient.App
    {
        public class Context : DbContext
        {
            public Context() :
                base(new SQLiteConnection()
                {
                    ConnectionString = new SQLiteConnectionStringBuilder()
                    {
                        DataSource = Apphost.DB_PATH,
                        ForeignKeys = true
                    }.ConnectionString
                }, true)
            {
            }

            public static void SetInitializeNoCreate()
            {
                //prevent db from getting dropped and recreated
                Database.SetInitializer<Context>(null);
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }

            //all the dbs
            public DbSet<BookingInformation> BookingInformation { get; set; }



        }
    }

}