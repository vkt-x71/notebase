using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteBase.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NoteBase.Data.Configurations
{
    public class NotesConfiguration : IEntityTypeConfiguration<Notes>
    {
        public void Configure(EntityTypeBuilder<Notes> builder)
        {
            builder.HasOne(d => d.NoteBook)
                .WithMany(p => p.Notes)
                .HasForeignKey(d => d.NoteBookId)
                .HasConstraintName("FK_notebooks_notes")
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
