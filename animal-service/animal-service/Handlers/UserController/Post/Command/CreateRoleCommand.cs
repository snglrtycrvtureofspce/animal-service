﻿using animal_service.ViewModels;
using MediatR;

namespace animal_service.Handlers.UserController.Post.Command;

/// <inheritdoc />
public class CreateRoleCommand: IRequest<RoleViewModelSummary>
{
    public string Name { get; set; }
}