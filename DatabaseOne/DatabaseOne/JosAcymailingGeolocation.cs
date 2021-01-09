using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingGeolocation
    {
        public int GeolocationId { get; set; }
        public int GeolocationSubid { get; set; }
        public string GeolocationType { get; set; }
        public string GeolocationIp { get; set; }
        public int GeolocationCreated { get; set; }
        public decimal GeolocationLatitude { get; set; }
        public decimal GeolocationLongitude { get; set; }
        public string GeolocationPostalCode { get; set; }
        public string GeolocationCountry { get; set; }
        public string GeolocationCountryCode { get; set; }
        public string GeolocationState { get; set; }
        public string GeolocationStateCode { get; set; }
        public string GeolocationCity { get; set; }
        public string GeolocationContinent { get; set; }
        public string GeolocationTimezone { get; set; }
    }
}
