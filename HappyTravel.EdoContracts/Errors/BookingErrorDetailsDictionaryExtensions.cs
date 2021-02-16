using System;
using System.Collections.Generic;
using HappyTravel.EdoContracts.Accommodations.Enums;

namespace HappyTravel.EdoContracts.Errors
{
    public static class BookingErrorDetailsDictionaryExtensions
    {
        public static void AddBookingFailureCode(this IDictionary<string, object> extensions, BookingFailureCodes failureCode)
        {
            if (extensions.TryGetValue(BookingFailureCodeKey, out _))
                throw new Exception($"Key {failureCode} already exists");

            extensions[BookingFailureCodeKey] = failureCode;
        }


        public static bool TryGetBookingFailureCode(this IDictionary<string, object> extensions, out BookingFailureCodes failureCode)
        {
            if (!extensions.TryGetValue(BookingFailureCodeKey, out var code))
            {
                failureCode = BookingFailureCodes.Unknown;
                return false;
            }

            failureCode = (BookingFailureCodes) code;
            return true;
        }
        
        
        private const string BookingFailureCodeKey = "booking-failure-code";
    }
}