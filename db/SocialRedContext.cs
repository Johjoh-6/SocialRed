using Microsoft.EntityFrameworkCore;
using SocialRed.Models;


namespace SocialRed.Database
   {
     public class SocialRedContext : DbContext
     {
      public DbSet<Users> UsersList { get; set; }
      
       public SocialRedContext(DbContextOptions<SocialRedContext> options) : base(options) { }
       
     }
}