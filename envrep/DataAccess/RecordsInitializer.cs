using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using envrep.Models;

namespace envrep.DataAccess
    {
    public class RecordsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RecordContext>
    {
        protected override void Seed(RecordContext context)
        {
            var entries = new List<RecordPostViewModel>
            {
                new RecordPostViewModel{id=1, temp=20.2, hum=13.7, co2=402 },
                new RecordPostViewModel{id=2, temp=30.1, hum=75.2, co2=532},
                new RecordPostViewModel{id=3, temp=40.7, hum=65.9, co2=374},
                new RecordPostViewModel{id=4, temp=60.3, hum=55.1, co2=688},

            };

            entries.ForEach(s => context.Records.Add(s));
            context.SaveChanges();
            
        }
    }
}