using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCaptcha
{
    public class AntiCaptchaException : Exception
    {
        public AntiCaptchaException()
        {
        }

        public AntiCaptchaException(string message) : base(message)
        {
        }
    }
}
