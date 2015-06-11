using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ErrorValues
    {
        public static readonly string ContactSupportUserHelp = "An error occurred, please try again later. If the problem persists, contact support";

        public static readonly ProcessingError GENERIC_FATAL_BACKEND_ERROR = new ProcessingError(ContactSupportUserHelp, "", true);
    }
}
