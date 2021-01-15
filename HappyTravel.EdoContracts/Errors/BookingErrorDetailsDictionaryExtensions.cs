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


        public static BookingFailureCodes GetBookingFailureCode(this IDictionary<string, object> extensions)
        {
            return (BookingFailureCodes) extensions[BookingFailureCodeKey];
        }
        
        
        private const string BookingFailureCodeKey = "BookingFailureCode";
    }
}