using Microsoft.AspNetCore.Mvc;
using Progressterra.DialogApi.Repository;
using Progressterra.DialogApi.ViewModels;
using System;

namespace Progressterra.DialogApi.Controllers
{
    [ApiController]

    public class DialogsClientsController : ControllerBase
    {
        private readonly IDialogsRepository _dialogsRepository;

        public DialogsClientsController(
            IDialogsRepository dialogsRepository)
        {
            _dialogsRepository = dialogsRepository;
        }

        [HttpPut]
        [Route("dialog")]
        public Guid GetByClientsIds([FromBody] GetDialogsRequest request)
        {
            var clientIds = request.MapToModel();
            var dialogId = _dialogsRepository.Get(clientIds);

            return dialogId;
        }
    }
}
