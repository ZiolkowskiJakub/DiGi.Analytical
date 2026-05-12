using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class RegulationAct : SerializableObject, IHVACNamedObject, IDescribableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Description))]
        private readonly string? description;

        [JsonInclude, JsonPropertyName(nameof(EffectiveDate))]
        private readonly DateTime effectiveDate;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(PublicationDate))]
        private readonly DateTime publicationDate;

        [JsonInclude, JsonPropertyName(nameof(Reference))]
        private readonly string? reference;

        public RegulationAct(DateTime publicationDate, DateTime effectiveDate, string? reference, string? name, string? descriprion)
            : base()
        {
            this.publicationDate = publicationDate;
            this.effectiveDate = effectiveDate;
            this.reference = reference;
            this.name = name;
            this.description = descriprion;
        }

        public RegulationAct(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public RegulationAct(RegulationAct regulationAct)
            : base(regulationAct)
        {
            if (regulationAct is not null)
            {
                publicationDate = regulationAct.PublicationDate;
                effectiveDate = regulationAct.EffectiveDate;
                reference = regulationAct.Reference;
                name = regulationAct.Name;
                description = regulationAct.Description;
            }
        }

        [JsonIgnore]
        public string? Description
        {
            get
            {
                return description;
            }
        }

        [JsonIgnore]
        public DateTime EffectiveDate
        {
            get
            {
                return effectiveDate;
            }
        }

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public DateTime PublicationDate
        {
            get
            {
                return publicationDate;
            }
        }

        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}