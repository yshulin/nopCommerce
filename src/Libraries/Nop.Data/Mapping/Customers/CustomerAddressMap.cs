﻿using LinqToDB.Mapping;
using Nop.Core.Domain.Customers;

namespace Nop.Data.Mapping.Customers
{
    /// <summary>
    /// Represents a customer-address mapping configuration
    /// </summary>
    public partial class CustomerAddressMap : NopEntityTypeConfiguration<CustomerAddressMapping>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityMappingBuilder<CustomerAddressMapping> builder)
        {
            builder.HasTableName(NopMappingDefaults.CustomerAddressesTable);
            builder.HasPrimaryKey(mapping => new { mapping.CustomerId, mapping.AddressId });

            builder.Property(mapping => mapping.CustomerId).HasColumnName("Customer_Id");
            builder.Property(mapping => mapping.AddressId).HasColumnName("Address_Id");

            builder.Ignore(mapping => mapping.Id);
        }

        #endregion
    }
}