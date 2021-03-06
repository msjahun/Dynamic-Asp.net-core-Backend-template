﻿using Dau.Core.Domain.BankAccount;
using System;
using System.Collections.Generic;

namespace Dau.Core.Domain.DormitoryOld
{
    public partial class DormitoryBankAccountTable : BaseEntity
    {
        public DormitoryBankAccountTable()
        {
            BankCurrencyTable = new HashSet<BankCurrencyTable>();
        }

      
        public long DormitoryId { get; set; }
        public string BankName { get; set; }

        public DormitoriesTable Dormitory { get; set; }
        public ICollection<BankCurrencyTable> BankCurrencyTable { get; set; }
    }
}
