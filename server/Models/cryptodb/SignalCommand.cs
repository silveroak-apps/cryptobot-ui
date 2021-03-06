using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptobotUi.Models.Cryptodb
{
  [Table("signal_command", Schema = "public")]
  public partial class SignalCommand
  {
    [NotMapped]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("@odata.etag")]
    public string ETag
    {
        get;
        set;
    }

    [ConcurrencyCheck]
    public Int64 strategy_condition_id
    {
      get;
      set;
    }
    public StrategyCondition StrategyCondition { get; set; }
    [Key]
    public Int64 id
    {
      get;
      set;
    }

    public IEnumerable<ExchangeOrder> ExchangeOrders { get; set; }
    [ConcurrencyCheck]
    public Int64 signal_id
    {
      get;
      set;
    }
    public Signal Signal { get; set; }
    [ConcurrencyCheck]
    public decimal price
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public decimal? quantity
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public int leverage
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime request_date_time
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime? action_date_time
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public Int64? market_event_id
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string signal_action
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string status
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string strategy_name
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string strategy_hash
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string strategy_data
    {
      get;
      set;
    }
  }
}
