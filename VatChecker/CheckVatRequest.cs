using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatChecker;

public class CheckVatRequest
{
    public string countryCode { get; set; }
    public string vatNumber { get; set; }
    public string requesterMemberStateCode { get; set; }
    public string requesterNumber { get; set; }
    public string traderName { get; set; }
    public string traderStreet { get; set; }
    public string traderPostalCode { get; set; }
    public string traderCity { get; set; }
    public string traderCompanyType { get; set; }
}
