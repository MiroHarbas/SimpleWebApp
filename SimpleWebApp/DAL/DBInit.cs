
using SimpleWebApp.Models;
using System.Reflection;

namespace SimpleWebApp.DAL
{
    public class DBInit
    {
        public static void initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.entries.Any()) { return; }

            var entries = new Entry[]
            {
                new Entry{Title="First", Desc="This is the first entry." },
                new Entry{Title="Second", Desc="This is the second entry." },
                new Entry{Title="Third", Desc="This is the third entry." },
                new Entry{Title="Fourth", Desc="This is the fourth entry." },

            };
            foreach ( var entry in entries )
            {
                context.entries.Add( entry );
            }

            context.SaveChanges();

        }
    }
}
