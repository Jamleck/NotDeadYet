﻿using System;

namespace NotDeadYet.Samples.AspNetCore.HealthChecks
{
    public class NeverCouldGetTheHangOfThursdays : IHealthCheck
    {
        public string Description => "This app doesn't work on Thursdays.";

        public void Check()
        {
            // Example: just throw if it's a Thursday
            if (DateTimeOffset.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                throw new HealthCheckFailedException("I never could get the hang of Thursdays.");
            }
            // ... otherwise we're fine.
        }

        public void Dispose()
        {
        }
    }
}