using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;
namespace DiGi.Analytical.Building.Classes.Updater
{
    public class SpaceRelation : OneToManyBidirectionalRelation<IComponent, ISpace>, IBuildingRelation
    {
        public SpaceRelation(JsonObject? jsonObject) 
            : base(jsonObject)
        {
        }

        public SpaceRelation(IComponent? component, ISpace? space)
            : base(component, Core.Query.CloneAndFilterNulls([space]))
        {

        }

        public SpaceRelation(IComponent? component, ISpace? space_1, ISpace? space_2)
            : base(component, Core.Query.CloneAndFilterNulls([space_1, space_2]))
        {

        }

        public SpaceRelation(SpaceRelation? spaceRelation)
            : base(spaceRelation)
        {

        }


    }
}
