﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.EmailSending
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
