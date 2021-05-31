namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    public enum BookingFailureCodes
    {
        Unknown = 0,
        ConnectorValidationFailed = 10,
        ValuationResultNotFound = 20,
        PreBookingFailed = 30,
        SupplierValidationFailed = 40,
        SupplierRejected = 50,
        UnknownRequestError = 60,
        RequestException = 70
    }
}