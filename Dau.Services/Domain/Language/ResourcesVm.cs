﻿//using Dau.Core.Domain.Language;
namespace Dau.Services.Languages
{
    public class ResourcesVm
    {
        public long ResourceId { get; set; }
        public bool Success { get; set; }
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }
        public long LanguageId { get; set; }
    }
}