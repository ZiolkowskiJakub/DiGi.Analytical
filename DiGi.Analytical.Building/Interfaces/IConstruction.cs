﻿namespace DiGi.Analytical.Building.Interfaces
{
    public interface IConstruction : IBuildingUniqueObject
    {
        IStructure Structure { get; }
    }
}