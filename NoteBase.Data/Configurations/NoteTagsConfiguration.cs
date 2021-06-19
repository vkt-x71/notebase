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
    public class NoteTagsConfiguration : IEntityTypeConfiguration<NoteTags>
    {
        public void Configure(EntityTypeBuilder<NoteTags> builder)
        {
            builder.HasOne(d => d.Tag)
                .WithMany(p => p.NoteTags)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK_tags_notetags")
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(d => d.Note)
                .WithMany(p => p.NoteTags)
                .HasForeignKey(d => d.NoteId)
                .HasConstraintName("FK_notes_notetags")
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
