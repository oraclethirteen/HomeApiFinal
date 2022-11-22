using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов на обновление комнаты
    /// </summary>
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.NewArea).NotEmpty();
            RuleFor(x => x.NewVoltage).NotEmpty();
            RuleFor(x => x.NewGasConnected).NotEmpty();
        }
    }
}
