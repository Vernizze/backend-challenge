﻿using System;

namespace backend_challenge_domain_datatypes.Entities
{
    public class ViewSellerFullData
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public bool Deleted { get; set; }
        public Guid PersonId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
