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
            
            extensions[BookingFailureCodeKey] = (int) failureCode;
        }


        public static bool TryGetBookingFailureCode(this IDictionary<string, object> extensions, out BookingFailureCodes failureCode)
        {
            if (!extensions.TryGetValue(BookingFailureCodeKey, out var obj))
            {
                failureCode = BookingFailureCodes.Unknown;
                return false;
            }

            // During deserialization of ProblemDetails code is deserialized as 'long' so we need to convert it to int explicitly
            var code = Convert.ToInt32(obj);
            if (!Enum.IsDefined(typeof(BookingFailureCodes), code))
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