﻿namespace MiniMe.AimeDb.Protocols
{
    internal abstract class AimeRequest
    {
        public string GameId { get; set; }
        
        public string KeyChipId { get; set; }
    }
}
