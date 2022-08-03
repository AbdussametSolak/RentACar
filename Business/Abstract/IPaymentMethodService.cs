using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentMethodService
    {
        void Add(PaymentMethod paymentMethod);
        void Update(PaymentMethod paymentMethod);
        void Delete(PaymentMethod paymentMethod);
        public List<PaymentMethod> GetAll();
        public PaymentMethod Get(int paymentMethodId);
    }
}
