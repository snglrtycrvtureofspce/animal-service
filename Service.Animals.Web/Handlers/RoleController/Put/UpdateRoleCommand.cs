﻿using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Put;

/// <inheritdoc />
public class UpdateRoleCommand : IRequest<RoleViewModel>
{
    public Guid RoleId { get; set; }
    public string Name { get; set; }
}