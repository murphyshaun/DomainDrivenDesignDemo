﻿using Domain.Common.Models;

namespace Domain.HostAggregate.ValueObjects
{
    public sealed class HostId : ValueObject
    {
        public Guid Value { get; set; }

        private HostId(Guid value)
        {
            Value = value;
        }

        public static HostId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static HostId Create(string hostId)
        {
            return new HostId(Guid.Parse(hostId));
        }
        
        public static HostId Create(Guid value)
        {
            return new HostId(value);
        }
    }
}