using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteBase.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBase.Data.Configurations
{
    public class UserAppConfiguration : IEntityTypeConfiguration<UserApp>
    {
        public void Configure(EntityTypeBuilder<UserApp> builder)
        {
            //builder.Property(x => x.City).HasMaxLength(50);
        }
    }
}