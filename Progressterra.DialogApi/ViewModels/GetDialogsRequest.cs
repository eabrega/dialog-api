using System;
using System.Collections.Generic;

namespace Progressterra.DialogApi.ViewModels
{
    public class GetDialogsRequest
    {
        public IReadOnlyCollection<Guid> ClientsIds { get; set; }
    }
}
