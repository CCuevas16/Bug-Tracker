﻿using BugTracker.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace BugTracker.Data.Models
{
    public class TicketModel : ICreatable, IModifiable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public List<UserModel> Assignments { get; set; }
        public List<UserModel> Followers { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserModel CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public UserModel ModifiedBy { get; set; }
        public DateTime LastModified { get; set; }
    }
}
