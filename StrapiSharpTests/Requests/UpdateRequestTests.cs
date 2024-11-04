namespace StrapiSharpTests.Requests;

public class UpdateRequestTests
{
	/// <summary>
	/// Tests creating a new <see cref="UpdateRequest"/> and that properties match.
	/// Use ID.
	/// </summary>
	[Test]
	public void UpdateRequestWithId()
	{
		const string body = """{ "data": "request body data" }""";
		var request = new UpdateRequest("testing", 32, body);
		request.Method.Should().Be(RequestMethod.Put);
		request.ContentType.Should().Be("testing");
		request.Path.Should().Be("/32");
		request.Body.Should().Be(body);
	}

	/// <summary>
	/// Tests creating a new <see cref="UpdateRequest"/> and that properties match.
	/// Use document ID.
	/// </summary>
	[Test]
	public void UpdateRequestWithDocumentId()
	{
		const string body = """{ "data": "request body data" }""";
		var request = new UpdateRequest("testing", "test3identifier3a32137", body);
		request.Method.Should().Be(RequestMethod.Put);
		request.ContentType.Should().Be("testing");
		request.Path.Should().Be("/test3identifier3a32137");
		request.Body.Should().Be(body);
	}
}
