using System;
using System.Collections.Generic;
using System.Linq;

namespace Progressterra.DialogApi.Repository
{
    public class DialogsRepository : IDialogsRepository
    {
        private readonly IReadOnlyDictionary<Guid, Guid[]> _dialogClients;

        public DialogsRepository()
        {
            _dialogClients = InitRepository();
        }

        public Guid Get(IReadOnlyCollection<Guid> clientsIds)
        {
            foreach (var clients in _dialogClients)
            {
                if (clients.Value.Length != clientsIds.Count)
                {
                    continue;
                }

                if (clients.Value.SequenceEqual(clientsIds))
                {
                    return clients.Key;
                }
            }

            return Guid.Empty;
        }

        private static Dictionary<Guid, Guid[]> InitRepository() {
            var clients = RGDialogsClients.Init();

            return clients
                .GroupBy(x => x.IDRGDialog)
                .ToDictionary(
                    x => x.Key,
                    y => y.Select(c => c.IDClient).ToArray());
        }
    }
}
