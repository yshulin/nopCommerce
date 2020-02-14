﻿using LinqToDB.Mapping;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Mapping.Catalog
{
    /// <summary>
    /// Represents a category template mapping configuration
    /// </summary>
    public partial class CategoryTemplateMap : NopEntityTypeConfiguration<CategoryTemplate>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityMappingBuilder<CategoryTemplate> builder)
        {
            builder.HasTableName(nameof(CategoryTemplate));

            builder.Property(template => template.Name).HasLength(400).IsNullable(false);
            builder.Property(template => template.ViewPath).HasLength(400).IsNullable(false);
            builder.Property(categorytemplate => categorytemplate.DisplayOrder);
        }

        #endregion
    }
}