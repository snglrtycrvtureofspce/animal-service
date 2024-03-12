﻿using snglrtycrvtureofspce.Core.Base.Infrastructure;

namespace snglrtycrvtureofspce.Animal.ViewModels;

public class AnimalTypeViewModel : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime ModificationDate { get; set; }
    #endregion
    
    public string Name { get; set; }

    public string Description { get; set; }
}