﻿using ShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.HasOne(c => c.Product).WithMany(p => p.Carts).HasForeignKey(c => c.ProductId);
            builder.HasOne(c => c.AppUser).WithMany(u => u.Carts).HasForeignKey(c => c.UserId);
        }
    }
}
