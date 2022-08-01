using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentMethodManager : IPaymentMethodService
    {
        IPaymentMethodDal _paymentMethodDal;

        public PaymentMethodManager(IPaymentMethodDal paymentMethodDal)
        {
            _paymentMethodDal = paymentMethodDal;
        }

        public void Add(PaymentMethod paymentMethod)
        {
            _paymentMethodDal.Add(paymentMethod);
        }

        public void Delete(PaymentMethod paymentMethod)
        {
            _paymentMethodDal.Delete(paymentMethod);
        }

        public PaymentMethod Get(int paymentMethodId)
        {
            return _paymentMethodDal.Get(pm => pm.PaymentMethodId == paymentMethodId);
        }

        public List<PaymentMethod> GetAll()
        {
            return _paymentMethodDal.GetAll();
        }

        public void Update(PaymentMethod paymentMethod)
        {
            _paymentMethodDal.Update(paymentMethod);
        }
    }
}
