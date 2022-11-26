using System;
namespace RabbitMQ.Watermark.Services
{
	public class ProductImageCreatedEvent
	{
		public ProductImageCreatedEvent()
		{
		}

		public string ImageName { get; set; }
	}
}

