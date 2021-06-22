using System;
using System.Diagnostics.CodeAnalysis;

namespace frontend.Models
{
        [ExcludeFromCodeCoverage]
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
