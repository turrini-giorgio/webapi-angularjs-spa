﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using ResourceMetadata.Model;

namespace ResourceMetadata.Data.Configurations
{
    internal class ResourceConfiguration : EntityTypeConfiguration<Resource>
    {
        public ResourceConfiguration()
        {
            HasRequired(r => r.Location).WithMany().HasForeignKey(r => r.LocationId).WillCascadeOnDelete(true);
            //HasMany(t => t.Activities).WithRequired(activity => activity.Resource).HasForeignKey(a => a.ResourceId).WillCascadeOnDelete(true);
        }


    }
}
