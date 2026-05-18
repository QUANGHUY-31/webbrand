namespace assetsbackend.Domain.Entity;
public class Comment
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Email { get; set; }
		public required string Message { get; set; }
	}
