using TargetSettingTool.Domain.Common;
using System;
using System.Collections.Generic;

namespace TargetSettingTool.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }

    }
}
