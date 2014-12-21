using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace DataLayer
{
    //DbContext class - what is going to interact with da DB behind the scene
    public class Context : DbContext
    {
        //install da entity framework, then use da above namespace, add reference to ur Entity package(Library)       

        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<User> Users { get; set; }
        


        

        
        

    }
}
