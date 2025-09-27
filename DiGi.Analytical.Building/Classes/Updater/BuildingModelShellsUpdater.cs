using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModelShellsUpdater : BuildingModelUpdater
    {
        public BuildingModelShellsUpdater(BuildingModel value)
            : base(value)
        {

        }
        
        public List<Shell>? Shells { get; set; }
        
        public double Tolerance { get; set; } = Core.Constans.Tolerance.Distance;
        
        public HashSet<IUniqueReference>? UpdatedComponentUniqueReferences { get; set; } = null;
        
        public override bool Update()
        {
            return Update(out _);
        }

        public bool Update(out List<ISpace>? spaces)
        {
            spaces = null;

            if (Value is null || Shells is null || Shells.Count == 0)
            {
                return false;
            }

            BuildingModelShellUpdater buildingModelShellUpdater = new (Value);

            UpdatedComponentUniqueReferences ??= [];

            spaces = [];

            foreach (Shell shell in Shells)
            {
                if(shell is null)
                {
                    continue;
                }

                buildingModelShellUpdater.Shell = shell;
                buildingModelShellUpdater.UpdatedComponentUniqueReferences = UpdatedComponentUniqueReferences;

                if (!buildingModelShellUpdater.Update(out ISpace? space) || space is null)
                {
                    continue;
                }

                spaces.Add(space);
                UpdatedComponentUniqueReferences = buildingModelShellUpdater.UpdatedComponentUniqueReferences;
            }

            return spaces != null && spaces.Count > 0;
        }
    }
}
