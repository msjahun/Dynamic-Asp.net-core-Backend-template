﻿using Dau.Core.Domain.BankAccount;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dau.Data.Mapping.BankAccount
{
    class AccountInformationParameterMap : IEntityTypeConfiguration<AccountInformationParameter>
    {
        public void Configure(EntityTypeBuilder<AccountInformationParameter> builder)
        {
            throw new NotImplementedException();
        }
    }
}
