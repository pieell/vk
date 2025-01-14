using FluentAssertions;
using NUnit.Framework;
using VkNet.Model.Attachments;

namespace VkNet.Tests.Models
{
	[TestFixture]

	public class StoryModel : BaseTest
	{
		[Test]
		public void ShouldDeserializeFromVkResponseToAttachment()
		{
			ReadJsonFile("Models", "story_attachment");

			var response = GetResponse();

			var attachment = Attachment.FromJson(response);

			attachment.Instance.Should().BeOfType<Story>();
		}
	}
}