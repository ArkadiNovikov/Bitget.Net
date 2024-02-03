﻿using Bitget.Net.Enums;
using Newtonsoft.Json;

namespace Bitget.Net.Objects.Models
{
    /// <summary>
    /// Trade info
    /// </summary>
    public class BitgetTrade
    {
        /// <summary>
        /// The symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Trade id
        /// </summary>
        [JsonProperty("tradeId")]
        public string TradeId { get; set; } = string.Empty;
        /// <summary>
        /// Side
        /// </summary>
        [JsonProperty("side")]
        public BitgetOrderSide Side { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("fillPrice")]
        public decimal Price { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("fillQuantity")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty("fillTime")]
        public DateTime Timestamp { get; set; }
    }
}
