using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCaptcha.GetQueueStats
{
    public enum QueueIdEnum
    {
        ImageToTextEnglish = 1,
        ImageToTextRussian = 2,
        RecaptchaNoCaptcha = 5,
        RecaptchaProxyless = 6
    }
}

