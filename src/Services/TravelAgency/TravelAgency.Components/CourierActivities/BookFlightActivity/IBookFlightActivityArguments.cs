﻿using System;

namespace TravelAgency.Components.CourierActivities.BookFlightActivity
{
    public interface IBookFlightActivityArguments
    {
        Guid AirportId { get;  }
        DateTime DepartureDate { get; }
        Guid DestinationId { get; }
        DateTime ReturnDate { get; }
        Guid ReturnId { get; }
    }
}
