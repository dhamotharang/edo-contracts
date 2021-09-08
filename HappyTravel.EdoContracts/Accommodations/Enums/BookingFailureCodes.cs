namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    public enum BookingFailureCodes
    {
        Unknown = 0,
        /// <summary>
        /// For validation errors on connector.
        /// Supplier booking request was not executed
        /// </summary>
        ConnectorValidationFailed = 10,
        /// <summary>
        /// Not found valuation result to use in booking.
        /// May be caused by incorrect request or cache expiration.
        /// Supplier booking request was not executed 
        /// </summary>
        ValuationResultNotFound = 20,
        /// <summary>
        /// Error in prebooking operations.
        /// Some supplier have 2-step booking procedure, when actual booking is made during the 2-nd step.
        /// Actual supplier booking request was not executed
        /// </summary>
        PreBookingFailed = 30,
        /// <summary>
        /// Validation error is returned from supplier API and we are sure that booking was not done.
        /// Supplier booking request was executed but did not succeed.
        /// </summary>
        SupplierValidationFailed = 40,
        /// <summary>
        /// Booking was rejected supplier API and we are sure that booking was not done.
        /// Supplier booking request was executed but did not succeed.
        /// </summary>
        SupplierRejected = 50,
        /// <summary>
        /// Timeout awaiting for response on supplier end.
        /// Supplier may have made the booking with the hotel.
        /// Supplier booking request was executed and we are not sure about its actual status.
        /// </summary>
        SupplierTimeout = 51,
        /// <summary>
        /// Error returned from supplier API that we could not map to other codes.
        /// Supplier booking request was executed and we are not sure about its actual status.
        /// </summary>
        UnknownRequestError = 60,
        /// <summary>
        /// Request exception occured.
        /// Supplier booking request was executed and we are not sure about its actual status.
        /// </summary>
        RequestException = 70
    }
}