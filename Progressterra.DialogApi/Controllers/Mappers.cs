using Progressterra.DialogApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Progressterra.DialogApi.Controllers
{
    public static class Mappers
    {
        public static IReadOnlyCollection<Guid> MapToModel(this GetDialogsRequest request)
        {
            return request.ClientsIds.ToArray();
        }
    }
}
