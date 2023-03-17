using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dependencies;
using Microsoft.Extensions.Logging;

namespace Core.Aspects.Logging
{
    public class LogAttribute : AttributeBase
    {
        public LogLevel Level { get; set; }
    }
}
