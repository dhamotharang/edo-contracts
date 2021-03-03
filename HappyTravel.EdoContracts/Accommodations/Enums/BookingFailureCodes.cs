namespace HappyTravel.EdoContracts.Accommodations.Enums
{
    // Newtonsoft ProblemDetailsConverter extracts the numbers as int64: https://github.com/dotnet/aspnetcore/blob/main/src/Mvc/Mvc.NewtonsoftJson/src/ProblemDetailsConverter.cs
    public enum BookingFailureCodes : long
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