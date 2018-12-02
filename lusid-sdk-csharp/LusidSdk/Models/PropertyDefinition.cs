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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PropertyDefinition
    {
        /// <summary>
        /// Initializes a new instance of the PropertyDefinition class.
        /// </summary>
        public PropertyDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PropertyDefinition class.
        /// </summary>
        /// <param name="valueType">Possible values include: 'String', 'Int',
        /// 'Decimal', 'DateTime', 'Boolean', 'Map', 'List', 'PropertyArray',
        /// 'Percentage', 'BenchmarkType', 'Code', 'Id', 'Uri', 'ArrayOfIds',
        /// 'ArrayOfTransactionAliases', 'ArrayofTransactionMovements',
        /// 'ArrayofUnits', 'StringArray', 'CurrencyAndAmount', 'TradePrice',
        /// 'UnitCreation', 'Currency', 'UserId', 'MetricValue', 'QuoteId',
        /// 'ArrayOfQuoteIds'</param>
        /// <param name="lifeTime">Possible values include: 'Perpetual',
        /// 'TimeVariant'</param>
        /// <param name="type">Possible values include: 'Label',
        /// 'Metric'</param>
        /// <param name="unitSchema">Possible values include: 'NoUnits',
        /// 'Basic', 'Iso4217Currency'</param>
        /// <param name="domain">Possible values include: 'Trade', 'Portfolio',
        /// 'Security', 'Holding', 'ReferenceHolding', 'TxnType',
        /// 'Instrument'</param>
        public PropertyDefinition(string href = default(string), string key = default(string), string valueType = default(string), bool? valueRequired = default(bool?), string displayName = default(string), ResourceId dataTypeId = default(ResourceId), string lifeTime = default(string), string type = default(string), string unitSchema = default(string), string domain = default(string), string scope = default(string), string code = default(string), IList<Link> links = default(IList<Link>))
        {
            Href = href;
            Key = key;
            ValueType = valueType;
            ValueRequired = valueRequired;
            DisplayName = displayName;
            DataTypeId = dataTypeId;
            LifeTime = lifeTime;
            Type = type;
            UnitSchema = unitSchema;
            Domain = domain;
            Scope = scope;
            Code = code;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

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
        [JsonProperty(PropertyName = "valueRequired")]
        public bool? ValueRequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataTypeId")]
        public ResourceId DataTypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Perpetual', 'TimeVariant'
        /// </summary>
        [JsonProperty(PropertyName = "lifeTime")]
        public string LifeTime { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Label', 'Metric'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoUnits', 'Basic',
        /// 'Iso4217Currency'
        /// </summary>
        [JsonProperty(PropertyName = "unitSchema")]
        public string UnitSchema { get; set; }

        /// <summary>
        /// Gets possible values include: 'Trade', 'Portfolio', 'Security',
        /// 'Holding', 'ReferenceHolding', 'TxnType', 'Instrument'
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; set; }

    }
}
