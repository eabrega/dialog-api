using FluentAssertions;
using Progressterra.DialogApi.Repository;
using System;
using System.Linq;
using Xunit;

namespace Progressterra.Tests
{
    public class RepositoryTests
    {
        private readonly IDialogsRepository _dialogsRepository;

        private readonly Guid[] _clientsIds = new[] {
             Guid.Parse("4b6a6b9a-2303-402a-9970-6e71f4a47151"),
             Guid.Parse("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820"),
        };

        private readonly Guid _dialogId = Guid.Parse("19f6f751-7f8d-41fa-8261-709028650592");

        public RepositoryTests()
        {
            _dialogsRepository = new DialogsRepository();
        }

        [Fact]
        public void GetDialogTest_ShuldBeReturnDialogId()
        {
            var dialogId = _dialogsRepository.Get(_clientsIds);
            dialogId.Should().Equals(_dialogId);
        }

        [Fact]
        public void GetDialogTest_ShuldBeReturnEmptyId()
        {
            var newClientsId = _clientsIds.ToList();
            newClientsId.RemoveAt(1);

            var dialogId = _dialogsRepository.Get(newClientsId);
            dialogId.Should().Equals(Guid.Empty);
        }

    }
}
