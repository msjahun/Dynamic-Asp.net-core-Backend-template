﻿using Dau.Core.Domain.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dau.Data.Mapping.API
{
    public class APISettingsMap : IEntityTypeConfiguration<APISettings>
    {
        public void Configure(EntityTypeBuilder<APISettings> builder)
        {
            throw new NotImplementedException();
        }
    }
}
