﻿using NServiceBus;
using System;

namespace Messages
{
    public class PlaceOrder:ICommand
    {
        public Guid OrderId { get; set; }

        public override string ToString()
        {
            return $"{nameof(PlaceOrder)} #{OrderId}";
        }
    }
}
