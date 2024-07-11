using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatChecker;

public class CheckVatResponse
{
    public string countryCode { get; set; }
    public string vatNumber { get; set; }
    public string requestDate { get; set; }
    public bool valid { get; set; }
    public string requestIdentifier { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public string traderName { get; set; }
    public string traderStreet { get; set; }
    public string traderPostalCode { get; set; }
    public string traderCity { get; set; }
    public string traderCompanyType { get; set; }
    public Match traderNameMatch { get; set; }
    public Match traderStreetMatch { get; set; }
    public Match traderPostalCodeMatch { get; set; }
    public Match traderCityMatch { get; set; }
    public Match traderCompanyTypeMatch { get; set; }
}
