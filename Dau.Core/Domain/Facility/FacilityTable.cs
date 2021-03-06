﻿//using Dau.Core.Domain.Room;
using System;
using System.Collections.Generic;

namespace Dau.Core.Domain.Facility
{
    public partial class FacilityTable : BaseEntity
    {
        public FacilityTable()
        {
            FacilityOption = new HashSet<FacilityOption>();
            FacilityTableTranslation = new HashSet<FacilityTableTranslation>();
         //   RoomFacility = new HashSet<RoomFacility>();
        }

      
        public string FacilityIconUrl { get; set; }

        public ICollection<FacilityOption> FacilityOption { get; set; }
        public ICollection<FacilityTableTranslation> FacilityTableTranslation { get; set; }
       // public ICollection<RoomFacility> RoomFacility { get; set; }
    }
}
