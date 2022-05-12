using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Contracts;

public interface ISmsService
{
    void SendSms(SmsBody smsBody);
}

public class SmsBody
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
}