﻿using animal_service.Handlers.UserController.Put;
using FluentValidation;

namespace animal_service.Handlers.UserController.Validator;

/// <summary>
/// Data validator for the role update method
/// </summary>
public class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
{
    /// <inheritdoc />
    public UpdateRoleCommandValidator()
    {
        RuleFor(command => command.Name).NotEmpty().WithMessage("Name is required.");
    }
}