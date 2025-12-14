using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace SharedKernel.MessageBus.Kafka.Configurations
{
    public sealed class KafkaOptions
    {
        public string BootstrapServers { get; init; } = default!;
        public string ClientId { get; init; } = default!;
        public ProducerOptions Producer { get; init; } = new();
        public ConsumerOptions Consumer { get; init; } = new();
    }

    public sealed class ProducerOptions
    {
        public Acks Acks { get; init; } = Acks.All;
        public int MessageTimeoutMs { get; init; } = 30000;
    }

    public sealed class ConsumerOptions
    {
        public string GroupId { get; init; } = default!;
        public bool EnableAutoCommit { get; init; } = false;
        public AutoOffsetReset AutoOffsetReset { get; init; } = AutoOffsetReset.Earliest;
    }
}
