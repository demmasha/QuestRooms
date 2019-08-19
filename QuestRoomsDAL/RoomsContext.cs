namespace QuestRoomsDAL
{
    using QuestRoomsDAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RoomsContext : DbContext
    {      public RoomsContext()
            : base("name=RoomsContext")
        {
        } 
      public DbSet<Company> Companies { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
       
    }   
}