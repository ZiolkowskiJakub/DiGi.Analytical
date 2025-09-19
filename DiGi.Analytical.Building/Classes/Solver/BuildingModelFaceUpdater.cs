using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModelFaceUpdater : BuildingModelUpdater
    {
        private bool replace = true; 

        public Face Face { get; set; }

        public override bool Update()
        {
            if(Face is null || Value is null)
            {
                return false;
            }

            IComponent? component = Value.GetObject<IComponent>(Face.UniqueReference as GuidReference);
            if(component is not null)
            {
                List<IBuildingRelation>? buildingRelations = Value.GetRelations<IBuildingRelation>(component);
            }

            //if (replace)
            //{
            //    IComponent? component = 
            //}

            throw new System.NotImplementedException();

        }
    }
}
