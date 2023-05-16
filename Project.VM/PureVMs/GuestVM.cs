﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.PureVMs
{
    public class GuestVM
    {   // Junction Table VM açılmadı, içinde başka özellik olmadığından gerek görülürse DTO içresinde belirtilecek.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TrId { get; set; }
        public string Email { get; set; }
        public string RoomNo { get; set; }
        public string Address { get; set; }
        public int? RoomID { get; set; }
    }
}
