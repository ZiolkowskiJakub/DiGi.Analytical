using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Analytical.Building
{
    public static partial class Modify
    {
        /// <summary>
        /// Replaces the given airs of the <see cref="BuildingModel"/> by physical components matching their geometry.
        /// <para>Each air is classified by <see cref="Query.PhysicalComponentType(IComponent, double)"/> and, when the resulting type passes the <paramref name="physicalComponentTypes"/> filter, replaced by <see cref="BuildingModel.ConvertAir(IAir, PhysicalComponentType, out IPhysicalComponent)"/>. Airs classified as <see cref="PhysicalComponentType.Undefined"/> and airs whose geometry does not suit the classified type are left untouched.</para>
        /// </summary>
        /// <remarks>
        /// Every converted air is REMOVED from the model together with all its relations and the physical component is stored under the SAME identifier, therefore every <see cref="Core.Classes.GuidReference"/> held for the air becomes stale - a reference carries the type of the object it points to, so it no longer resolves once the type changes.
        /// <para>The space binding of an air is preserved, but the openings it hosts are NOT re-hosted and its parameters are NOT carried over.</para>
        /// <para>The returned components are the CLONES returned by <see cref="BuildingModel.ConvertAir(IAir, PhysicalComponentType, out IPhysicalComponent)"/> - modifying them does not affect the model, pass them through <see cref="BuildingModel.Update(IComponent)"/> to store the changes.</para>
        /// </remarks>
        /// <typeparam name="TAir">The type of the air components to be converted.</typeparam>
        /// <param name="buildingModel">The <see cref="BuildingModel"/> to be modified. The model is modified in place.</param>
        /// <param name="airs">The airs to be converted. When null all airs of type <typeparamref name="TAir"/> of the <paramref name="buildingModel"/> are taken.</param>
        /// <param name="physicalComponentTypes">The physical component types the conversion is restricted to. When null no restriction is applied.</param>
        /// <param name="tolerance">The angle tolerance, in radians, used to classify the geometry of an air, within which its normal still counts as horizontal, i.e. as belonging to a wall.</param>
        /// <returns>The physical components the airs were replaced with, an empty list when no air was converted, or null when the <paramref name="buildingModel"/> is null or holds no airs of type <typeparamref name="TAir"/>.</returns>
        /// <seealso cref="Query.PhysicalComponentType(IComponent, double)"/>
        public static List<IPhysicalComponent>? ConvertAirs<TAir>(this BuildingModel? buildingModel, IEnumerable<TAir>? airs = null, IEnumerable<PhysicalComponentType>? physicalComponentTypes = null, double tolerance = Core.Constants.Tolerance.Angle) where TAir : IAir
        {
            if(buildingModel is null)
            {
                return null;
            }

            if (airs is null)
            {
                airs = buildingModel.GetComponents<TAir>();
            }

            if (airs is null)
            {
                return null;
            }

            if(!airs.Any())
            {
                return [];
            }

            HashSet<PhysicalComponentType>? physicalComponentTypes_Temp = physicalComponentTypes is null ? null : [.. physicalComponentTypes];

            List<IPhysicalComponent> result = [];
            foreach (TAir air in airs)
            {
                PhysicalComponentType physicalComponentType = Query.PhysicalComponentType(air, tolerance);

                if (physicalComponentTypes_Temp is not null && !physicalComponentTypes_Temp.Contains(physicalComponentType))
                {
                    continue;
                }

                buildingModel.ConvertAir(air, physicalComponentType, out IPhysicalComponent? physicalComponent);
                if(physicalComponent is not null)
                {
                    result.Add(physicalComponent);
                }
            }

            return result;
        }
    }
}
