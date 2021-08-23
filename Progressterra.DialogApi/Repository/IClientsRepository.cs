using Progressterra.DialogApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Progressterra.DialogApi.Repository
{
    public interface IDialogsRepository
    {
        Guid Get(IReadOnlyCollection<Guid> clientsIds);
    }
}
