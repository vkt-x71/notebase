using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using NoteBase.Core.Models;

namespace NoteBase.Data
{
    public class NoteBaseIdentityContext : DbContext
    {
        
        public NoteBaseIdentityContext(DbContextOptions<NoteBaseIdentityContext> options)
            : base(options)
        {
        }
        public DbSet<NoteBooks> NoteBooks { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<NoteTags> NoteTags { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);
        }
    }
}
