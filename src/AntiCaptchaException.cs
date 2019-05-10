using System;

namespace AntiCaptcha
{
    public class AntiCaptchaException : Exception
    {
        public AntiCaptchaException() { }

        public AntiCaptchaException(string message) : base(message) { }
    }
}