using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OutOfLife.Models.Acess;
using System;
using System.Collections.Generic;
using System.Text;

namespace OutOfLife.Repositories.DataEstructure.Maps.Acess
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(150);
            builder.Property(t => t.Password).IsRequired();
            builder.Property(t => t.Email).IsRequired();
        }
    }
}
