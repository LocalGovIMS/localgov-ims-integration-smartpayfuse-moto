using Application.Commands;
using Application.Entities;

namespace Application.Extensions
{
    public static class PaymentExtensions
    {
        public static bool CardDetailsNeedUpdating(this Payment payment)
        {
            return payment.Status == LocalGovIMSResults.Authorised && payment.CardPrefix == null;
        }
    }
}
