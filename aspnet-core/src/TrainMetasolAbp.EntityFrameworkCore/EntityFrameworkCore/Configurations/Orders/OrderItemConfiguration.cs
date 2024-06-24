﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainMetasolAbp.Orders;

namespace TrainMetasolAbp.EntityFrameworkCore.Configurations.Orders
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(TrainMetasolAbpConsts.DbTablePrefix + "OrderItems");
            builder.HasKey(x => new { x.ProductId, x.OrderId });
            builder.Property(x => x.SKU)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .IsRequired();
        }
    }
}
