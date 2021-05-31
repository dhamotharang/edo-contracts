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


        public static bool TryGetBookingFailureCode(this IDictionary<string, object> extensions, out int failureCode)
        {
            if (!extensions.TryGetValue(BookingFailureCodeKey, out var obj) || 
                !(obj is int code) || 
                !Enum.IsDefined(typeof(BookingFailureCodes), code)) 
            {
                failureCode = (int) BookingFailureCodes.Unknown;
                return false;
            }  
            failureCode = code;
            
            return true;
        }
        
        
        private const string BookingFailureCodeKey = "booking-failure-code";
    }
}