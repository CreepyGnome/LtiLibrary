﻿namespace Provider.Models
{
    public class PairedUser
    {
        public int PairedUserId { get; set; }
        public int ConsumerId { get; set; }
        public string ConsumerUserId { get; set; }
        public virtual User User { get; set; }
    }
}