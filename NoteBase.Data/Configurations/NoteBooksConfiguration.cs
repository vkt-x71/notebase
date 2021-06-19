using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteBase.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Data.Configurations
{
    public class NoteBooksConfiguration : IEntityTypeConfiguration<NoteBooks>
    {
        public void Configure(EntityTypeBuilder<NoteBooks> builder)
        {
            builder.HasOne(d => d.UserApp)
                .WithMany(p => p.NoteBooks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_userapp_notebooks")
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
