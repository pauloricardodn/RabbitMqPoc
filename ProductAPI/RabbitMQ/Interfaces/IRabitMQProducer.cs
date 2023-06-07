namespace ProductAPI.RabbitMQ.Interfaces
{
    public interface IRabitMQProducer
    {
        public void SendProductMessage<T>(T message);
    }
}
