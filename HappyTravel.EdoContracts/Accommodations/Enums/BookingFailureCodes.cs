namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    public enum BookingFailureCodes
    {
        Unknown = 0,
        ConnectorValidationFailure = 10,
        ValuationResultNotFound = 20,
        PreBookingFailure = 30,
        SupplierValidationFailure = 40,
        SupplierRejected = 50,
        UnknownRequestError = 60,
        RequestException = 70
    }
}