using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAcymailingGeolocation
    {
        public uint GeolocationId { get; set; }
        public uint GeolocationSubid { get; set; }
        public string GeolocationType { get; set; }
        public string GeolocationIp { get; set; }
        public uint GeolocationCreated { get; set; }
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
