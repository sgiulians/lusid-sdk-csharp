// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UpdateDataTypeRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDataTypeRequest class.
        /// </summary>
        public UpdateDataTypeRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDataTypeRequest class.
        /// </summary>
        /// <param name="typeValueRange">Possible values include: 'Open',
        /// 'Closed'</param>
        /// <param name="valueType">Possible values include: 'String', 'Int',
        /// 'Decimal', 'DateTime', 'Boolean', 'Map', 'List', 'PropertyArray',
        /// 'Percentage', 'BenchmarkType', 'Code', 'Id', 'Uri', 'ArrayOfIds',
        /// 'ArrayOfTransactionAliases', 'ArrayofTransactionMovements',
        /// 'ArrayofUnits', 'StringArray', 'CurrencyAndAmount', 'TradePrice',
        /// 'UnitCreation', 'Currency', 'UserId', 'MetricValue', 'QuoteId',
        /// 'ArrayOfQuoteIds'</param>
        /// <param name="unitSchema">Possible values include: 'NoUnits',
        /// 'Basic', 'Iso4217Currency'</param>
        public UpdateDataTypeRequest(string typeValueRange, string displayName, string description, string valueType, IList<object> acceptableValues = default(IList<object>), string unitSchema = default(string), IList<CreateUnitDefinition> acceptableUnits = default(IList<CreateUnitDefinition>))
        {
            TypeValueRange = typeValueRange;
            DisplayName = displayName;
            Description = description;
            ValueType = valueType;
            AcceptableValues = acceptableValues;
            UnitSchema = unitSchema;
            AcceptableUnits = acceptableUnits;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Open', 'Closed'
        /// </summary>
        [JsonProperty(PropertyName = "typeValueRange")]
        public string TypeValueRange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'String', 'Int', 'Decimal',
        /// 'DateTime', 'Boolean', 'Map', 'List', 'PropertyArray',
        /// 'Percentage', 'BenchmarkType', 'Code', 'Id', 'Uri', 'ArrayOfIds',
        /// 'ArrayOfTransactionAliases', 'ArrayofTransactionMovements',
        /// 'ArrayofUnits', 'StringArray', 'CurrencyAndAmount', 'TradePrice',
        /// 'UnitCreation', 'Currency', 'UserId', 'MetricValue', 'QuoteId',
        /// 'ArrayOfQuoteIds'
        /// </summary>
        [JsonProperty(PropertyName = "valueType")]
        public string ValueType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "acceptableValues")]
        public IList<object> AcceptableValues { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoUnits', 'Basic',
        /// 'Iso4217Currency'
        /// </summary>
        [JsonProperty(PropertyName = "unitSchema")]
        public string UnitSchema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "acceptableUnits")]
        public IList<CreateUnitDefinition> AcceptableUnits { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TypeValueRange == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeValueRange");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (ValueType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ValueType");
            }
            if (AcceptableUnits != null)
            {
                foreach (var element in AcceptableUnits)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
